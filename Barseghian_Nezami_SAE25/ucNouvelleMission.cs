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
        private DataSet dsLocal;
        public ucNouvelleMission()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public ucNouvelleMission(DataSet ds)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            dsLocal = ds;

            cboCaserne.DataSource = ds.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            lblDeclenche.Text += DateTime.Now;

            SQLiteConnection conn = Connexion.Connec;

            // 1. Récupérer le dernier id de mission
            SQLiteDataAdapter adapterId = new SQLiteDataAdapter("SELECT MAX(id) as maxId FROM Mission;", conn);
            DataTable tableId = new DataTable();
            adapterId.Fill(tableId);

            int numMission = 0;
            if (tableId.Rows.Count > 0 && tableId.Rows[0]["maxId"] != DBNull.Value)
                numMission = Convert.ToInt32(tableId.Rows[0]["maxId"]);
            lblMission.Text += (numMission + 1).ToString();

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



        private void txtRue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '\'' || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '/' || e.KeyChar == '&' || e.KeyChar == '(' || e.KeyChar == ')')
            {
                e.Handled = false;
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '\'')
            {
                e.Handled = false;
            }
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            //Trouver l'id du sinistre
            string query1 = "SELECT id FROM NatureSinistre WHERE libelle=\"" + cboNatureSinistre.Text + "\"";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
            string numSinistre = Convert.ToString(cmd1.ExecuteScalar());
            //Trouver les vehicules nécessaires
            string query2 = "SELECT codeTypeEngin, nombre FROM Necessiter WHERE idNatureSinistre=" + numSinistre;
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader1 = cmd2.ExecuteReader();
            List<VehiculeNecessaire> listVehiculeNecessaire = new List<VehiculeNecessaire>();
            while (reader1.Read())
            {
                listVehiculeNecessaire.Add(new VehiculeNecessaire
                {
                    CodeTypeEngin = reader1["CodeTypeEngin"].ToString(),
                    Numero = Convert.ToInt32(reader1["nombre"])
                });
            }

            List<VehiculeNecessaire> listVehicule = new List<VehiculeNecessaire>();
            List<int> listHabilitations = new List<int>();
            int idCaserne = cboCaserne.SelectedIndex+1;
            foreach (VehiculeNecessaire vehicule in listVehiculeNecessaire)
            {
                string query25 = "SELECT codeTypeEngin, numero FROM Engin WHERE codeTypeEngin =\"" + vehicule.CodeTypeEngin + "\" AND enMission = 0 AND enPanne = 0 AND idCaserne =" + idCaserne + " LIMIT " + vehicule.Numero;
                SQLiteCommand cmd25 = new SQLiteCommand(query25, conn);
                SQLiteDataReader reader25 = cmd25.ExecuteReader();
                while (reader25.Read())
                {
                    listVehicule.Add(new VehiculeNecessaire
                    {
                        CodeTypeEngin = reader25["codeTypeEngin"].ToString(),
                        Numero = Convert.ToInt32(reader25["numero"])
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
            dgvEngins.DataSource = listVehicule;
            List<int> pompiersAffectes = new List<int>();

            foreach (int hab in listHabilitations)
            {
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

                if (result != null)
                {
                    pompiersAffectes.Add(Convert.ToInt32(result));
                    btnCreer.Visible = true;
                }
                else
                {
                    pompiersAffectes.Add(-1); // Toujours ajouter une valeur
                    MessageBox.Show("Pas de pompiers disponible pour une des habilitation,\n la mission ne peut pas être déclenchée");
                }
            }
            // Affichage lisible dans le DataGridView
            var data = new List<object>();


            for (int i = 0; i < listHabilitations.Count; i++)
            {
                int habilitationId = listHabilitations[i];
                int pompier = pompiersAffectes[i]; // OK car même longueur

                data.Add(new
                {
                    MatriculePompier = pompier != -1 ? pompier.ToString() : "Aucun disponible",
                    Habilitation = habilitationId
                });
            }

            dgvPompiers.DataSource = data;
            grpEnginsPompiers.Visible = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            rtbMotif.Text = "";
            txtCP.Text = "";
            txtRue.Text = "";
            txtVille.Text = "";
            cboCaserne.SelectedIndex = -1;
            cboNatureSinistre.SelectedIndex = -1;
            btnEquipe.Visible = false;
            grpEnginsPompiers.Visible = false;
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

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                // ID mission
                int idMission = int.Parse(lblMission.Text.Substring(10));

                // 1. Ajouter ligne mission
                DataRow drMission = dsLocal.Tables["MissionsTemp"].NewRow();
                drMission["id"] = idMission;
                drMission["date"] = DateTime.Now;
                drMission["motif"] = rtbMotif.Text;
                drMission["rue"] = txtRue.Text;
                drMission["ville"] = txtVille.Text;
                drMission["codePostal"] = txtCP.Text;

                // ID nature sinistre
                string query = $"SELECT id FROM NatureSinistre WHERE libelle = \"{cboNatureSinistre.Text}\"";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                drMission["idNatureSinistre"] = Convert.ToInt32(cmd.ExecuteScalar());

                // ID caserne
                drMission["idCaserne"] = cboCaserne.SelectedIndex + 1;

                dsLocal.Tables["MissionsTemp"].Rows.Add(drMission);

                // 2. Engins associés
                foreach (DataGridViewRow row in dgvEngins.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataRow drEngin = dsLocal.Tables["EnginsTemp"].NewRow();
                    drEngin["idMission"] = idMission;
                    drEngin["numero"] = Convert.ToInt32(row.Cells["Numero"].Value);
                    dsLocal.Tables["EnginsTemp"].Rows.Add(drEngin);
                }

                // 3. Pompiers associés
                foreach (DataGridViewRow row in dgvPompiers.Rows)
                {
                    if (row.IsNewRow) continue;

                    string matricule = row.Cells["MatriculePompier"].Value.ToString();
                    if (matricule == "Aucun disponible") continue;

                    DataRow drPompier = dsLocal.Tables["PompiersTemp"].NewRow();
                    drPompier["idMission"] = idMission;
                    drPompier["matriculePompier"] = Convert.ToInt32(matricule);
                    dsLocal.Tables["PompiersTemp"].Rows.Add(drPompier);
                }

                MessageBox.Show("Mission créée.");
                rtbMotif.Text = "";
                txtCP.Text = "";
                txtRue.Text = "";
                txtVille.Text = "";
                cboCaserne.SelectedIndex = -1;
                cboNatureSinistre.SelectedIndex = -1;
                btnEquipe.Visible = false;
                grpEnginsPompiers.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur création mission : " + ex.Message);
            }
        }
    }
}
