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

namespace Barseghian_Nezami_SAE25
{
    public partial class ucAffichageEnginPompier : UserControl
    {
        // Données Engin
        public string CodeType { get; private set; }
        public int Numero { get; private set; }

        // Données Pompier
        public string Nom { get; private set; }
        public int Habilitation { get; private set; }

        // Diffencier
        public bool EstEngin { get; private set; }

        public ucAffichageEnginPompier()
        {
            InitializeComponent();
        }


        public void SetDataEngin(string codeType, int numero)
        {
            EstEngin = true;

            CodeType = codeType;
            Numero = numero;

            lbl1.Text = codeType;
            lbl2.Text = numero.ToString();
            Image img = Image.FromFile(@"..\..\Resources\Icons\camionPompierThomas.png");
            Image resizedImage = new Bitmap(img, new Size(50, 30));
            pb1.Image = resizedImage;
            Image img2 = Image.FromFile(@"..\..\Resources\Icons\numero.png");
            Image resizedImage2 = new Bitmap(img2, new Size(28, 28));
            pb2.Image = resizedImage2;
        }

        public void SetDataPompier(string nom, int habilitation)
        {
            EstEngin = false;

            Nom = nom;
            Habilitation = habilitation;
            lbl1.Text = nom;
            lbl2.Text = habilitation.ToString();
            Image img = Image.FromFile(@"..\..\Resources\Icons\matricule.png");
            Image resizedImage = new Bitmap(img, new Size(50, 30));
            pb1.Image = resizedImage;
            Image img2 = Image.FromFile(@"..\..\Resources\Icons\habilitation2.png");
            Image resizedImage2 = new Bitmap(img2, new Size(28, 28));
            pb2.Image = resizedImage2;
        }
    }
}
