using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Barseghian_Nezami_SAE25.Utils;
using System.Reflection;
using System.Data.SqlClient;

namespace Barseghian_Nezami_SAE25
{
    public partial class ucNouvelleMission : UserControl
    {
        SQLiteConnection conn = Connexion.Connec;
        private DataSet dsLocal = MesDatas.DsGlobal;
        public ucNouvelleMission()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            cboCaserne.DataSource = dsLocal.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {






            //CONNECTE FAUT ENLEVER
            SQLiteConnection conn = Connexion.Connec;





            lblDeclenche.Text += DateTime.Now;
            DataTable dtMission = dsLocal.Tables["Mission"];
            // 1. Récupérer le dernier id de mission

            long numMission = 0;
            var ids = dtMission.AsEnumerable().Select(row => row.Field<long>("id"));
            if (ids.Any())
            {
                numMission = ids.Max();
            }
            lblMission.Text += (numMission+1).ToString();

            // 2. Charger les types de sinistre
            SQLiteDataAdapter adapterSinistre = new SQLiteDataAdapter("SELECT libelle FROM NatureSinistre;", conn);
            DataTable tableSinistre = new DataTable();
            adapterSinistre.Fill(tableSinistre);
            cboNatureSinistre.DataSource = tableSinistre;
            cboNatureSinistre.DisplayMember = "libelle";
            cboNatureSinistre.SelectedIndex = -1;

            // 3. Charger les casernes
            SQLiteDataAdapter adapterCaserne = new SQLiteDataAdapter("SELECT nom FROM Caserne;", conn);
            DataTable tableCaserne = new DataTable();
            adapterCaserne.Fill(tableCaserne);
            cboCaserne.DataSource = tableCaserne;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.SelectedIndex = -1;


        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            rtbMotif.Text = "";
            rtbCP.Text = "";
            rtbRue.Text = "";
            rtbVille.Text = "";
            cboCaserne.SelectedIndex = -1;
            cboNatureSinistre.SelectedIndex = -1;
            btnEquipe.Visible = false;
            pnlEnginPompier.Visible = false;
        }

        private void cboNatureSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedIndex!=-1)
            {
                btnEquipe.Visible = true;
            }
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNatureSinistre.SelectedIndex != -1)
            {
                btnEquipe.Visible = true;
            }
        }


        private void rtbRue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '\'' || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '/' || e.KeyChar == '&' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
        }

        private void rtbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void rtbVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '\'')
            {
                e.Handled = false;
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMissionsTemp.DataSource = null;
                dgvMissionsTemp.DataSource = dsLocal.Tables["Mission"];

                int idMission = int.Parse(lblMission.Text.Substring(10));

                // Ajouter ligne mission
                DataRow drMission = dsLocal.Tables["Mission"].NewRow();
                drMission["id"] = idMission;
                drMission["dateHeureDepart"] = DateTime.Now;
                drMission["motifAppel"] = rtbMotif.Text;
                drMission["adresse"] = rtbRue.Text;
                drMission["ville"] = rtbVille.Text;
                drMission["cp"] = rtbCP.Text;
                drMission["terminee"] = "0";

                string query = $"SELECT id FROM NatureSinistre WHERE libelle = \"{cboNatureSinistre.Text}\"";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                drMission["idNatureSinistre"] = Convert.ToInt32(cmd.ExecuteScalar());

                drMission["idCaserne"] = cboCaserne.SelectedIndex + 1;

                dsLocal.Tables["Mission"].Rows.Add(drMission);

                MessageBox.Show("Mission créée.");

                rtbMotif.Text = "";
                rtbCP.Text = "";
                rtbRue.Text = "";
                rtbVille.Text = "";
                cboCaserne.SelectedIndex = -1;
                cboNatureSinistre.SelectedIndex = -1;
                btnEquipe.Visible = false;
                pnlEnginPompier.Visible = false;
                dgvMissionsTemp.DataSource = null;
                dgvMissionsTemp.DataSource = dsLocal.Tables["Mission"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur création mission : " + ex.Message);
            }
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            // 1. Trouver l'id du sinistre
            string query1 = "SELECT id FROM NatureSinistre WHERE libelle = @libelle";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@libelle", cboNatureSinistre.Text);
            string numSinistre = Convert.ToString(cmd1.ExecuteScalar());

            // 2. Récupérer les véhicules nécessaires
            string query2 = "SELECT codeTypeEngin, nombre FROM Necessiter WHERE idNatureSinistre = " + numSinistre;
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader1 = cmd2.ExecuteReader();

            List<VehiculeNecessaire> listVehiculeNecessaire = new List<VehiculeNecessaire>();
            while (reader1.Read())
            {
                listVehiculeNecessaire.Add(new VehiculeNecessaire
                {
                    CodeTypeEngin = reader1["codeTypeEngin"].ToString(),
                    Numero = Convert.ToInt32(reader1["nombre"])
                });
            }

            List<VehiculeNecessaire> listVehicule = new List<VehiculeNecessaire>();
            List<int> listHabilitations = new List<int>();
            int idCaserne = cboCaserne.SelectedIndex + 1;

            // 3. Trouver les engins disponibles et les habilitations nécessaires
            foreach (VehiculeNecessaire vehicule in listVehiculeNecessaire)
            {
                string queryEngins = $"SELECT codeTypeEngin, numero FROM Engin WHERE codeTypeEngin = \"{vehicule.CodeTypeEngin}\" AND enMission = 0 AND enPanne = 0 AND idCaserne = {idCaserne} LIMIT {vehicule.Numero}";
                SQLiteCommand cmdEngins = new SQLiteCommand(queryEngins, conn);
                SQLiteDataReader readerEngins = cmdEngins.ExecuteReader();

                while (readerEngins.Read())
                {
                    listVehicule.Add(new VehiculeNecessaire
                    {
                        CodeTypeEngin = readerEngins["codeTypeEngin"].ToString(),
                        Numero = Convert.ToInt32(readerEngins["numero"])
                    });
                }

                string query3 = "SELECT idHabilitation, nombre FROM Embarquer WHERE CodeTypeEngin = \"" + vehicule.CodeTypeEngin + "\"";
                SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
                SQLiteDataReader reader2 = cmd3.ExecuteReader();

                while (reader2.Read())
                {
                    int idHabilitation = Convert.ToInt32(reader2["idHabilitation"]);
                    int nombre = Convert.ToInt32(reader2["nombre"]);

                    for (int i = 0; i < nombre; i++)
                    {
                        listHabilitations.Add(idHabilitation);
                    }
                }
            }

            // 4. Affichage des engins dans le FlowLayoutPanel
            flpVehicules.Controls.Clear();
            foreach (VehiculeNecessaire vehicule in listVehicule)
            {
                ucAffichageEnginPompier item = new ucAffichageEnginPompier();
                item.SetDataEngin(vehicule.CodeTypeEngin, vehicule.Numero);
                flpVehicules.Controls.Add(item);
            }

            // 5. Trouver les pompiers disponibles
            List<int> pompiersAffectes = new List<int>();
            flpPompiers.Controls.Clear();

            for (int i = 0; i < listHabilitations.Count; i++)
            {
                int hab = listHabilitations[i];
                string query4 = $@"
            SELECT matriculePompier
            FROM Passer pass
            JOIN Pompier pomp ON pass.matriculePompier = pomp.matricule
            WHERE idHabilitation = {hab}
              AND pomp.enMission = 0
              AND pomp.enConge = 0
            LIMIT 1";

                SQLiteCommand cmd4 = new SQLiteCommand(query4, conn);
                object result = cmd4.ExecuteScalar();

                int matricule = -1;
                if (result != null)
                {
                    matricule = Convert.ToInt32(result);
                    btnCreer.Visible = true;
                }
                else
                {
                    MessageBox.Show("Pas de pompier disponible pour une des habilitations,\n la mission ne peut pas être déclenchée");
                }

                pompiersAffectes.Add(matricule);

                // 6. Affichage du pompier affecté
                ucAffichageEnginPompier item = new ucAffichageEnginPompier();
                item.SetDataPompier(matricule, hab);
                flpPompiers.Controls.Add(item);
            }

            // 7. Rendre visible le panel
            pnlEnginPompier.Visible = true;
        }
    }
}
