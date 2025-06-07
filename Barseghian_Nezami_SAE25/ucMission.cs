using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Barseghian_Nezami_SAE25
{
    public partial class ucMission : UserControl
    {
        public ucMission()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            centerLayout();
        }

        public delegate void ClotureClickedEventHandler(object sender, EventArgs e);

        // Déclaration de l'événement
        public event ClotureClickedEventHandler ClotureClicked;

        public ucMission(DataRow dr)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            // natureSinstre et son image
            int natureSinstre = Convert.ToInt32(dr["idNatureSinistre"].ToString());
            string imagePath = $@"..\..\Resources\Nature sinistre\{natureSinstre}.png";

            if (File.Exists(imagePath))
            {
                pbMission.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"Image not found: {imagePath}");
            }
            lblNatureSinstre.Text = MesDatas.DsGlobal.Tables["NatureSinistre"].Rows[natureSinstre - 1]["libelle"].ToString();

            // Numéro de la mission
            lblMission.Text = dr["id"].ToString();

            // Caserne 
            int caserne = Convert.ToInt32(dr["idCaserne"].ToString());
            lblCaserne.Text = MesDatas.DsGlobal.Tables["Caserne"].Rows[caserne - 1]["nom"].ToString();

            // Date de début de la mission
            string rawDate = dr["dateHeureDepart"].ToString(); // Example: "2025-04-03 15:21"

            if (DateTime.TryParse(rawDate, out DateTime parsedDate))
            {
                lblDateDebut.Text = parsedDate.ToString("dd-MM-yyyy");
            }
            else
            {
                lblDateDebut.Text = "Invalid date";
            }

            // Date de Fin de la mission
            string rawDateFin = dr["dateHeureRetour"].ToString(); // Example: "2025-04-03 15:21"

            if (DateTime.TryParse(rawDateFin, out DateTime parsedDate2))
            {
                lblDateFin.Text = parsedDate2.ToString("dd-MM-yyyy");
                lblFinDate.Visible = true;
                lblDateFin.Visible = true;
            }
            else
            {
                lblFinDate.Visible = false;
                lblDateFin.Visible = false;
            }

            // Adresse
            lblAdresse.Text = string.IsNullOrWhiteSpace(dr["adresse"]?.ToString())
                ? "Adresse non renseignée"
                : dr["adresse"].ToString();

            lblCp.Text = string.IsNullOrWhiteSpace(dr["cp"]?.ToString())
                ? "CP non renseigné"
                : dr["cp"].ToString();

            lblVille.Text = string.IsNullOrWhiteSpace(dr["ville"]?.ToString())
                ? "Ville non renseignée"
                : dr["ville"].ToString();

            // Motif d'appel
            lblMotifAppel.Text = string.IsNullOrWhiteSpace(dr["motifAppel"]?.ToString())
                ? "Motif d'appel non précisé"
                : dr["motifAppel"].ToString();

            // Remarques
            lblCompteRendu.Text = string.IsNullOrWhiteSpace(dr["compteRendu"]?.ToString())
                ? "Aucune remarque"
                : dr["compteRendu"].ToString();

            centerLayout();
        }
        void centerLayout()
        {
            pnlLayout.Location = new Point(
            (this.ClientSize.Width - pnlLayout.Width) / 2,
            pnlLayout.Location.Y);
            lblNatureSinstre.Left = (pnlLayout.Width - lblNatureSinstre.Width) / 2;
        }

        private void ucMission_Resize(object sender, EventArgs e)
        {
            centerLayout();
        }

        public delegate void btnCloture_click();

        private void btnCloture_Click(object sender, EventArgs e)
        {
            ClotureClicked?.Invoke(this, e);
        }
    }
}
