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
            // For hover effect to be added on panel and make them work as buttons
            ApplyHoverToPanel(btnTableauBord);
            ApplyHoverToPanel(btnNouvelleMission);
            ApplyHoverToPanel(btnGestionEngins);
            ApplyHoverToPanel(btnGestionPersonnel);
            ApplyHoverToPanel(btnStatistiques);
            ApplyHoverToPanel(btnQuitter);
            Image img = Image.FromFile(@"..\..\Resources\Icons\dashboard.png");
            Image resizedImage = new Bitmap(img, new Size(50, 50)); // Resize to 50x50

            button1.Image = resizedImage;
            button1.ImageAlign = ContentAlignment.MiddleLeft;

            // We want the panel to work as a click for that 
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.FromArgb(140,30,40);
        }
        /***************************************************************************/
        // Hover effect: 
        // Each panel and its children should have 2 events mouse enter and mouse leave  
        private void ApplyHoverToPanel(Panel panel)
        {
            panel.MouseEnter += Panel_MouseEnter;
            panel.MouseLeave += Panel_MouseLeave;

            foreach (Control ctrl in panel.Controls)
            {
                ctrl.MouseEnter += (s, e) => panel.BackColor = Color.FromArgb(160, 40, 50);
                ctrl.MouseLeave += (s, e) => panel.BackColor = Color.FromArgb(140, 30, 40);
            }
        }
        // Mouse Enter 
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(160, 40, 50);
        }
        // Mouse Enter 
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(140, 30, 40);
        }
        /***************************************************************************/
        // Click Functionality
        private void PanelButton_Click(object sender, EventArgs e)
        {
            // Do what you'd normally do on a button click
            MessageBox.Show("Panel clicked!");
        }
        private void AttachClickToPanelAndChildren(Panel panel)
        {
            // Attach click event to panel
            panel.Click += PanelButton_Click;

            // Attach click event to all child controls
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Click += PanelButton_Click;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.Transparent;
        }
        /***************************************************************************/

    }
}
