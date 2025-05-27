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
            dashboard db = new dashboard();
            btnTableauBord.BackColor = Color.FromArgb(160, 40, 50);
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
                    buttonn.BackColor = Color.FromArgb(160, 40, 50); 
                }
                else
                {
                    buttonn.BackColor = Color.FromArgb(140, 30, 40);
                }

            }
        }
        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            pnlMainLayout.Controls.Clear();
            dashboard db = new dashboard();
            activeBtnStylying((Button)sender);
            addToPanelLayout(db);
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            pnlMainLayout.Controls.Clear();
            ucNouvelleMission NM = new ucNouvelleMission();
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

        private void pnlMainLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        /***************************************************************************/

        /***************************************************************************/

    }
}
