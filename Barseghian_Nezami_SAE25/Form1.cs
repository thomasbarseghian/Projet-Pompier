using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Barseghian_Nezami_SAE25
{
    public partial class mainLayout : Form
    {
        public mainLayout()
        {
            InitializeComponent();
        }

        private void mainLayout_Load(object sender, EventArgs e)
        {
            // Button DashBoard
            Image img = Image.FromFile(@"..\..\Resources\Icons\dashboard.png");
            Image resizedImage = new Bitmap(img, new Size(50, 50)); 
            btnTableauBord.Image = resizedImage;

            // Button Nouvelle Mission
            img = Image.FromFile(@"..\..\Resources\Icons\redalert.png");
            resizedImage = new Bitmap(img, new Size(50, 50));
            btnNouvelleMission.Image = resizedImage;

            // Button Gestion Personnel
            img = Image.FromFile(@"..\..\Resources\Icons\firefighter.png");
            resizedImage = new Bitmap(img, new Size(50, 50));
            btnGestionPersonnel.Image = resizedImage;

            // Button Gestion des Engins
            img = Image.FromFile(@"..\..\Resources\Icons\fireTruck.png");
            resizedImage = new Bitmap(img, new Size(50, 50));
            btnGestionEngins.Image = resizedImage;

            // Button Statistiques
            img = Image.FromFile(@"..\..\Resources\Icons\statistics.png");
            resizedImage = new Bitmap(img, new Size(50, 50));
            btnStatistiques.Image = resizedImage;

            // Button Quitter
            img = Image.FromFile(@"..\..\Resources\Icons\logout.png");
            resizedImage = new Bitmap(img, new Size(50, 50));
            btnQuitter.Image = resizedImage;


            pnlMainLayout.Controls.Clear();
            ucDashboard db = new ucDashboard();
            btnTableauBord.BackColor = Color.FromArgb(250, 128, 0);
            addToPanelLayout(db);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addToPanelLayout(UserControl uc)
        {
            pnlMainLayout.Controls.Clear();
          
            pnlMainLayout.Controls.Add(uc);
        }
        private void activeBtnStylying(Button btn)
        {
            foreach(Button buttonn in pnlSideBar.Controls.OfType<Button>())
            {
                if(buttonn == btn)
                {
                    buttonn.BackColor = Color.FromArgb(250, 128, 0); 
                }
                else
                {
                    buttonn.BackColor = Color.FromArgb(243, 156, 18);
                }

            }
        }
        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            pnlMainLayout.Controls.Clear();
            ucDashboard db = new ucDashboard();
            activeBtnStylying((Button)sender);
            addToPanelLayout(db);
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            pnlMainLayout.Controls.Clear();
            DataTable dtMissions = new DataTable("MissionsTemp");
            dtMissions.Columns.Add("id", typeof(int));
            dtMissions.Columns.Add("date", typeof(DateTime));
            dtMissions.Columns.Add("motif", typeof(string));
            dtMissions.Columns.Add("rue", typeof(string));
            dtMissions.Columns.Add("ville", typeof(string));
            dtMissions.Columns.Add("codePostal", typeof(string));
            dtMissions.Columns.Add("idNatureSinistre", typeof(int));
            dtMissions.Columns.Add("idCaserne", typeof(int));

            DataTable dtEngins = new DataTable("EnginsTemp");
            dtEngins.Columns.Add("idMission", typeof(int));
            dtEngins.Columns.Add("numero", typeof(int));

            DataTable dtPompiers = new DataTable("PompiersTemp");
            dtPompiers.Columns.Add("idMission", typeof(int));
            dtPompiers.Columns.Add("matriculePompier", typeof(int));

            DataSet dsLocal = new DataSet();
            dsLocal.Tables.Add(dtMissions);
            dsLocal.Tables.Add(dtEngins);
            dsLocal.Tables.Add(dtPompiers);
            ucNouvelleMission NM = new ucNouvelleMission(dsLocal);
            activeBtnStylying((Button)sender);
            addToPanelLayout(NM);
        }

        private void btnGestionEngins_Click(object sender, EventArgs e)
        {
            pnlMainLayout.Controls.Clear();
            ucGestionEngins GE = new ucGestionEngins();
            activeBtnStylying((Button)sender);
            addToPanelLayout(GE);
        }

        private void btnGestionPersonnel_Click(object sender, EventArgs e)
        {
            pnlMainLayout.Controls.Clear();
            ucRessourceHumain RH = new ucRessourceHumain();
            activeBtnStylying((Button)sender);
            addToPanelLayout(RH);
        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            pnlMainLayout.Controls.Clear();
            activeBtnStylying((Button)sender);
        }


        /***************************************************************************/

        /***************************************************************************/

    }
}
