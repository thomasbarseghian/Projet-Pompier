using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Barseghian_Nezami_SAE25.Utils;

namespace Barseghian_Nezami_SAE25
{
    public partial class frmLogin : Form
    {
        SQLiteConnection conn = Connexion.Connec;
        public frmLogin()
        {
            InitializeComponent();
            this.FormClosing += Login_FormClosing;
        }

        // le curseur (focus) est sur la zone de texte txtName lorsque votre formulaire frmLogin s'ouvre
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => txtName.Focus()));
        }
        
        // Si annuler le login form 
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        // Event pour verifier si login est avec succées ou pas
        private void btnValider_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Admin";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (txtName.Text == reader["login"].ToString() &&
                        txtPass.Text == reader["mdp"].ToString())
                    {
                        MessageBox.Show("Connecté avec succès");

                        this.DialogResult = DialogResult.OK; // Set success
                        this.Close();
                        return;
                    }
                }

                MessageBox.Show("Login or password incorrect, try again");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnValider_Click_1(sender, e);
                e.Handled = true;
            }
        }
    }
}
