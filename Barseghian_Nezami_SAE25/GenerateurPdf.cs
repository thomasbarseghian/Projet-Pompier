using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.Data;
using System.IO;

namespace Barseghian_Nezami_SAE25
{
    internal class GenerateurPdf
    {
        public static void GenererPdfMission(int idMission, string cheminFichier)
        {
            var missionTable = MesDatas.DsGlobal.Tables["Mission"];
            var natureTable = MesDatas.DsGlobal.Tables["NatureSinistre"];
            var caserneTable = MesDatas.DsGlobal.Tables["Caserne"];

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
            var mobiliserTable = MesDatas.DsGlobal.Tables["Mobiliser"];
            var pompierTable = MesDatas.DsGlobal.Tables["Pompier"];
            var gradeTable = MesDatas.DsGlobal.Tables["Grade"];
            var habilitationTable = MesDatas.DsGlobal.Tables["Habilitation"];

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
            var lignesMobilisation = mobiliserTable.Rows
                .Cast<DataRow>()
                .Where(r => Convert.ToInt32(r["idMission"]) == idMission);

            var pompiersGroupe = lignesMobilisation
                .GroupBy(r => Convert.ToInt32(r["matriculePompier"])); // Regroupe par pompier

            foreach (var groupe in pompiersGroupe)
            {
                int matricule = groupe.Key;

                // On récupère la ligne Pompier
                DataRow pompierRow = pompierTable.Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r["matricule"]) == matricule);

                if (pompierRow == null)
                    continue;

                string prenom = pompierRow["prenom"].ToString();
                string nom = pompierRow["nom"].ToString();
                string codeGrade = pompierRow["codeGrade"].ToString();

                // On cherche le libellé du grade
                string libelleGrade = "Grade inconnu";
                DataRow gradeRow = gradeTable.Rows.Find(codeGrade);
                if (gradeRow != null)
                    libelleGrade = gradeRow["libelle"].ToString();

                // On récupère les habilitations du pompier pour cette mission
                List<string> libellesHabilitation = new List<string>();
                foreach (var ligne in groupe)
                {
                    int idHab = Convert.ToInt32(ligne["idHabilitation"]);
                    DataRow habRow = habilitationTable.Rows.Find(idHab);
                    if (habRow != null)
                    {
                        string libelleHab = habRow["libelle"].ToString();
                        if (!libellesHabilitation.Contains(libelleHab)) // éviter les doublons
                            libellesHabilitation.Add(libelleHab);
                    }
                }

                string ligneFinale = $"--> {libelleGrade} {prenom} {nom} ({string.Join(", ", libellesHabilitation)})";
                DrawText(ligneFinale, textFont, ref y);
            }


            // Sauvegarde
            using (FileStream stream = new FileStream(cheminFichier, FileMode.Create))
            {
                document.Save(stream);
            }
        }
    }
}
