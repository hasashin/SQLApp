using System;
using System.Collections.Generic;
using System.Data;
using SQLConnections;
using System.Data.Odbc;
using System.Windows.Forms;
using SQLApp1;
using System.IO;

namespace SQLManip
{
    class SQLManip
    {
        private static List<Tuple<string, int, int>> FillList(DataRow row)
        {
            // nazwa | typ | opis
            List<Tuple<string, int, int>> tempList = new List<Tuple<string, int, int>>();
            string rawValue = row["c_value"].ToString().Substring(1);
            string[] fileEntries = rawValue.Split(';');
            foreach (string plik in fileEntries)
            {
                if (plik == "") continue;
                string[] dane = plik.Split(':');
                if(dane.Length != 3)
                {
                    List<Tuple<string, int, int>> newelems = execDialog(plik, row["c_ID"].ToString());
                    tempList.AddRange(newelems);
                }
                else
                    tempList.Add(new Tuple<string, int, int>(dane[0], int.Parse(dane[2]), int.Parse(dane[1])));
            }
            return tempList;
        }

        private static List<Tuple<string,int,int>> execDialog(Tuple<string,int,int> wrong, Form parent)
        {
            FormDialog dlg = new FormDialog(wrong.Item1 + " " + wrong.Item2 + " " + wrong.Item3 , false);
            DialogResult result = dlg.ShowDialog(parent);
            List<Tuple<string, int, int>> list = new List<Tuple<string, int, int>>();
            if (dlg.radioButton1.Checked)
            {
                if (result == DialogResult.OK)
                {
                    list.Add(new Tuple<string, int, int>(dlg.GetGoodName(), dlg.GetGoodType(), dlg.GetGoodDesc()));
                    return list;
                }
                else if (result == DialogResult.Cancel) throw new Exception("Przerwano przez użytkownika.");
                else return null;
            }
            else if (dlg.radioButton2.Checked)
            {
                if (result == DialogResult.OK)
                {
                    string s = dlg.getGoodString();
                    string[] sarr = s.Split(';');
                    foreach (string elem in sarr)
                    {
                        string[] elemArr = elem.Split(':');
                        list.Add(new Tuple<string, int, int>(elemArr[0], int.Parse(elemArr[2]), int.Parse(elemArr[1])));
                    }
                    return list;
                }
                else if (result == DialogResult.Cancel) throw new Exception("Przerwano przez użytkownika.");
                else return null;
            }
            else return null;
        }
        private static List<Tuple<string, int, int>> execDialog(string wrong, string c_object_ID)
        {
            FormDialog dlg = new FormDialog(wrong,true);
            dlg.c_ID = c_object_ID;
            DialogResult result = dlg.ShowDialog(null);
            List<Tuple<string, int, int>> list = new List<Tuple<string, int, int>>();
            if (dlg.radioButton1.Checked)
            {
                if (result == DialogResult.OK)
                {
                    list.Add(new Tuple<string, int, int>(dlg.GetGoodName(), dlg.GetGoodType(), dlg.GetGoodDesc()));
                    return list;
                }
                else if (result == DialogResult.Cancel) throw new Exception("Przerwano przez użytkownika.");
                else return null;
            }
            else if(dlg.radioButton2.Checked)
            {
                if (result == DialogResult.OK)
                {
                    string s = dlg.getGoodString();
                    string[] sarr = s.Split(';');
                    foreach(string elem in sarr)
                    {
                        string[] elemArr = elem.Split(':');
                        list.Add(new Tuple<string, int, int>(elemArr[0],int.Parse(elemArr[2]),int.Parse(elemArr[1])));
                    }
                    return list;
                }
                else if (result == DialogResult.Cancel) throw new Exception("Przerwano przez użytkownika.");
                else return null;
            }
            return null;
        }

        private static bool insertRow(string c_ID, Tuple<string,int,int> doc, bool reverse)
        {
            string docPath = DataManip.DataManip.GenerateDocumentPath();
            string command = "INSERT INTO DocumentTbl VALUES (" + c_ID + ",'" + doc.Item1 + "','" + geodezja.geodezja.getDescription(doc.Item2) + "','" + docPath + doc.Item1 + ".pdf'," + DataManip.DataManip.SłownikIDTypow[doc.Item3] + ",'" + geodezja.geodezja.DocumentsAlias + "',1)";
            if(reverse) command = "INSERT INTO DocumentTbl VALUES (" + c_ID + ",'" + doc.Item1 + "','" + geodezja.geodezja.getDescription(doc.Item3) + "','" + docPath + doc.Item1 + ".pdf'," + DataManip.DataManip.SłownikIDTypow[doc.Item2] + ",'" + geodezja.geodezja.DocumentsAlias + "',1)";
            return SqlConnect.ExecuteCommand(command);
        }

        private static bool insertRow(string c_ID, List<Tuple<string, int, int>> docs,bool reverse)
        {
            bool ret = true;
            foreach (Tuple<string, int, int> doc in docs)
            {
                string docPath = DataManip.DataManip.GenerateDocumentPath();
                string command = "INSERT INTO DocumentTbl VALUES (" + c_ID + ",'" + doc.Item1 + "','" + geodezja.geodezja.getDescription(doc.Item2) + "','" + docPath + doc.Item1 + ".pdf'," + DataManip.DataManip.SłownikIDTypow[doc.Item3] + ",'" + geodezja.geodezja.DocumentsAlias + "',1)";
                if(reverse) command = "INSERT INTO DocumentTbl VALUES (" + c_ID + ",'" + doc.Item1 + "','" + geodezja.geodezja.getDescription(doc.Item3) + "','" + docPath + doc.Item1 + ".pdf'," + DataManip.DataManip.SłownikIDTypow[doc.Item2] + ",'" + geodezja.geodezja.DocumentsAlias + "',1)";
                ret = ret && SqlConnect.ExecuteCommand(command);
            }
            return ret;
        }

        public static void WstawPliki(DataTable dt, ProgressBar progressBar1, Form parent, bool reverse)
        {
            int i = 0;
            int rows = dt.Rows.Count;
            if (dt != null)
            {

                List<Tuple<string, int, int>> docs;
                OdbcCommand cmd = new OdbcCommand();
                foreach (DataRow dr in dt.Rows)
                {
                    docs = FillList(dr);
                    if(i<=rows) progressBar1.Value = i;

                    foreach (Tuple<string, int, int> doc in docs)
                    {
                        try
                        {
                            if (!insertRow(dr["c_ID"].ToString(), doc,reverse))
                            {
                                if (!insertRow(dr["c_ID"].ToString(), execDialog(doc, parent),reverse))
                                {
                                    MessageBox.Show("Nie udało się zapisać pliku '" + doc.Item1 + "' do bazy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(parent, e.Message + "\n"+ e.Source + "\n" + e.TargetSite, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            progressBar1.Value = 0;
                        }
                    }
                    if (!SqlConnect.ExecuteCommand("DELETE FROM RemarkTbl WHERE c_object_ID =" + dr["c_ID"].ToString()))
                    {
                        MessageBox.Show("Nie można usunąć danych pola 'Uwagi' z obiektu nr: " + dr["c_ID"].ToString());
                    }

                    i++;
                }
            }
            else
            {
                MessageBox.Show("Tablica danych jest pusta. Wybierz systematykę");
            }
            MessageBox.Show("Operacja wykonana poprawnie.\nZmodyfikowano " + i + " obiektów.", "Zakończono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
        }
    }
}
