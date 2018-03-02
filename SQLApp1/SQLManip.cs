using System;
using System.Collections.Generic;
using System.Data;
using SQLConnections;
using System.Data.Odbc;
using System.Windows.Forms;
using SQLApp1;

namespace SQLManip
{
    class SQLManip
    {
        public static void WstawPliki(DataTable dt, ProgressBar progressBar1, Form parent)
        {
            int i = 0;
            if (dt != null)
            {
                string opis;
                List<Tuple<string, int, string>> docs = new List<Tuple<string, int, string>>();
                OdbcCommand cmd = new OdbcCommand();
                foreach (DataRow dr in dt.Rows)
                {
                    progressBar1.Value = i/dt.Rows.Count;
                    opis = dr["c_value"].ToString().Substring(1);
                    string[] pliki = opis.Split(';');
                    docs.Clear();
                    foreach (string plik in pliki)
                    {
                        if (plik == "") continue;
                        string[] dane = plik.Split(':');
                        docs.Add(new Tuple<string, int, string>(dane[0], int.Parse(dane[2]), dane[1]));
                    }
                    foreach (Tuple<string, int, string> doc in docs)
                    {
                        string docPath = DataManip.DataManip.GenerateDocumentPath();
                        string command;
                        if (doc.Item3 == "") command = "INSERT INTO DocumentTbl VALUES (" + dr["c_ID"].ToString() + ",'" + doc.Item1 + "',NULL,'" + docPath + doc.Item1 + ".pdf'," + doc.Item2.ToString() + ",'"+geodezja.geodezja.DocumentsAlias+"',1)";
                        else command = "INSERT INTO DocumentTbl VALUES (" + dr["c_ID"].ToString() + ",'" + doc.Item1 + "'," + doc.Item3 + ",'" + docPath + doc.Item1 + ".pdf'," + doc.Item2.ToString() + ",'"+geodezja.geodezja.DocumentsAlias+"',1)";
                        if (!SqlConnect.ExecuteCommand(command))
                        {
                            FormDialog dlg = new FormDialog(doc.Item1 + " " + doc.Item2 + " " + doc.Item3);
                            DialogResult result = dlg.ShowDialog(parent);
                            if (result == DialogResult.OK)
                            {
                                string Item1 = dlg.GetGoodName();
                                int Item2 = dlg.GetGoodType();
                                string Item3 = dlg.GetGoodDesc();
                                if (Item3 == "") command = "INSERT INTO DocumentTbl VALUES (" + dr["c_ID"].ToString() + ",'" + doc.Item1 + "',NULL,'" + docPath + doc.Item1 + ".pdf'," + doc.Item2.ToString() + ",'"+geodezja.geodezja.DocumentsAlias+"',1)";
                                else command = "INSERT INTO DocumentTbl VALUES (" + dr["c_ID"].ToString() + ",'" + doc.Item1 + "'," + doc.Item3 + ",'" + docPath + doc.Item1 + ".pdf'," + doc.Item2.ToString() + ",'"+geodezja.geodezja.DocumentsAlias+"',1)";
                                if (!SqlConnect.ExecuteCommand(command))
                                {
                                    MessageBox.Show("Nie udało się zapisać pliku do bazy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    continue;
                                }
                            }
                            else if (result == DialogResult.Ignore) continue;
                            else return;
                        }
                    }
                    if (!SqlConnect.ExecuteCommand("DELETE FROM RemarkTbl WHERE c_object_ID =" + dr["c_ID"].ToString()))
                        MessageBox.Show("Nie można usunąć danych pola 'Uwagi' z obiektu nr: " + dr["c_ID"].ToString());
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Tablica danych jest pusta. Wybierz systematykę");
            }
            MessageBox.Show("Operacja wykonana poprawnie.\nZmodufikowano " + i + " obiektów.", "Zakończono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
        }
    }
}
