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

namespace Barseghian_Nezami_SAE25
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(DataSet ds)
        {
            InitializeComponent();
            cboCaserne.DataSource = ds.Tables["Caserne"];
            cboCaserne.DisplayMember= "nom";
        }

        private void cboNatureSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
