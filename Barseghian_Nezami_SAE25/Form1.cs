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
        }
        /***************************************************************************/
      
        /***************************************************************************/

    }
}
