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
            // nazwa | opis | typ
            List<Tuple<string, int, int>> tempList = new List<Tuple<string, int, int>>();
            string rawValue = row["c_value"].ToString().Substring(1);
            string[] fileEntries = rawValue.Split(';');
            foreach (string plik in fileEntries)
            {
                if (plik == "") continue;
                string[] dane = plik.Split(':');
                tempList.Add(new Tuple<string, int, int>(dane[0], int.Parse(dane[1]), int.Parse(dane[2])));
            }
            return tempList;
        }

        private static Tuple<string,int,int> execDialog(Tuple<string,int,int> wrong, Form parent)
        {
            FormDialog dlg = new FormDialog(wrong.Item1 + " " + wrong.Item2 + " " + wrong.Item3);
            DialogResult result = dlg.ShowDialog(parent);
            if (result == DialogResult.OK) return new Tuple<string, int, int>(dlg.GetGoodName(), dlg.GetGoodDesc(), dlg.GetGoodType());
            else if (result == DialogResult.Ignore) return wrong;
            else return null;
        }

        private static bool insertRow(string c_ID, Tuple<string,int,int> doc)
        {
            string docPath = DataManip.DataManip.GenerateDocumentPath();
            string command = "INSERT INTO DocumentTbl VALUES (" + c_ID + ",'" + doc.Item1 + "','" + geodezja.geodezja.getDescription(doc.Item2) + "','" + docPath + doc.Item1 + ".pdf'," + DataManip.DataManip.SłownikIDTypow[doc.Item3] + ",'" + geodezja.geodezja.DocumentsAlias + "',1)";
            return SqlConnect.ExecuteCommand(command);
        }

        public static void WstawPliki(DataTable dt, ProgressBar progressBar1, Form parent)
        {
            StreamWriter log = File.CreateText("raport.log");
            int i = 0;
            if (dt != null)
            {

                List<Tuple<string, int, int>> docs;
                OdbcCommand cmd = new OdbcCommand();
                foreach (DataRow dr in dt.Rows)
                {
                    log.WriteLine("Obiekt " + dr["c_ID"].ToString() + ":");
                    docs = FillList(dr);
                    progressBar1.Value = i / dt.Rows.Count;

                    foreach (Tuple<string, int, int> doc in docs)
                    {
                        log.Write("\tPlik '" + doc.Item1 + "': ");
                        try
                        {
                            if (insertRow(dr["c_ID"].ToString(), doc))
                            {
                                log.WriteLine("Powodzenie. ");

                            }
                            else
                            {
                                log.Write("Niepowodzenie. Druga próba: ");
                                if (insertRow(dr["c_ID"].ToString(), execDialog(doc, parent)))
                                {
                                    log.WriteLine("Powodzenie. ");
                                }
                                else
                                {
                                    log.WriteLine("Niepowodzenie. ");
                                    MessageBox.Show("Nie udało się zapisać pliku '" + doc.Item1 + "' do bazy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(parent, e.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (SqlConnect.ExecuteCommand("DELETE FROM RemarkTbl WHERE c_object_ID =" + dr["c_ID"].ToString()))
                        log.WriteLine("\tUsunięcie pola uwag z obiektu " + dr["c_ID"].ToString() + " powiodło się.");
                    else
                    {
                        log.WriteLine("\tUsunięcie pola uwag z obiektu " + dr["c_ID"].ToString() + " nie powiodło się.");
                        MessageBox.Show("Nie można usunąć danych pola 'Uwagi' z obiektu nr: " + dr["c_ID"].ToString());
                    }

                    i++;
                }
            }
            else
            {
                MessageBox.Show("Tablica danych jest pusta. Wybierz systematykę");
            }
            log.WriteLine("\n\nOperacja wykonana poprawnie.\nZmodyfikowano " + i + " obiektów.");
            MessageBox.Show("Operacja wykonana poprawnie.\nZmodyfikowano " + i + " obiektów.", "Zakończono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            log.Close();
            progressBar1.Value = 0;
        }
    }
}
