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


namespace Barseghian_Nezami_SAE25
{
   
    public partial class ucRessourceHumain : UserControl
    {
        SQLiteConnection conn = Connexion.Connec;
        
        public ucRessourceHumain()
        {
            InitializeComponent();
            // Remplir comboBox de caserne à partir de la base de données
            string query = "Select * from Caserne";
            cboCaserne.Items.Clear();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboCaserne.Items.Add(reader["nom"].ToString());
            }  
            this.Dock = DockStyle.Fill;
            // styling login
            pnlLogin.Location = new Point(
            (this.ClientSize.Width - pnlLogin.Width) / 2,  // Center horizontally
            (this.ClientSize.Height - pnlLogin.Height) / 2  // Center vertically
        );
        }
       
        private void btnValider_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Admin";
            SQLiteCommand cmd  = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string login = reader["login"].ToString();
                string password = reader["mdp"].ToString();
                if(txtName.Text == login && txtPass.Text == password)
                {
                    MessageBox.Show("Logged in successfully");
                    tlpUserSettings.Dock = DockStyle.Fill;
                    tlpUserSettings.Visible = true;
                    pnlLogin.Visible = false;
                    return;
                }
            }
            MessageBox.Show("Login or password incorrect try again");
        }

        private void ucRessourceHumain_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(
           (this.ClientSize.Width - pnlLogin.Width) / 2,  // Center horizontally
           (this.ClientSize.Height - pnlLogin.Height) / 2  // Center vertically
       );
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remplir comboBox de Pompier à fonctionne de la caserne Choisir
            int index = cboCaserne.SelectedIndex + 1;
            cboPompier.SelectedIndex = -1; // Reset selection
            cboPompier.Text = "";          // Clear displayed text
            cboPompier.Items.Clear();      // Remove all items
            pnlInfoCarrière.Visible = false;
            pnlInfoPersonal.Visible = false;
            string query = "SELECT * FROM Affectation A " +
                "Join Pompier P ON A.matriculePompier = P.matricule " +
                "WHERE idCaserne = " + index ;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nomPrenom = reader["prenom"] + " " + reader["nom"];
                PompierComboItem item = new PompierComboItem
                {
                    nom = nomPrenom,
                    matricule = reader["matriculePompier"].ToString()
                };

                cboPompier.Items.Add(item);
            }
          
        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPompier.SelectedItem is PompierComboItem selectedItem)
            {
                pnlInfoCarrière.Visible = true;
                pnlInfoPersonal.Visible = true;
                int matricule = Convert.ToInt32(selectedItem.matricule);
                string query = "SELECT * FROM  Pompier P WHERE matricule = " + matricule;
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nomPompier.Text = reader["nom"].ToString();
                    prenomPompier.Text = reader["prenom"].ToString();
                    if (reader["sexe"].ToString() == "m")
                    {
                        lblSexe.Text = "Masculin";
                        Image imgP = Image.FromFile(@"..\..\Resources\Profiles\pompier.png");
                        pbPompier.Image = imgP;

                    }
                    else
                    {
                        lblSexe.Text = "Feminine";
                        Image imgP = Image.FromFile(@"..\..\Resources\Profiles\pompierF.png");
                        pbPompier.Image = imgP;
                    }
                    lblDOB.Text = reader["dateNaissance"].ToString();
                    lblTelephone.Text = reader["portable"].ToString();
                    lblMatricule.Text = matricule.ToString();
                    lblGrade.Text = reader["codeGrade"].ToString();
                    lblEmbauche.Text = reader["dateEmbauche"].ToString();
                    lblBip.Text = reader["bip"].ToString();
                    Image img = Image.FromFile(@"..\..\Resources\ImagesGrades\" + reader["codeGrade"] + ".png");
                    pbGrade.Image = img;
                    pbGrade.Location = new Point(462, (panel3.ClientSize.Height - pbGrade.Height) / 2);  // Center vertically
                    if (reader["type"].ToString() == "p")
                    {
                        rdvVolontaire.Checked = false;
                        rdbProfessionnel.Checked = true;
                    }
                    else
                    {
                        rdvVolontaire.Checked = true;
                        rdbProfessionnel.Checked = false;
                    }
                }

            }

        }

        private void pbEditGrade_Click(object sender, EventArgs e)
        {
            pnlChoisirGrade.Visible = true;
            string query = "SELECT * FROM  Grade ";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PompierComboItem item = new PompierComboItem
                {
                    nom = reader["libelle"].ToString(),
                    matricule = reader["code"].ToString()
                };
                cboGrade.Items.Add(item);
            }
        }
    }
    public class PompierComboItem
    {
        public string nom { get; set; }
        public string matricule { get; set; }
        public override string ToString()
        {
            return nom; // This tells the ComboBox what to show
        }
    }
}
