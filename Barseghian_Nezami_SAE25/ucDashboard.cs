using Barseghian_Nezami_SAE25.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Barseghian_Nezami_SAE25
{
    public partial class ucDashboard : UserControl
    {
        private static SQLiteConnection conn = Connexion.Connec;
        public ucDashboard()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            changeHeaderPosition();
            cboFiltre.SelectedIndex = 0;
            LoadDataIntoTable();
        }
        void changeHeaderPosition()
        {
            lblHeader.Location = new Point(
            (this.ClientSize.Width - lblHeader.Width) / 2,
            lblHeader.Location.Y);
        }

        private void pnlHeader_Resize(object sender, EventArgs e)
        {
            changeHeaderPosition();
        }


        private void LoadDataIntoTable()
        {
            DataSet ds = MesDatas.DsGlobal;

            ds.Tables["Mission"].PrimaryKey = new DataColumn[] {
                ds.Tables["Mission"].Columns["id"]
            };

            ds.Tables["Caserne"].PrimaryKey = new DataColumn[] {
                ds.Tables["Caserne"].Columns["id"]
            };

            ds.Tables["NatureSinistre"].PrimaryKey = new DataColumn[] {
                ds.Tables["NatureSinistre"].Columns["id"]
            };

            tlpMissions.Controls.Clear();
            tlpMissions.RowStyles.Clear();
            tlpMissions.ColumnCount = 2;
            tlpMissions.RowCount = 0;

            int col = 0;
            int row = 0;
            int indexFilter = cboFiltre.SelectedIndex;

            DataTable missionTable = MesDatas.DsGlobal.Tables["Mission"];

            for (int i = 0; i < missionTable.Rows.Count; i++)
            {
                DataRow dr = missionTable.Rows[i];
                bool shouldAdd = false;

                if (indexFilter == 0) // Tous
                {
                    shouldAdd = true;
                }
                else if (indexFilter == 1 && dr["terminee"].ToString() == "0") // En cours
                {
                    shouldAdd = true;
                }
                else if (indexFilter == 2 && dr["terminee"].ToString() == "1") // Terminée
                {
                    shouldAdd = true;
                }

                if (!shouldAdd)
                    continue;

                if (col == 0)
                {
                    // Ajouter nouvelle ligne
                    tlpMissions.RowCount += 1;
                    tlpMissions.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                ucMission control = new ucMission(dr);
                control.ClotureClicked += Mission_ClotureClicked;
                control.PdfClicked += Mission_PdfClicked;
                tlpMissions.Controls.Add(control, col, row);

                col++;
                if (col >= 2)
                {
                    col = 0;
                    row++;
                }
            }
        }
        private void cboGrade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadDataIntoTable();
        }

        private void Mission_ClotureClicked(object sender, int idMission)
        {
            string messagePDF;

            // Requête Mission
            string requete1 = "SELECT * FROM Mission";
            SQLiteDataAdapter da1;
            SQLiteCommandBuilder cb1;
            try
            {
                da1 = new SQLiteDataAdapter(requete1, conn);
                cb1 = new SQLiteCommandBuilder(da1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'initialisation de la table Mission : " + ex.Message);
                return;
            }

            DataRow rowMission = MesDatas.DsGlobal.Tables["Mission"].Rows.Find(idMission);
            if (rowMission == null)
            {
                MessageBox.Show("Mission introuvable.");
                return;
            }

            // Vérification que la mission n'est pas déjà terminée
            if (Convert.ToInt32(rowMission["terminee"]) == 0)
            {
                try
                {
                    string requete2 = "SELECT * FROM Mobiliser";
                    SQLiteDataAdapter da2 = new SQLiteDataAdapter(requete2, conn);
                    SQLiteCommandBuilder cb2 = new SQLiteCommandBuilder(da2);
                    da2.Update(MesDatas.DsGlobal, "Mobiliser");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour de la table Mobiliser : " + ex.Message);
                    return;
                }

                try
                {
                    string requete3 = "SELECT * FROM PartirAvec";
                    SQLiteDataAdapter da3 = new SQLiteDataAdapter(requete3, conn);
                    SQLiteCommandBuilder cb3 = new SQLiteCommandBuilder(da3);
                    da3.Update(MesDatas.DsGlobal, "PartirAvec");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour de la table PartirAvec : " + ex.Message);
                    return;
                }

                // Mise à jour de la mission
                rowMission["dateHeureRetour"] = DateTime.Now;
                rowMission["terminee"] = 1;

                try
                {
                    da1.Update(MesDatas.DsGlobal, "Mission");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour de la mission : " + ex.Message);
                    return;
                }

                MessageBox.Show("Mission clôturée.");
            }
            else
            {
                MessageBox.Show("Cette mission est déjà clôturée.");
            }

            try
            {
                string chemin = "rapport_mission" + idMission.ToString() + ".pdf";
                GenerateurPdf.GenererPdfMission(idMission, chemin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du PDF : " + ex.Message);
            }
        }


        private void Mission_PdfClicked(object sender, int idMission)
        {
            try
            {
                string chemin = "rapport_mission" + idMission.ToString() + ".pdf";
                GenerateurPdf.GenererPdfMission(idMission, chemin);
                MessageBox.Show("PDF récapitulatif généré.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du PDF : " + ex.Message);
            }
        }
    }
}
