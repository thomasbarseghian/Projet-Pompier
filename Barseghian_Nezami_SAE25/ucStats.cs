using Barseghian_Nezami_SAE25.Utils;
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

namespace Barseghian_Nezami_SAE25
{
    public partial class ucStats : UserControl
    {
        SQLiteConnection conn = Connexion.Connec;
        public ucStats()
        {
            InitializeComponent();
            chargerCaserne();
            chargerRequetesFixes();
            this.Dock = DockStyle.Fill;
        }
        void changeHeaderPosition()
        {
            lblHeader.Location = new Point(
            (this.ClientSize.Width - lblHeader.Width) / 2,
            lblHeader.Location.Y);
        }
        private void ucStats_Load(object sender, EventArgs e)
        {

        }

        private void chargerCaserne()
        {
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT id, nom FROM Caserne", conn))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboCaserne.DisplayMember = "nom";
                    cboCaserne.ValueMember = "id";
                    cboCaserne.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des casernes : " + ex.Message);
            }
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedValue != null)
            {
                int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
                chargerUtilisationEngins(idCaserne);
                chargerHeuresUtilisation(idCaserne);
            }
        }

        private void chargerUtilisationEngins(int idCaserne)
        {
            string query = @"
    WITH Utilisations AS (
        SELECT pa.codeTypeEngin, pa.numeroEngin, COUNT(*) AS nbUtilisations
        FROM PartirAvec pa
        WHERE pa.idCaserne = @id
        GROUP BY pa.codeTypeEngin, pa.numeroEngin
    ),
    MaxUtilisation AS (
        SELECT MAX(nbUtilisations) AS maxUtil FROM Utilisations
    )
    SELECT te.nom AS typeEngin, u.numeroEngin, u.nbUtilisations
    FROM Utilisations u
    JOIN MaxUtilisation m ON u.nbUtilisations = m.maxUtil
    JOIN TypeEngin te ON u.codeTypeEngin = te.code;";

            afficherDansGrid(DGV1, query, new SQLiteParameter("@id", idCaserne));
        }

        private void chargerHeuresUtilisation(int idCaserne)
        {
            string query = @"
    SELECT p.codeTypeEngin, p.numeroEngin,
        SUM(strftime('%s', m.dateHeureRetour) - strftime('%s', m.dateHeureDepart)) / 3600 AS total_Heure
    FROM PartirAvec p
    JOIN Mission m on p.idCaserne = m.idCaserne
    WHERE m.idCaserne = @id
    GROUP BY p.numeroEngin;";

            afficherDansGrid(DGV2, query, new SQLiteParameter("@id", idCaserne));
        }

        private void afficherDansGrid(DataGridView grid, string query, params SQLiteParameter[] parameters)
        {
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    grid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void chargerRequetesFixes()
        {
            chargerNatureSinistres();
            chargerMaxHabilitations();
            chargerPompierHabilitations();
        }

        private void chargerNatureSinistres()
        {
            string query = "SELECT idNatureSinistre, count(idNatureSinistre) FROM Mission GROUP BY idNatureSinistre;";
            afficherDansGrid(DGV3, query);
        }

        private void chargerMaxHabilitations()
        {
            string query = @"
    WITH HabilitationUsage AS (
        SELECT m.idCaserne, h.id AS idHabilitation, h.libelle, COUNT(*) AS nbUtilisations
        FROM Mobiliser mo
        JOIN Mission m ON mo.idMission = m.id
        JOIN Habilitation h ON mo.idHabilitation = h.id
        GROUP BY m.idCaserne, h.id, h.libelle
    ),
    MaxUsage AS (
        SELECT idCaserne, MAX(nbUtilisations) AS maxUtil
        FROM HabilitationUsage
        GROUP BY idCaserne
    )
    SELECT c.nom AS caserne, hu.libelle AS habilitation, hu.nbUtilisations
    FROM HabilitationUsage hu
    JOIN MaxUsage mu ON hu.idCaserne = mu.idCaserne AND hu.nbUtilisations = mu.maxUtil
    JOIN Caserne c ON hu.idCaserne = c.id
    ORDER BY c.nom;";
            afficherDansGrid(DGV4, query);
        }

        private void chargerPompierHabilitations()
        {
            string query = @"
    SELECT h.libelle AS habilitation, p.matricule, p.nom, p.prenom
    FROM Habilitation h
    LEFT JOIN Passer pa ON h.id = pa.idHabilitation
    LEFT JOIN Pompier p ON pa.matriculePompier = p.matricule
    ORDER BY h.libelle, p.nom, p.prenom;";
            afficherDansGrid(DGV5, query);
        }

        private void pnlHeader_Resize(object sender, EventArgs e)
        {
            changeHeaderPosition();
        }
    }
}
