using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using Barseghian_Nezami_SAE25.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            LoadCaserneList();
        }

        // pour centrer n'importe quel Panel dans son parent (relatif)
        private void CenterPanel(Control panel)
        {
            panel.Location = new Point(
                (this.ClientSize.Width - panel.Width) / 2,
                (this.ClientSize.Height - panel.Height) / 2
            );
        }
       
        // Remplir caserne à partir de base de donnée
        private void LoadCaserneList()
        {
            try
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
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        // Event quand un Caserne est changer
        private void cboCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
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
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event quand un Pompier est changer
        private void cboPompier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
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
                
                lblEmbauche.Text = reader["dateEmbauche"].ToString();
                lblBip.Text = reader["bip"].ToString();
                
                string sexe = reader["sexe"].ToString();
                lblSexe.Text = (sexe == "m") ? "Masculin" : "Féminin";
                pbPompier.Image = Image.FromFile(sexe == "m"
                    ? @"..\..\Resources\Profiles\pompier.png"
                    : @"..\..\Resources\Profiles\pompierF.png");
                
                string gradeCode = reader["codeGrade"].ToString();
                pbGrade.Image = Image.FromFile($@"..\..\Resources\ImagesGrades\{gradeCode}.png");
                //pbGrade.Location = new Point(462, (panel3.ClientSize.Height - pbGrade.Height) / 2);
                
                string type = reader["type"].ToString();
                if (type == "p") lblTypePompier.Text = "Pompier";
                if (type != "p") lblTypePompier.Text = "Volontaire";
                chkConge.Checked = reader["enConge"].ToString() == "0" ? false : true;
                string grade =  reader["codeGrade"].ToString();
                // Pour la grade
                string query2 = $@"Select * from Grade where code = '{grade}'";
                cmd = new SQLiteCommand(query2, conn);
                reader = cmd.ExecuteReader();
                if (!reader.Read()) return;
                lblGrade.Text = reader["libelle"].ToString();
                if (isLogged)
                {
                    remplirHabilitations(matricule);
                    remplirCaserneRattachement();
                    remplirPanelGrade();
                }
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

        // Helper method pour remplir habilitations
        private void remplirHabilitations(int matricule)
        {
            try
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
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        // Click Event quand Utilisateur veut ajouter un ou plusieurs nouveau(x) habilitation
        private void pbEditHabilitations_Click(object sender, EventArgs e)
        {
            try
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
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfirmHabilitation_Click(object sender, EventArgs e)
        {
            chklstbHabilitation.Visible = false;
            btnConfirmHabilitation.Visible = false;
            foreach (var item in chklstbHabilitation.CheckedItems)
            {
                lbHabilitations.Items.Add(item);
            }
            pbEditHabilitations.Visible = true ;
        }
        
        // Helper method pour remplir Mettre à jour caserne de rattachement et nouvelle caserne chosiri Combo box
        private void remplirCaserneRattachement()
        {
            try
            {
                lbAffectations.Items.Clear();
                var source = (DataTable)cboCaserne.DataSource;
                cboCaserneRattachement.DataSource = source.Copy();
                cboCaserneRattachement.DisplayMember = "nom";
                cboCaserneRattachement.ValueMember = "id";
                cboCaserneRattachement.SelectedIndex = -1;
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
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur de base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboCaserneRattachement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblRattachement.Text = cboCaserneRattachement.Text;
        }

        // Logique d'authentification de l'administrateur
        private void OpenLoginForm()
        {
            var loginForm = new frmLogin();
            var result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                pnlPlusInfo.Visible = true;
                pnlChoisirGrade.Visible = true;
                lbllnfoCarriere.Visible = true;
                isLogged = true;
                btnPlusInfoCarriere.Visible = false;
                remplirHabilitations(Convert.ToInt32(cboPompier.SelectedValue));
                remplirCaserneRattachement();
                remplirPanelGrade();
                pnlChoisirGrade.Visible = true;
                pnlChoisirCaserne.Visible = true;
                pbChoisirCaserne.Visible = false;
                pbEditGrade.Visible = false;
            }
            else
            {
                MessageBox.Show("Login annulée ou échouée");
            }
        }

        // Helper method pour remplir la grade (si utilisateur veut changer)
        public void remplirPanelGrade()
        {
            try
            {
                string query = "SELECT * FROM Grade";
                var adapter = new SQLiteDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);

                cboGrade.DataSource = dt;
                cboGrade.DisplayMember = "libelle";
                cboGrade.ValueMember = "code";

                cboGrade.SelectedIndex = -1;
               /* if (!string.IsNullOrEmpty(lblGrade.Text))
                {
                    cboGrade.SelectedValue = lblGrade.Text;
                }*/
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
        private void cboGrade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblGrade.Text = cboGrade.Text;
        }
        
        // Event quand utilisateur veut modifier, alors dans ce cas il faut logic d'abord
        private void pbEditGrade_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                OpenLoginForm();
            }
            else
            {
                pnlChoisirGrade.Visible = true;
                pnlChoisirCaserne.Visible = true;
            }

        }

        private void btnPlusInfoCarriere_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                OpenLoginForm();
            }
            else
            {
                pnlChoisirGrade.Visible = true;
                pnlChoisirCaserne.Visible = true;
            }
        }

        // Event pour mettre à jour utilisateur
        private void btnMettreJour_Click(object sender, EventArgs e)
        {
            SQLiteTransaction maTransac = conn.BeginTransaction();
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = conn,
                Transaction = maTransac
            };
            try
            {
                bool caserneChanger = false;
                int matricule = Convert.ToInt32(cboPompier.SelectedValue);
                int oldCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
                string newGrade = cboGrade.SelectedValue?.ToString() ?? "";
                int newCaserne = cboCaserneRattachement.SelectedValue != null
                        ? Convert.ToInt32(cboCaserneRattachement.SelectedValue.ToString())
                         : -1;
                int enConge = chkConge.Checked == true ? 1 : 0;
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
                        caserneChanger = true;
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
                remplirHabilitations(matricule);
                remplirCaserneRattachement();
                remplirPanelGrade();
                pnlChoisirGrade.Visible = false;
                pnlChoisirCaserne.Visible = false;
                for (int i = 0; i < chklstbHabilitation.Items.Count; i++)
                {
                    chklstbHabilitation.SetItemChecked(i, false);
                }
                if (caserneChanger)
                {
                    cboCaserne.SelectedIndex = newCaserne - 1;
                    cboCaserne_SelectionChangeCommitted(cboCaserne, EventArgs.Empty);
                    cboPompier.SelectedIndex = cboPompier.Items.Count - 1;
                    cboPompier_SelectionChangeCommitted(cboPompier, EventArgs.Empty);
                }
            }
            catch(Exception ex)
            {
                // annulation de la transaction
                maTransac.Rollback();
                MessageBox.Show("Transaction annulée !\n\nErreur : " + ex.Message +
                   "\n\nDétails : " + ex.StackTrace);
            }

        }

        private void pbChoisirCaserne_Click(object sender, EventArgs e)
        {
            pnlChoisirCaserne.Visible = true;
        }

        // Ajoute nouveau pompier
        private void btnAjoutPompier_Click(object sender, EventArgs e)
        {
            // on instancie un formulaire enfant
            frmAjoutePompier fe = new frmAjoutePompier();
            
            // on affiche le formulaire
            DialogResult dr = fe.ShowDialog();

            // On attend la réponse
            if (dr == DialogResult.OK)
            {
                // faire quelquechose 
            }
            else MessageBox.Show("Opération annulée", "Erreur");    
        }

       
    }

    // Class pour faciliter travaile avec Combo box
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
