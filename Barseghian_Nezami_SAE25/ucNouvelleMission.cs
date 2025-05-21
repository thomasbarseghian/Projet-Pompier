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
        public ucNouvelleMission()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public ucNouvelleMission(DataSet ds)
        {
            InitializeComponent();
            cboCaserne.DataSource = ds.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //Mettre la date du jour et l'heure du jour
            lblDeclenche.Text += DateTime.Now;

            //Mettre le numero de la mission
            string query1 = "SELECT MAX(id) FROM Mission M;";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
            int numMission = Convert.ToInt32(cmd1.ExecuteScalar());
            lblMission.Text += Convert.ToString(numMission + 1);

            //remplir la comboBox avec les types de sinistres
            string query2 = "SELECT libelle FROM NatureSinistre;";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                cboNatureSinistre.Items.Add(reader["libelle"].ToString());
            }

            //remplir la comboBox avec les casernes
            string query3 = "SELECT nom FROM Caserne;";
            SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
            SQLiteDataReader reader2 = cmd3.ExecuteReader();
            while (reader2.Read())
            {
                cboCaserne.Items.Add(reader2["nom"].ToString());
            }
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

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Trouver l'id du sinistre
            string query1 = "SELECT id FROM NatureSinistre WHERE libelle=\"" + cboNatureSinistre.Text + "\"";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
            string numSinistre = Convert.ToString(cmd1.ExecuteScalar());

            //Trouver l'id du sinistre
            string query2 = "SELECT codeTypeEngin, nombre FROM Necessiter WHERE idNatureSinistre=" + numSinistre;
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader1 = cmd2.ExecuteReader();
            List <VehiculeNecessaire> listVehicule = new List<VehiculeNecessaire>();
            while (reader1.Read())
            {
                listVehicule.Add(new VehiculeNecessaire
                {
                    CodeTypeEngin = reader1["CodeTypeEngin"].ToString(),
                    nombre = Convert.ToInt32(reader1["nombre"])
                });
            }

        }

        private void cboNatureSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCaserne.Visible = true;
            cboCaserne.Visible = true;
        }
 
    }
    public class VehiculeNecessaire{
        public string CodeTypeEngin { get; set; }
        public int nombre { get; set; } 
    }
}
