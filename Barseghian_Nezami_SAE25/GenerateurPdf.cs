using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;


namespace Barseghian_Nezami_SAE25
{
    internal class GenerateurPdf
    {
        public static void GenererPdfMission(int idMission, string cheminFichier)
        {
            DataTable missionTable = MesDatas.DsGlobal.Tables["Mission"];
            DataTable natureTable = MesDatas.DsGlobal.Tables["NatureSinistre"];
            DataTable caserneTable = MesDatas.DsGlobal.Tables["Caserne"];

            DataRow mission = missionTable.Rows.Find(idMission);
            if (mission == null)
            {
                throw new ArgumentException("Mission non trouvée");
            }

            string dateDepart = Convert.ToDateTime(mission["dateHeureDepart"]).ToString("dd-MM-yyyy à HH\\hmm");
            string dateRetour = mission["dateHeureRetour"] == DBNull.Value
                ? "En cours"
                : Convert.ToDateTime(mission["dateHeureRetour"]).ToString("dd-MM-yyyy à HH\\hmm");

            string motif = mission["motifAppel"].ToString();
            string adresse = mission["adresse"].ToString() + " " + mission["cp"].ToString()+ " " + mission["ville"].ToString();
            string compteRendu = mission["compteRendu"].ToString();

            int idNature = Convert.ToInt32(mission["idNatureSinistre"]);
            string natureSinistre = natureTable.Rows.Find(idNature)?["libelle"].ToString() ?? "Inconnu";

            int idCaserne = Convert.ToInt32(mission["idCaserne"]);
            string nomCaserne = caserneTable.Rows.Find(idCaserne)?["nom"].ToString() ?? "Inconnue";

            // Création PDF
            PdfDocument document = new PdfDocument();
            PdfPage page1 = document.AddPage();
            page1.Width = XUnit.FromMillimeter(210);
            page1.Height = XUnit.FromMillimeter(297);

            XGraphics gfx = XGraphics.FromPdfPage(page1);
            XFont titreFont = new XFont("Arial", 18, XFontStyle.Bold);
            XFont sectionFont = new XFont("Arial", 16, XFontStyle.Bold);
            XFont textFont = new XFont("Arial", 12, XFontStyle.Regular);
            XFont italicFont = new XFont("Arial", 12, XFontStyle.Italic);
            XFont boldFont = new XFont("Arial", 12, XFontStyle.Bold);

            double y = 40;
            double margin = 40;

            void DrawText(string text, XFont font, ref double yOffset, double indent = 0)
            {
                gfx.DrawString(text, font, XBrushes.Black, new XRect(margin + indent, yOffset, page1.Width - margin * 2, 20), XStringFormats.TopLeft);
                yOffset += 20;
            }

            string cheminLogo = "../../Resources/Logo_couleur.png";
            FileStream fs = File.OpenRead(cheminLogo);
            Func<Stream> streamFactory = new Func<Stream>(() => fs);
            XImage image = XImage.FromStream(streamFactory);

            // Positionnement centré en haut

            // Réduction de moitié
            double originalWidth = image.PixelWidth * 72.0 / image.HorizontalResolution;
            double originalHeight = image.PixelHeight * 72.0 / image.VerticalResolution;

            double width = originalWidth / 2;
            double height = originalHeight / 2;

            // Position en haut à droite (avec un petit décalage de marge)
            double margin2 = 20;
            double xImage = page1.Width - width - margin2;
            double yImage = margin2;

            gfx.DrawImage(image, xImage, yImage, width, height);

            // Libérer les ressources
            image.Dispose();
            fs.Close();
            fs.Dispose();

            DrawText($"Rapport de la mission {idMission}", titreFont, ref y);
            y += 20;
            DrawText($"Déclenchée le {dateDepart}", boldFont, ref y);
            DrawText($"Retour le {dateRetour}", boldFont, ref y);
            y += 10;
            DrawText("--------------------------------------------------------------------", textFont, ref y);
            y += 5;
            DrawText($"Type de sinistre : {natureSinistre}", sectionFont, ref y);
            y += 15;
            DrawText($"Motif : {motif}", boldFont, ref y);
            y += 5;
            DrawText($"Adresse : {adresse}", boldFont, ref y);
            y += 5;
            DrawText($"Compte-rendu : {compteRendu}", boldFont, ref y);
            y += 10;
            DrawText("--------------------------------------------------------------------", textFont, ref y);
            y += 5;
            DrawText($"Caserne : {nomCaserne}", sectionFont, ref y);
            y += 15;
            DataTable partirAvecTable = MesDatas.DsGlobal.Tables["PartirAvec"];
            DataTable typeEnginTable = MesDatas.DsGlobal.Tables["TypeEngin"];
            if (typeEnginTable.PrimaryKey == null || typeEnginTable.PrimaryKey.Length == 0)
            {
                typeEnginTable.PrimaryKey = new DataColumn[] { typeEnginTable.Columns["code"] };

            }
            DrawText("Engins mobilisés :", sectionFont, ref y);
            y += 5;

            foreach (DataRow row in partirAvecTable.Rows)
            {
                if (Convert.ToInt32(row["idMission"]) == idMission)
                {
                    string codeType = row["codeTypeEngin"].ToString();
                    int numero = Convert.ToInt32(row["numeroEngin"]);
                    int idCaserneVehicule = Convert.ToInt32(row["idCaserne"]);
                    string reparations = row["reparationsEventuelles"] == DBNull.Value || string.IsNullOrWhiteSpace(row["reparationsEventuelles"].ToString())
                        ? "pas de réparations prévues"
                        : row["reparationsEventuelles"].ToString();

                    // Chercher le nom du type d'engin
                    string nomType = "Type inconnu";
                    DataRow typeRow = typeEnginTable.Rows.Find(codeType);
                    if (typeRow != null)
                    {
                        nomType = typeRow["nom"].ToString();
                    }

                    string ligne = $"--> {nomType} {idCaserneVehicule}-{codeType}-{numero} ({reparations})";
                    DrawText(ligne, textFont, ref y);
                }
            }
            y += 10;
            DataTable mobiliserTable = MesDatas.DsGlobal.Tables["Mobiliser"];
            DataTable pompierTable = MesDatas.DsGlobal.Tables["Pompier"];
            DataTable gradeTable = MesDatas.DsGlobal.Tables["Grade"];
            DataTable habilitationTable = MesDatas.DsGlobal.Tables["Habilitation"];

            if (gradeTable.PrimaryKey == null || gradeTable.PrimaryKey.Length == 0)
            {
                gradeTable.PrimaryKey = new DataColumn[] { gradeTable.Columns["code"] };

            }
            if (habilitationTable.PrimaryKey == null || habilitationTable.PrimaryKey.Length == 0)
            {
                habilitationTable.PrimaryKey = new DataColumn[] { habilitationTable.Columns["id"] };

            }
            // Espace avant la section
            y += 10;
            DrawText("Pompiers mobilisés :", sectionFont, ref y);
            y += 5;

            // On filtre les lignes Mobiliser liées à la mission
            List<DataRow> lignesMobilisation = new List<DataRow>();

            // Filtrage manuel des lignes correspondant à la mission
            foreach (DataRow row in mobiliserTable.Rows)
            {
                if (Convert.ToInt32(row["idMission"]) == idMission)
                {
                    lignesMobilisation.Add(row);
                }
            }

            // Regroupement manuel par matriculePompier
            Dictionary<int, List<DataRow>> pompiersGroupe = new Dictionary<int, List<DataRow>>();

            foreach (DataRow row in lignesMobilisation)
            {
                int matricule = Convert.ToInt32(row["matriculePompier"]);
                if (!pompiersGroupe.ContainsKey(matricule))
                {
                    pompiersGroupe[matricule] = new List<DataRow>();
                }
                pompiersGroupe[matricule].Add(row);
            }

            foreach (KeyValuePair<int, List<DataRow>> entry in pompiersGroupe)
            {
                int matricule = entry.Key;
                List<DataRow> lignesPompier = entry.Value;

                // On récupère la ligne du pompier
                DataRow pompierRow = null;
                foreach (DataRow row in pompierTable.Rows)
                {
                    if (Convert.ToInt32(row["matricule"]) == matricule)
                    {
                        pompierRow = row;
                        break;
                    }
                }

                if (pompierRow == null)
                    continue;

                string prenom = pompierRow["prenom"].ToString();
                string nom = pompierRow["nom"].ToString();
                string codeGrade = pompierRow["codeGrade"].ToString();

                // Recherche du libellé du grade
                string libelleGrade = "Grade inconnu";
                DataRow gradeRow = gradeTable.Rows.Find(codeGrade);
                if (gradeRow != null)
                {
                    libelleGrade = gradeRow["libelle"].ToString();
                }

                // Récupération des habilitations (sans doublons)
                List<string> libellesHabilitation = new List<string>();
                foreach (DataRow ligne in lignesPompier)
                {
                    int idHab = Convert.ToInt32(ligne["idHabilitation"]);
                    DataRow habRow = habilitationTable.Rows.Find(idHab);
                    if (habRow != null)
                    {
                        string libelleHab = habRow["libelle"].ToString();
                        if (!libellesHabilitation.Contains(libelleHab))
                        {
                            libellesHabilitation.Add(libelleHab);
                        }
                    }
                }

                string ligneFinale = $"--> {libelleGrade} {prenom} {nom} ({string.Join(", ", libellesHabilitation)})";
                DrawText(ligneFinale, textFont, ref y);
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Enregistrer le rapport de mission";
            saveFileDialog.FileName = "rapport_mission_" + idMission + ".pdf";

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cheminFichier2 = saveFileDialog.FileName;
                FileStream outputStream = File.Create(cheminFichier2);
                document.Save(outputStream);
                outputStream.Close();
                outputStream.Dispose();

                MessageBox.Show("PDF généré avec succès !");
            }
            else
            {
                MessageBox.Show("Enregistrement annulé.");
            }

        }
    }
}
