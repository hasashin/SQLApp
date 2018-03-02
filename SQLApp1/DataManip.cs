using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections.Generic;
using SQLConnections;
using geodezja;

namespace DataManip
{
    public static class DataManip
    {
        private static List<int> ListaIDArkuszy = new List<int>();
        public static string GenerateSearchIDs()
        {
            string str = "";
            str += Obreb.id.ToString();
            foreach (int item in ListaIDArkuszy) str += ", " + item.ToString();
            return str;
        }
        public static DataTable FillDataTable(int ObrebID, int cCodeID)
        {
            string IDs = GenerateSearchIDs();
            OdbcDataReader rd = SqlConnect.ExecuteDataReader("ObjectTbl.c_ID, RemarkTbl.c_value", "ObjectTbl, RemarkTbl", "ObjectTbl.c_ID = RemarkTbl.c_object_ID AND ObjectTbl.c_code_ID = " + cCodeID + " AND ObjectTbl.c_syst_ID IN (" + IDs + ") AND RemarkTbl.c_value LIKE '#%'");
            DataTable dt = new DataTable();
            dt.Load(rd);
            return dt;
        }

        public static void FillPowiatSelectCombo(ComboBox PowiatSelectCombo)
        {
            if (PowiatSelectCombo.Items.Count < 1)
            {
                OdbcDataReader rd1 = SqlConnect.ExecuteDataReader("c_ID", "SystematicsTbl", "c_name LIKE '30'");
                rd1.Read();
                string test = rd1["c_ID"].ToString();
                rd1.Close();
                OdbcDataReader rd = SqlConnect.ExecuteDataReader("c_ID,c_name,c_description", "SystematicsTbl", "c_parent_ID = " + test);

                if (rd.HasRows)
                {
                    string name;
                    while (rd.Read())
                    {
                        name = rd["c_name"].ToString() + " - " + rd["c_description"].ToString();
                        PowiatSelectCombo.Items.Add(name);
                    }
                }
                rd.Close();
                PowiatSelectCombo.SelectedIndex = 0;
            }
        }
        public static void FillJESelectCombo(string PowiatText, ComboBox JEwidencyjnaSelectCombo)
        {
            if (JEwidencyjnaSelectCombo.Items.Count < 1)
            {
                OdbcDataReader rd = SqlConnect.ExecuteDataReader("SystematicsTbl.c_ID,c_parent_ID,c_name,c_description", "SystematicsTbl, (SELECT c_ID FROM SystematicsTbl WHERE c_name LIKE '" + PowiatText + "') AS querry", "SystematicsTbl.c_parent_ID = querry.c_ID ORDER BY c_name;");
                if (rd.HasRows)
                {
                    string name;
                    while (rd.Read())
                    {
                        name = rd["c_name"].ToString() + " - " + rd["c_description"].ToString();
                        JEwidencyjnaSelectCombo.Items.Add(name);
                    }
                }
                rd.Close();
            }
        }

        public static void FillObrebSelectCombo(string JEwidencyjnaText, ComboBox ObrebSelectCombo)
        {
            if (ObrebSelectCombo.Items.Count < 1)
            {
                OdbcDataReader rd = SqlConnect.ExecuteDataReader("SystematicsTbl.c_ID,c_parent_ID,c_name,c_description", "SystematicsTbl, (SELECT c_ID FROM SystematicsTbl WHERE c_name LIKE '" + JEwidencyjnaText + "') AS querry", "SystematicsTbl.c_parent_ID = querry.c_ID ORDER BY c_name;");
                if (rd.HasRows)
                {
                    string name;
                    while (rd.Read())
                    {
                        name = rd["c_name"].ToString() + " - " + rd["c_description"].ToString();
                        ObrebSelectCombo.Items.Add(name);
                    }
                }
                rd.Close();
            }
        }
        public static string GenerateDocumentPath()
        {
            return Obreb.parentnazwa+"\\";
        }
        public static void WyszukajArkusze()
        {
            ListaIDArkuszy.Clear();
            OdbcDataReader rd = SqlConnect.ExecuteDataReader("c_ID", "SystematicsTbl", "c_parent_ID = " + Obreb.id);
            while (rd.Read())
            {
                ListaIDArkuszy.Add(int.Parse(rd["c_ID"].ToString()));
            }
            rd.Close();
        }
    }
}