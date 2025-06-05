using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Barseghian_Nezami_SAE25
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            changeHeaderPosition();
            cboFiltre.SelectedIndex = 0;
            LoadDataIntoTable();
        }
        void changeHeaderPosition()
        {
            lblHeader.Location = new Point(
            (this.ClientSize.Width - lblHeader.Width) / 2,
            lblHeader.Location.Y);
        }

        private void pnlHeader_Resize(object sender, EventArgs e)
        {
            changeHeaderPosition();
        }


        private void LoadDataIntoTable()
        {
            tlpMissions.Controls.Clear();
            tlpMissions.RowStyles.Clear();
            tlpMissions.ColumnCount = 2;
            tlpMissions.RowCount = 0;

            int col = 0;
            int row = 0;
            int indexFilter = cboFiltre.SelectedIndex;

            DataTable missionTable = MesDatas.DsGlobal.Tables["Mission"];

            for (int i = 0; i < missionTable.Rows.Count; i++)
            {
                DataRow dr = missionTable.Rows[i];
                bool shouldAdd = false;

                if (indexFilter == 0) // Tous
                {
                    shouldAdd = true;
                }
                else if (indexFilter == 1 && dr["terminee"].ToString() == "0") // En cours
                {
                    shouldAdd = true;
                }
                else if (indexFilter == 2 && dr["terminee"].ToString() == "1") // Terminée
                {
                    shouldAdd = true;
                }

                if (!shouldAdd)
                    continue;

                if (col == 0)
                {
                    // Add a new row
                    tlpMissions.RowCount += 1;
                    tlpMissions.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                var control = new ucMission(dr);
                tlpMissions.Controls.Add(control, col, row);

                col++;
                if (col >= 2)
                {
                    col = 0;
                    row++;
                }
            }
        }
        private void cboGrade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadDataIntoTable();
        }
    }
}
