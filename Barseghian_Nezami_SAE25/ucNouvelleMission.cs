using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Barseghian_Nezami_SAE25.Utils;
using System.Reflection;
using System.Data.SqlClient;

namespace Barseghian_Nezami_SAE25
{
    public partial class ucNouvelleMission : UserControl
    {
        private List<VehiculeNecessaire> listVehicule = new List<VehiculeNecessaire>();
        private List<(int Matricule, int Habilitation, string CodeTypeEngin)> pompiersAffectes = new List<(int, int, string)>();

        private DataSet dsLocal = MesDatas.DsGlobal;
        public ucNouvelleMission()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            cboCaserne.DataSource = dsLocal.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // 1. Met à jour la date et le numero de la mission 
            EnteteAJour();
            // 2. Charger les types de sinistre depuis le DataSet
            DataTable tableSinistre = dsLocal.Tables["NatureSinistre"];
            cboNatureSinistre.DataSource = tableSinistre;
            cboNatureSinistre.DisplayMember = "libelle";
            cboNatureSinistre.SelectedIndex = -1;

            // 3. Charger les casernes depuis le DataSet
            DataTable tableCaserne = dsLocal.Tables["Caserne"];
            cboCaserne.DataSource = tableCaserne;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.SelectedIndex = -1;

        }

        public void EnteteAJour()
        {
            lblDeclenche.Text = "déclenchée le : " + DateTime.Now;
            DataTable dtMission = dsLocal.Tables["Mission"];
            // 1. Récupérer le dernier id de mission

            long numMission = 0;
            foreach (DataRow row in dtMission.Rows)
            {
                long id = (long)row["id"];
                if (id > numMission)
                    numMission = id;
            }
            lblMission.Text = "Mission n° " + (numMission + 1).ToString();
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            rtbMotif.Text = "";
            rtbCP.Text = "";
            rtbRue.Text = "";
            rtbVille.Text = "";
            cboCaserne.SelectedIndex = -1;
            cboNatureSinistre.SelectedIndex = -1;
            pnlEnginPompier.Visible = false;
        }


        private void rtbRue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '\'' || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '/' || e.KeyChar == '&' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
        }

        private void rtbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void rtbVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            //on commence par tout refuser !!
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '\'')
            {
                e.Handled = false;
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            // 0. Error Provider

            bool hasError = false;
            epNouvelleMission.Clear(); // Nettoie les erreurs précédentes

            if (string.IsNullOrWhiteSpace(rtbMotif.Text))
            {
                epNouvelleMission.SetError(rtbMotif, "Veuillez saisir un motif.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(rtbRue.Text))
            {
                epNouvelleMission.SetError(rtbRue, "Veuillez saisir une adresse.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(rtbCP.Text))
            {
                epNouvelleMission.SetError(rtbCP, "Veuillez saisir un code postal.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(rtbVille.Text))
            {
                epNouvelleMission.SetError(rtbVille, "Veuillez saisir une ville.");
                hasError = true;
            }
            if (rtbCP.Text.Length < 5)
            {
                epNouvelleMission.SetError(rtbCP, "Un code postal contient 5 chiffres.");
                hasError = true;
            }

            if (hasError)
            {
                return; // Stoppe l'exécution si un champ est vide
            }
            try
            {
                int idMission = int.Parse(lblMission.Text.Substring(10));

                RemplirPartirAvec(listVehicule, int.Parse(lblMission.Text.Substring(10)));
                MettreEnMissionEngin(listVehicule);

                RemplirMobiliser(pompiersAffectes, int.Parse(lblMission.Text.Substring(10)));
                MettreEnMissionPompier(pompiersAffectes);

                // Ajouter ligne mission
                DataRow drMission = dsLocal.Tables["Mission"].NewRow();
                drMission["id"] = idMission;
                drMission["dateHeureDepart"] = lblDeclenche.Text.Substring(15);
                drMission["motifAppel"] = rtbMotif.Text;
                drMission["adresse"] = rtbRue.Text;
                drMission["ville"] = rtbVille.Text;
                drMission["cp"] = rtbCP.Text;
                drMission["terminee"] = "0";
                drMission["idNatureSinistre"] = getIdSinistreFromLibelle();
                drMission["idCaserne"] = cboCaserne.SelectedIndex + 1;

                dsLocal.Tables["Mission"].Rows.Add(drMission);

                MessageBox.Show("Mission créée.");

                rtbMotif.Text = "";
                rtbCP.Text = "";
                rtbRue.Text = "";
                rtbVille.Text = "";
                cboCaserne.SelectedIndex = -1;
                cboNatureSinistre.SelectedIndex = -1;
                pnlEnginPompier.Visible = false;
                EnteteAJour();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur création mission : " + ex.Message);
            }
        }

        public int getIdSinistreFromLibelle()
        {
            DataTable dtNatureSinistre = dsLocal.Tables["NatureSinistre"];

            DataRow[] result = dtNatureSinistre.Select($"libelle = '{cboNatureSinistre.Text.Replace("'", "''")}'");

            if (result.Length == 1)
            {
                return Convert.ToInt32(result[0]["id"]);
            }
            else
            {
                MessageBox.Show("Sinistre non séléctionné, introuvable ou en double");
                return -1;
            }

        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            // 0. Error Provider

            bool hasError = false;
            epNouvelleMission.Clear(); // Nettoie les erreurs précédentes

            if (cboCaserne.SelectedIndex==-1)
            {
                epNouvelleMission.SetError(cboCaserne, "Veuillez attribuer la mission à une caserne.");
                hasError = true;
            }

            if (cboNatureSinistre.SelectedIndex == -1)
            {
                epNouvelleMission.SetError(cboNatureSinistre, "Veuillez indiquer la nature du sinistre");
                hasError = true;
            }
            if (hasError)
            {
                return; // Stoppe l'exécution si un champ est vide
            }


            // 1. Trouver l'id du sinistre
            int numeroSinistre = getIdSinistreFromLibelle();

            if (numeroSinistre != -1)
            {
                string numSinistre = numeroSinistre.ToString();
                // 2. Récupérer les véhicules nécessaires
                DataTable dtNecessiter = dsLocal.Tables["Necessiter"];
                List<VehiculeNecessaire> listVehiculeNecessaire = new List<VehiculeNecessaire>();

                foreach (DataRow row in dtNecessiter.Rows)
                {
                    if (Convert.ToInt32(row["idNatureSinistre"]) == Convert.ToInt32(numSinistre))
                    {
                        listVehiculeNecessaire.Add(new VehiculeNecessaire
                        {
                            CodeTypeEngin = row["codeTypeEngin"].ToString(),
                            Numero = Convert.ToInt32(row["nombre"]),
                            IdCaserne = cboCaserne.SelectedIndex + 1

                        });
                    }
                }

                // 3. Trouver les engins disponibles et les habilitations nécessaires
                DataTable dtEngin = dsLocal.Tables["Engin"];
                DataTable dtEmbarquer = dsLocal.Tables["Embarquer"];

                List<int> listHabilitations = new List<int>();
                int idCaserne = cboCaserne.SelectedIndex + 1;

                foreach (VehiculeNecessaire vehicule in listVehiculeNecessaire)
                {
                    int compteur = 0;
                    string codeType = vehicule.CodeTypeEngin;

                    foreach (DataRow row in dtEngin.Rows)
                    {
                        if (row["codeTypeEngin"].ToString() == codeType &&
                            Convert.ToInt32(row["idCaserne"]) == idCaserne &&
                            Convert.ToInt32(row["enMission"]) == 0 &&
                            Convert.ToInt32(row["enPanne"]) == 0)
                        {
                            VehiculeNecessaire engin = new VehiculeNecessaire
                            {
                                CodeTypeEngin = codeType,
                                Numero = Convert.ToInt32(row["numero"]),
                                IdCaserne = idCaserne
                            };
                            listVehicule.Add(engin);
                            compteur++;

                            if (compteur >= vehicule.Numero)
                            {
                                break;
                            }
                        }
                    }

                    // Vérifie si assez d'engins ont été trouvés
                    if (compteur < vehicule.Numero)
                    {
                        MessageBox.Show($"Il manque {vehicule.Numero - compteur} engin(s) de type {codeType} dans la caserne sélectionnée.\nMission annulée.");
                        return;
                    }
                

                    // 2) Récupérer les habilitations nécessaires depuis Embarquer
                    foreach (DataRow row in dtEmbarquer.Rows)
                        {
                            if (row["codeTypeEngin"].ToString() == vehicule.CodeTypeEngin)
                            {
                                int idHabilitation = Convert.ToInt32(row["idHabilitation"]);
                                int nombre = Convert.ToInt32(row["nombre"]);

                                for (int i = 0; i < nombre; i++)
                                {
                                    listHabilitations.Add(idHabilitation);
                                }
                            }
                        }
                }

                // 4. Affichage des engins dans le FlowLayoutPanel
                flpVehicules.Controls.Clear();
                foreach (VehiculeNecessaire vehicule in listVehicule)
                {
                    ucAffichageEnginPompier item1 = new ucAffichageEnginPompier();
                    item1.SetDataEngin(vehicule.CodeTypeEngin, vehicule.Numero);
                    flpVehicules.Controls.Add(item1);
                }

                // 5. Trouver les pompiers disponibles
                DataTable dtPompier = dsLocal.Tables["Pompier"];
                DataTable dtPasser = dsLocal.Tables["Passer"];
                DataTable dtTypeEngin = dsLocal.Tables["TypeEngin"];
                DataTable dtAffectation = dsLocal.Tables["Affectation"];

                flpPompiers.Controls.Clear();

                // Étape 1 – Affecter les pompiers habilités pour chaque engin
                foreach (VehiculeNecessaire engin in listVehicule)
                {
                    string codeType = engin.CodeTypeEngin;
                    List<int> habilitationsRequises = GetHabilitationsPourEngin(codeType);

                    foreach (int hab in habilitationsRequises)
                    {
                        bool found = false;
                        int matricule = -1;

                        foreach (DataRow rowPasser in dtPasser.Rows)
                        {
                            if (Convert.ToInt32(rowPasser["idHabilitation"]) == hab)
                            {
                                int mat = Convert.ToInt32(rowPasser["matriculePompier"]);

                                foreach (DataRow rowPompier in dtPompier.Rows)
                                {
                                    if (Convert.ToInt32(rowPompier["matricule"]) == mat &&
                                        Convert.ToInt32(rowPompier["enMission"]) == 0 &&
                                        Convert.ToInt32(rowPompier["enConge"]) == 0 &&
                                        PompierEstActifDansCaserne(dtAffectation, mat, idCaserne))
                                    {
                                        matricule = mat;
                                        pompiersAffectes.Add((matricule, hab, codeType));
                                        found = true;
                                        break;
                                    }
                                }

                                if (found)
                                    break;
                            }
                        }

                        if (!found)
                        {
                            MessageBox.Show($"Pas de pompier disponible avec l'habilitation {hab} pour l'engin {codeType}, mission annulée.");
                            pnlEnginPompier.Visible = false;
                            cboCaserne.SelectedIndex = -1;
                            return;
                        }
                    }
                }

                // Étape 2 – Complément si besoin (effectif minimum)
                foreach (VehiculeNecessaire engin in listVehicule)
                {
                    string codeType = engin.CodeTypeEngin;
                    int equipageMin = 0;

                    foreach (DataRow row in dtTypeEngin.Rows)
                    {
                        if (row["code"].ToString() == codeType)
                        {
                            equipageMin = Convert.ToInt32(row["equipage"]);
                            break;
                        }
                    }

                    int actuels = 0;
                    foreach ((int Matricule, int Habilitation, string CodeTypeEngin) p in pompiersAffectes)
                    {
                        if (p.CodeTypeEngin == codeType)
                            actuels++;
                    }

                    int manquants = equipageMin - actuels;
                    while (manquants > 0)
                    {
                        bool found = false;

                        foreach (DataRow rowPompier in dtPompier.Rows)
                        {
                            int mat = Convert.ToInt32(rowPompier["matricule"]);

                            if (Convert.ToInt32(rowPompier["enMission"]) == 0 &&
                                Convert.ToInt32(rowPompier["enConge"]) == 0 &&
                                !MatriculeDejaAffecte(pompiersAffectes, mat))
                            {
                                pompiersAffectes.Add((mat, -1, codeType));
                                found = true;
                                manquants--;
                                break;
                            }
                        }

                        if (!found)
                        {
                            MessageBox.Show($"Attention : l'engin {codeType} est lancé avec un équipage incomplet ({equipageMin - manquants}/{equipageMin}).");
                            break;
                        }
                    }
                }
                // Étape 3 – Affichage
                foreach ((int Matricule, int Habilitation, string CodeTypeEngin) p in pompiersAffectes)
                {
                    int mat = p.Matricule;
                    int hab = p.Habilitation;

                    if (mat != -1)
                    {
                        ucAffichageEnginPompier item = new ucAffichageEnginPompier();
                        item.SetDataPompier(mat, hab);
                        flpPompiers.Controls.Add(item);
                    }
                }

                pnlEnginPompier.Visible = true;

                SynchroniserAjoutsDataset(dsLocal, MesDatas.DsGlobal);
            }
        }

        // Fonction de vérification
        bool MatriculeDejaAffecte(List<(int Matricule, int Habilitation, string CodeTypeEngin)> liste, int mat)
        {
            foreach ((int Matricule, int Habilitation, string CodeTypeEngin) p in liste)
            {
                if (p.Matricule == mat)
                {
                    return true;
                }
            }
            return false;
        }
        bool PompierEstActifDansCaserne(DataTable dtAffecte, int matricule, int idCaserne2)
        {
            foreach (DataRow row in dtAffecte.Rows)
            {
                if (Convert.ToInt32(row["matriculePompier"]) == matricule &&
                    Convert.ToInt32(row["idCaserne"]) == idCaserne2 &&
                    row["dateFin"] == DBNull.Value)
                {
                    return true;
                }
            }
            return false;
        }


        List<int> GetHabilitationsPourEngin(string codeType)
        {
            List<int> result = new List<int>();

            DataTable dtEmbarquer2 = dsLocal.Tables["Embarquer"];

            foreach (DataRow row in dtEmbarquer2.Rows)
            {
                if (row["CodeTypeEngin"].ToString() == codeType)
                {
                    int idHabilitation = Convert.ToInt32(row["IdHabilitation"]);
                    int nombre = Convert.ToInt32(row["nombre"]);

                    for (int i = 0; i < nombre; i++)
                    {
                        result.Add(idHabilitation);
                    }
                }
            }

            return result;
        }

        public void SynchroniserAjoutsDataset(DataSet dsLocal, DataSet dsGlobal)
        {
            foreach (DataTable localTable in dsLocal.Tables)
            {
                string tableName = localTable.TableName;

                if (!dsGlobal.Tables.Contains(tableName))
                {
                    continue;
                }
                DataTable globalTable = dsGlobal.Tables[tableName];

                // Vérifie que la table a une clé primaire
                if (globalTable.PrimaryKey.Length == 0)
                {
                    Console.WriteLine($"Table {tableName} n'a pas de clé primaire. Synchronisation ignorée.");
                    continue;
                }

                foreach (DataRow localRow in localTable.Rows)
                {
                    // Recherche si une ligne avec la même clé existe déjà dans dsGlobal
                    object[] keyValues = globalTable.PrimaryKey
                        .Select(col => localRow[col.ColumnName])
                        .ToArray();

                    DataRow existing = globalTable.Rows.Find(keyValues);

                    if (existing == null)
                    {
                        globalTable.ImportRow(localRow); // Ajoute la ligne à dsGlobal
                    }
                }
            }
        }

        public void RemplirMobiliser(List<(int Matricule, int Habilitation, string CodeTypeEngin)> pompiers, int idMission)
        {
            DataTable tableMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
            foreach ((int Matricule, int Habilitation, string CodeTypeEngin) p in pompiersAffectes)
            {
                DataRow newRow = tableMobiliser.NewRow();
                newRow["matriculePompier"] = p.Matricule;
                newRow["idMission"] = idMission;
                newRow["idHabilitation"] = p.Habilitation;
                tableMobiliser.Rows.Add(newRow);
            }
        }

        public void MettreEnMissionPompier(List<(int Matricule, int Habilitation, string CodeTypeEngin)> pompiers)
        {
            DataTable tablePompier = MesDatas.DsGlobal.Tables["Pompier"];

            foreach ((int Matricule, int Habilitation, string CodeTypeEngin) p in pompiersAffectes)
            {
                DataRow[] rows = tablePompier.Select($"matricule = {p.Matricule}");
                if (rows.Length > 0)
                {
                    rows[0]["enMission"] = 1;
                }
            }
        }

        public void RemplirPartirAvec(List<VehiculeNecessaire> vehicules, int idMission)
        {
            DataTable tablePartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
            foreach (VehiculeNecessaire vehicule in vehicules)
            {
                DataRow newRow = tablePartirAvec.NewRow();
                newRow["idCaserne"] = vehicule.IdCaserne;
                newRow["codeTypeEngin"] = vehicule.CodeTypeEngin;
                newRow["numeroEngin"] = vehicule.Numero;
                newRow["idMission"] = idMission;
                tablePartirAvec.Rows.Add(newRow);
            }
        }

        public void MettreEnMissionEngin(List<VehiculeNecessaire> vehicules)
        {
            DataTable tableEngins = MesDatas.DsGlobal.Tables["Engin"];

            if (tableEngins.PrimaryKey == null || tableEngins.PrimaryKey.Length == 0)
            {
                tableEngins.PrimaryKey = new DataColumn[]
                {
                    tableEngins.Columns["codeTypeEngin"],
                    tableEngins.Columns["numero"],
                    tableEngins.Columns["idCaserne"]
                };
            }

            foreach (VehiculeNecessaire vehicule in vehicules)
            {
                // Utilise la clé composite : codeTypeEngin + numero
                DataRow enginRow = tableEngins.Rows.Find(new object[] {vehicule.CodeTypeEngin, vehicule.Numero, vehicule.IdCaserne });

                if (enginRow != null)
                {
                    enginRow["enMission"] = 1;
                }
            }
        }

        private void cboNatureSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEnginPompier.Visible = false;
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEnginPompier.Visible = false;
        }

        public List<VehiculeNecessaire> getListVehicule()
        {
            return listVehicule;
        }

        public List<(int, int, string)> getPompiersAffectes()
        {
            return pompiersAffectes;
        }
    }
}
