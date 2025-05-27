using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barseghian_Nezami_SAE25.Properties;
using Barseghian_Nezami_SAE25.Utils;

namespace Barseghian_Nezami_SAE25
{
    public partial class ucGestionEngins : UserControl
    {
        SQLiteConnection conn = Connexion.Connec;

        private DataSet ds;

        private int pos = 0;
        private DataRow[] enginRows;
        public ucGestionEngins()
        {
            InitializeComponent();
            ds = new DataSet();
            this.Dock = DockStyle.Fill;
            changeHeaderPosition();
            CenterControl(pnlLayout, this);
        }
        private void CenterControl(Control child, Control parent)
        {
            int x = (parent.ClientSize.Width - child.Width) / 2;
            child.Location = new Point(Math.Max(0, x), child.Location.Y);
        }
        void changeHeaderPosition()
        {
            lblHeader.Location = new Point(
            (this.ClientSize.Width - lblHeader.Width) / 2,
            lblHeader.Location.Y);
        }
        private void ucGestionEngins_Load(object sender, EventArgs e)
        {
            try
            {
                string req;
                DataTable schemaTable = conn.GetSchema("Tables");
                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string nomTable = schemaTable.Rows[i][2].ToString();
                    req = @"SELECT * from " + nomTable;
                    SQLiteCommand cmd = new SQLiteCommand(req, conn);
                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(ds, nomTable);
                }
                LoadCboCaserneFromDs();
                if (!ds.Relations.Contains("Caserne_Engins"))
                {
                    ds.Relations.Add("Caserne_Engins",
                        ds.Tables["Caserne"].Columns["id"],
                        ds.Tables["Engin"].Columns["idCaserne"]);
                }
                ds.Tables["Caserne"].PrimaryKey = new DataColumn[] { ds.Tables["Caserne"].Columns["id"] };
              }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des tables : " + ex.Message);
            }
        }
        private void LoadCboCaserneFromDs()
        {
            try
            {
                if (ds.Tables.Contains("Caserne"))
                {
                    DataTable dtCaserne = ds.Tables["Caserne"];

                    cboCaserne.DataSource = dtCaserne;
                    cboCaserne.DisplayMember = "nom";   
                    cboCaserne.ValueMember = "id";      
                    cboCaserne.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("La table 'Caserne' n'existe pas dans le DataSet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du combo: " + ex.Message);
            }
        }

       

        private void pnlHeader_Resize(object sender, EventArgs e)
        {
            changeHeaderPosition();
        }

        private void ucGestionEngins_Resize(object sender, EventArgs e)
        {
            CenterControl(pnlLayout, this);
        }

        private void cboCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedValue == null)
                return;
            pos = 0;
            int selectedCaserneId;
            if (!int.TryParse(cboCaserne.SelectedValue.ToString(), out selectedCaserneId))
                return;
            // Find parent Caserne row
            DataRow caserneRow = ds.Tables["Caserne"].Rows.Find(selectedCaserneId);

            if (caserneRow != null)
            {
                // Get related Engin rows
               enginRows = caserneRow.GetChildRows("Caserne_Engins");

                if (enginRows.Length == 0)
                {
                    MessageBox.Show("Aucun engin pour cette caserne.");
                    return;
                }

                lblEngin.Text = $"Engin 1 sur {enginRows.Length}";
                lblCaserne.Text = caserneRow["nom"].ToString();
                showData(enginRows[pos]);
                pnlLayout.Visible = true;
            }
            else
            {
                MessageBox.Show("Caserne introuvable dans le DataSet.");
            }
        }
        private void showData(DataRow dr)
        {
            string codeType = dr["codeTypeEngin"].ToString();
            lblEngin.Text = $"Engin {pos + 1} sur {enginRows.Length}";
            foreach(DataRow row in ds.Tables["TypeEngin"].Rows)
            {
                if (row["code"].ToString() == codeType)
                    lblType.Text = row["nom"].ToString();
            }
            string imagePath = $@"..\..\Resources\Engins\{ codeType}.jpg";

            if (File.Exists(imagePath))
            {
                pbEngin.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"Image not found: {imagePath}");
            }
            lblCode.Text = cboCaserne.SelectedValue.ToString() + "-" +
               codeType + "-" + dr["numero"].ToString();

            lblReception.Text = dr["dateReception"].ToString();

            int enMission = Convert.ToInt32(dr["enMission"].ToString());
            int enPanne = Convert.ToInt32(dr["enPanne"].ToString());
            string state = enMission == 1 ? "En mission " : enPanne == 1 ? "En Panne" : "Disponible";
            lblState.Text = state;
            string statusPath = "";
            if (enMission == 1)
                statusPath = $@"..\..\Resources\Icons\mission.png";
            else if(enPanne == 1)
                statusPath = $@"..\..\Resources\Icons\panne.png";
            else
                statusPath = $@"..\..\Resources\Icons\Disponible.png";
            if (File.Exists(statusPath))
            {
                pbStatus.Image = Image.FromFile(statusPath);
            }
            else
            {
                MessageBox.Show($"Image not found: {statusPath}");
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < enginRows.Length)
            {
                showData(enginRows[pos]);
            }
            else
            {
                pos = 0;
                showData(enginRows[pos]);

            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pos = pos - 1;
            if (pos > 0)
            {
                showData(enginRows[pos]);
            }
            else
            {
                pos = enginRows.Length - 1;
                showData(enginRows[pos]);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
