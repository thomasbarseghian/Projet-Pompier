using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Barseghian_Nezami_SAE25.Utils;
using System.Windows.Forms;

namespace Barseghian_Nezami_SAE25
{
    public class MesDatas
    {
        private static SQLiteConnection conn = Connexion.Connec;
        private static DataSet dsGlobal = new DataSet();
        private static bool isLoaded = false;

        public static DataSet DsGlobal
        {
            get
            {
                if (!isLoaded)
                    LoadAllTables();
                return dsGlobal;
            }
        }

        private static void LoadAllTables()
        {
            try
            {
                string req;
                DataTable schemaTable = conn.GetSchema("Tables");

                foreach (DataRow row in schemaTable.Rows)
                {
                    string nomTable = row["TABLE_NAME"].ToString();
                    req = $"SELECT * FROM {nomTable}";
                    using (var cmd = new SQLiteCommand(req, conn))
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dsGlobal, nomTable);
                    }
                }

                isLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des tables : " + ex.Message);
            }
        }
    }

}
