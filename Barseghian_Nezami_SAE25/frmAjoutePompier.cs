using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barseghian_Nezami_SAE25.Utils;

namespace Barseghian_Nezami_SAE25
{
    public partial class frmAjoutePompier : Form
    {
        SQLiteConnection conn = Connexion.Connec;
        public frmAjoutePompier()
        {
            InitializeComponent();
            LoadCaserneList();
            changeHeaderPosition();
        }
        // Remplir caserne à partir de base de donnée
        private void LoadCaserneList()
        {
            try
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection is not initialized.");
                    return;
                }
                string query = "SELECT id, nom FROM Caserne";
                var adapter = new SQLiteDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);

                cboCaserne.DataSource = dt;
                cboCaserne.DisplayMember = "nom";
                cboCaserne.ValueMember = "id";
                cboCaserne.SelectedIndex = -1;

                // Remplir Grade
                string query1 = "SELECT * FROM Grade";
                var adapter1 = new SQLiteDataAdapter(query1, conn);
                var dt1 = new DataTable();
                adapter1.Fill(dt1);

                cboGrade.DataSource = dt1;
                cboGrade.DisplayMember = "libelle";
                cboGrade.ValueMember = "code";
                cboGrade.SelectedIndex = -1;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }
        
        void changeHeaderPosition()
        {
            lblHeader.Location = new Point(
            (this.ClientSize.Width - lblHeader.Width) / 2,
            lblHeader.Location.Y);
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void pnlHeader_Resize(object sender, EventArgs e)
        {
            changeHeaderPosition();
        }
        
        // Conception personnalisée
        private void cboCaserne_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var item = cboCaserne.Items[e.Index] as DataRowView;
            string text = item["nom"].ToString();

            e.DrawBackground();

            using (Brush whiteBrush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(text, e.Font, whiteBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        // Conception personnalisée
        private void cboGrade_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var item = cboGrade.Items[e.Index] as DataRowView;
            string text = item["libelle"].ToString(); // <- Use the correct column name here

            e.DrawBackground();

            using (Brush whiteBrush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(text, e.Font, whiteBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        // Pour s'assurer que le formulaire est correctement rempli
        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider1.Clear(); // Clear previous errors

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                errorProvider1.SetError(txtNom, "Nom est requis");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                errorProvider1.SetError(txtPrenom, "Prénom est requis");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Téléphone est requis");
                isValid = false;
            }
            else if (txtPhone.Text.Length != 10)
            {
                errorProvider1.SetError(txtPhone, "Le téléphone doit contenir exactement 10 chiffres");
                isValid = false;
            }

            if (cboCaserne.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboCaserne, "Veuillez choisir une caserne");
                isValid = false;
            }
            if (cboGrade.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboGrade, "Veuillez choisir une Grade");
                isValid = false;
            }

            if (!rdbFemme.Checked && !rdbHomme.Checked)
            {
                errorProvider1.SetError(pnlGenre, "Veuillez choisir une genre");
                isValid = false;
            }
            if (!rdbPompier.Checked && !rdbVolantaire.Checked)
            {
                errorProvider1.SetError(pnlType, "Veuillez choisir Type");
                isValid = false;
            }
            return isValid;
        }

        // Ajouter pompier apres validation 
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }
            try
            {
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string phone = txtPhone.Text;
                string grade = cboGrade.SelectedValue.ToString();
                var dob = dtpNaissance.Value.ToString("yyyy-MM-dd");
                var da = dtpEmbauche.Value.ToString("yyyy-MM-dd");
                string sexe = rdbFemme.Checked ? "f" : "m";
                string type = rdbPompier.Checked ? "p" : "v";
                int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);

               
                string query1 = "SELECT MAX(matricule) FROM Pompier";
                var cmd = new SQLiteCommand(query1, conn);
                object result = cmd.ExecuteScalar();
                int matricule = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;


                /*string message = $"Id : {matricule}\n" + $"Nom : {nom}\n" +
                $"Prénom : {prenom}\n" +
                $"Téléphone : {phone}\n" +
                $"Date de naissance : {dob}\n" +
                $"Date d'embauche : {da}\n" +
                $"Sexe : {sexe}\n" +
                $"Type : {type}\n" +
                $"ID Caserne : {idCaserne}";

                MessageBox.Show(message, "Données du pompier");*/

                string query2 = $@" INSERT INTO Pompier
                                VALUES({matricule}, '{nom}', '{prenom}', 
                                '{sexe}', '{dob}', '{type}', 
                                '{phone}', {matricule}, 0, 0, 
                                '{grade}', '{da}');";
                cmd = new SQLiteCommand(query2, conn);
                cmd.ExecuteNonQuery();

                string query3 = $@"INSERT INTO Affectation 
                                    (matriculePompier, dateA, idCaserne )
                                    VALUES ({matricule}, DATE('now'), {idCaserne})";
                cmd = new SQLiteCommand(query3, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("nouveau pompier ajouté avec succès");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Pour s'assurer que le Text box est correctement traité
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Pour bloquer tous sauf lettre
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Pour bloquer tous sauf character
            }
        }

    }
}
