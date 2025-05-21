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
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Barseghian_Nezami_SAE25
{
    public partial class ucRessourceHumain : UserControl
    {
        SQLiteConnection conn = Connexion.Connec;
        private bool isLogged = false;

        public ucRessourceHumain()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            CenterPanel(pnlLogin);
            LoadCaserneList();
        }

        private void CenterPanel(Control panel)
        {
            panel.Location = new Point(
                (this.ClientSize.Width - panel.Width) / 2,
                (this.ClientSize.Height - panel.Height) / 2
            );
        }

        private void LoadCaserneList()
        {
            string query = "SELECT id, nom FROM Caserne";
            var adapter = new SQLiteDataAdapter(query, conn);
            var dt = new DataTable();
            adapter.Fill(dt);

            cboCaserne.DataSource = dt;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";
            cboCaserne.SelectedIndex = -1;
        }

        private void cboCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedValue == null) return;

            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            pnlInfoCarrière.Visible = false;
            pnlInfoPersonal.Visible = false;
            cboPompier.SelectedIndex = -1;

            string query = $@"
                SELECT *, P.prenom || ' ' || P.nom AS FullName 
                FROM Affectation A
                JOIN Pompier P ON A.matriculePompier = P.matricule 
                WHERE idCaserne = {idCaserne} 
                AND dateFin is NULL";

            var adapter = new SQLiteDataAdapter(query, conn);
            var dt = new DataTable();
            adapter.Fill(dt);

            cboPompier.DataSource = dt;
            cboPompier.DisplayMember = "FullName";
            cboPompier.ValueMember = "matriculePompier";
            cboPompier.SelectedIndex = -1;
        }

        private void cboPompier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlInfoPersonal.Visible = true;
            pnlInfoCarrière.Visible = true;
            btnPlusInfoCarriere.Visible = true;
            chklstbHabilitation.Visible = false;
            btnConfirmHabilitation.Visible = false;
            pbEditHabilitations.Visible = true ;

            if (cboPompier.SelectedValue == null) return;
            int matricule = Convert.ToInt32(cboPompier.SelectedValue);

            string query = $"SELECT * FROM Pompier WHERE matricule = {matricule}";

            var cmd = new SQLiteCommand(query, conn);
            var reader = cmd.ExecuteReader();
            if (!reader.Read()) return;

            nomPompier.Text = reader["nom"].ToString();
            prenomPompier.Text = reader["prenom"].ToString();
            lblDOB.Text = reader["dateNaissance"].ToString();
            string num = reader["portable"].ToString();
            lblTelephone.Text = $"{num.Substring(0, 2)} {num.Substring(2, 2)} {num.Substring(4, 2)} {num.Substring(6, 2)} {num.Substring(8, 2)}";
            lblMatricule.Text = matricule.ToString();
            lblGrade.Text = reader["codeGrade"].ToString();
            lblEmbauche.Text = reader["dateEmbauche"].ToString();
            lblBip.Text = reader["bip"].ToString();
            
            string sexe = reader["sexe"].ToString();
            lblSexe.Text = (sexe == "m") ? "Masculin" : "Féminin";
            pbPompier.Image = Image.FromFile(sexe == "m"
                ? @"..\..\Resources\Profiles\pompier.png"
                : @"..\..\Resources\Profiles\pompierF.png");
            
            string gradeCode = reader["codeGrade"].ToString();
            pbGrade.Image = Image.FromFile($@"..\..\Resources\ImagesGrades\{gradeCode}.png");
            pbGrade.Location = new Point(462, (panel3.ClientSize.Height - pbGrade.Height) / 2);
            
            string type = reader["type"].ToString();
            rdbProfessionnel.Checked = (type == "p");
            rdvVolontaire.Checked = (type != "p");
            chkConge.Checked = reader["enConge"].ToString() == "0" ? false : true;  
            if (isLogged)
            {
                remplirHabilitations(matricule);
                remplirCaserneRattachement();
                remplirPanelGrade();
            }
        }

        private void remplirHabilitations(int matricule)
        {
            lbHabilitations.Items.Clear();

            string query = $@"
            SELECT H.id, H.libelle 
            FROM Passer P1
            JOIN Habilitation H ON P1.idHabilitation = H.id
            WHERE P1.matriculePompier = {matricule}";

            var adapter = new SQLiteDataAdapter(query, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                lbHabilitations.Items.Add(new HabilitationItem
                {
                    Id = dr["id"].ToString(),
                    Libelle = dr["libelle"].ToString()
                });
            }
        }
        private void pbEditHabilitations_Click(object sender, EventArgs e)
        {
            chklstbHabilitation.Items.Clear();

            chklstbHabilitation.Visible = true;
            btnConfirmHabilitation.Visible = true;
            pbEditHabilitations.Visible = false;
            string query = "SELECT * FROM HABILITATION";
            
            var adapter = new SQLiteDataAdapter(query, conn);
            var dt = new DataTable();
            adapter.Fill(dt);

            var existantLibelle = new List<string>();
            foreach(HabilitationItem item in lbHabilitations.Items)
            {
                existantLibelle.Add(item.Id);
            }

            foreach (DataRow row in dt.Rows)
            {
                string id = row["id"].ToString();
                if (!existantLibelle.Contains(id))
                {
                    chklstbHabilitation.Items.Add(new HabilitationItem
                    {
                        Id = id,
                        Libelle = row["libelle"].ToString()
                    });
                }
            }
        }
        private void btnConfirmHabilitation_Click(object sender, EventArgs e)
        {
            chklstbHabilitation.Visible = false;
            btnConfirmHabilitation.Visible = false;
            pbEditHabilitations.Visible = true ;
        }
        private void remplirCaserneRattachement()
        {
            lbAffectations.Items.Clear();
            var source = (DataTable)cboCaserne.DataSource;
            cboCaserneRattachement.DataSource = source.Copy();
            cboCaserneRattachement.DisplayMember = "nom";
            cboCaserneRattachement.ValueMember = "id";
            chkConge.Visible = true;
           
            if (cboPompier.SelectedValue == null) return;
            int matricule = Convert.ToInt32(cboPompier.SelectedValue);

            string query = $@"
                SELECT C.id, A.DateA, C.nom, A.DateFin 
                FROM Affectation A 
                JOIN Caserne C ON C.id = A.idCaserne 
                WHERE A.matriculePompier = {matricule}";

            var cmd = new SQLiteCommand(query, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idCaserne = reader["id"].ToString();
                string nom = reader["nom"].ToString();
                string dateA = reader["DateA"].ToString();
                string dateFin = reader["DateFin"].ToString();

                if (string.IsNullOrEmpty(dateFin))
                {
                    lblRattachement.Text = nom;
                    lblRattachement.Tag = idCaserne;
                }
                else
                {
                    lbAffectations.Items.Add($"{dateA} - {nom}");
                }
            }
            if (!string.IsNullOrEmpty(lblRattachement.Tag?.ToString()))
            {
                cboCaserneRattachement.SelectedValue = lblRattachement.Tag.ToString();
            }
        }
        private void cboCaserneRattachement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblRattachement.Text = cboCaserneRattachement.Text;
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Admin";

            var cmd = new SQLiteCommand(query, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (txtName.Text == reader["login"].ToString() &&
                    txtPass.Text == reader["mdp"].ToString())
                {
                       MessageBox.Show("Logged in successfully");
                    pnlLogin.Visible = false;
                    pnlPlusInfo.Visible = true;
                    pnlChoisirGrade.Visible = true;
                    lbllnfoCarriere.Visible = true;
                    isLogged = true;

                    remplirHabilitations(Convert.ToInt32(cboPompier.SelectedValue));
                    remplirCaserneRattachement();
                    remplirPanelGrade();
                    return;
                }
            }
            MessageBox.Show("Login or password incorrect, try again");
        }

        public void remplirPanelGrade()
        {
            string query = "SELECT * FROM Grade";
            var adapter = new SQLiteDataAdapter(query, conn);
            var dt = new DataTable();
            adapter.Fill(dt);

            cboGrade.DataSource = dt;
            cboGrade.DisplayMember = "libelle";
            cboGrade.ValueMember = "code";

            if (!string.IsNullOrEmpty(lblGrade.Text))
            {
                cboGrade.SelectedValue = lblGrade.Text;
            }
        }
        private void cboGrade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblGrade.Text = cboGrade.SelectedValue.ToString();
        }
        private void ucRessourceHumain_Resize(object sender, EventArgs e)
        {
            CenterPanel(pnlLogin);
        }

        private void pbEditGrade_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                pnlLogin.Visible = true;
                txtName.Focus();
            }
        }

        private void btnPlusInfoCarriere_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                pnlLogin.Visible = true;
                txtName.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnValider_Click(sender, e);
                e.Handled = true;
            }
        }

      

       


        private void button1_Click(object sender, EventArgs e)
        {
            int matricule = Convert.ToInt32(cboPompier.SelectedValue);
            int oldCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            string newGrade = cboGrade.SelectedValue?.ToString() ?? "";
            int newCaserne = cboCaserneRattachement.SelectedValue != null
                    ? Convert.ToInt32(cboCaserneRattachement.SelectedValue.ToString())
                     : -1;
            int enConge = chkConge.Checked == true ? 1 : 0;

            SQLiteTransaction maTransac = conn.BeginTransaction();
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = conn,
                Transaction = maTransac
            };
            try
            {
                cmd.CommandText = $@"UPDATE Pompier
                                set enConge = {enConge}
                                where matricule = {matricule}";
                cmd.ExecuteNonQuery();
                if(!string.IsNullOrEmpty(newGrade))
                {
                    cmd.CommandText = $@"UPDATE Pompier 
                                   SET codeGrade = '{newGrade}'  
                                   WHERE matricule = {matricule}";
                    cmd.ExecuteNonQuery();
                }
                if (newCaserne != -1 && newCaserne != oldCaserne)
                {
                    // Vérifier si déjà affecté aujourd'hui
                    cmd.CommandText = $@" SELECT COUNT(*) 
                                          FROM Affectation 
                                          WHERE matriculePompier = {matricule} 
                                          AND dateA = DATE('now')";
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        cmd.CommandText = $@"UPDATE Affectation 
                                    SET dateFin = DATE('now')
                                    WHERE matriculePompier = {matricule}
                                    and idCaserne = {oldCaserne}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = $@"INSERT INTO Affectation 
                                    (matriculePompier, dateA, idCaserne )
                                    VALUES ({matricule}, DATE('now'), {newCaserne})";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Ce pompier est déjà affecté à une caserne aujourd'hui.");
                    }
                }
                if(chklstbHabilitation.CheckedItems.Count > 0)
                {
                    foreach (HabilitationItem item in chklstbHabilitation.CheckedItems)
                    {
                        cmd.CommandText = $@"INSERT INTO Passer 
                                        VALUES({matricule}, {item.Id},DATE('now'))";
                        cmd.ExecuteNonQuery();
                    }
                }
                maTransac.Commit();
                MessageBox.Show("Transaction réussie !");
            }
            catch(Exception ex)
            {
                // annulation de la transaction
                maTransac.Rollback();
                MessageBox.Show("Transaction annulée !\n\nErreur : " + ex.Message +
                   "\n\nDétails : " + ex.StackTrace);
            }
           
           /* MessageBox.Show(newGrade);
            MessageBox.Show(newCaserne.ToString());
            MessageBox.Show(enConge.ToString());
            MessageBox.Show("count : " + chklstbHabilitation.CheckedItems.Count.ToString());*/
           

        }

        private void pbChoisirCaserne_Click(object sender, EventArgs e)
        {
            pnlChoisirCaserne.Visible = true;
        }
    }
    public class HabilitationItem
    {
        public string Id { get; set; }
        public string Libelle { get; set; }

        public override string ToString()
        {
            return Libelle; 
        }
    }
}
