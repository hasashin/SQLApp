using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
using System.Collections.Generic;

namespace geodezja
{
    public static class Obreb
    {
        public static int id { get; set; }
        public static int parentId { get; set; }
        public static string nazwa { get; set; }
        public static string opis { get; set; }
        public static string parentnazwa { get; set; }

        public static void Fill(int ID, int ParentID, string Nazwa, string Opis)
        {
            id = ID;
            parentId = ParentID;
            nazwa = Nazwa;
            opis = Opis;
        }

        public static new string ToString()
        {
            return id.ToString() + " " + parentId.ToString() + " " + nazwa + " " + opis + " " + parentnazwa;
        }
        public static void Clear()
        {
            id = 0;
            parentId = 0;
            nazwa = "";
            opis = "";
            parentnazwa = "";
        }
    }
    public static class geodezja
    {
        public static string DocumentsAlias = "P.3023";
        public static List<Tuple<int, string>> DocDescs, DocTypes;
        public static void setDescriptions()
        {
            DocDescs = new List<Tuple<int, string>>();
            DocDescs.Add(new Tuple<int, string>(1, "aktualizacja"));
            DocDescs.Add(new Tuple<int, string>(2, "inwentaryzacja"));
            DocDescs.Add(new Tuple<int, string>(3, "rozgraniczenie"));
            DocDescs.Add(new Tuple<int, string>(4, "ustalenie granic"));
            DocDescs.Add(new Tuple<int, string>(5, "podział nieruchomości"));
            DocDescs.Add(new Tuple<int, string>(6, "modernizacja"));
        }
        public static void setTypes()
        {
            DocTypes = new List<Tuple<int, string>>();
            DocTypes.Add(new Tuple<int, string>(1, "szkic polowy/zbiór szkiców polowych"));
            DocTypes.Add(new Tuple<int, string>(2, "wykaz współrzędnych/zbiór wykazów współrzędnych"));
            DocTypes.Add(new Tuple<int, string>(3, "protokół/zbiór protokołów"));
            DocTypes.Add(new Tuple<int, string>(4, "opis topograficzny/zbiór opisów topograficznych"));
            DocTypes.Add(new Tuple<int, string>(5, "sprawozdanie techniczne"));
            DocTypes.Add(new Tuple<int, string>(6, "mapa"));
            DocTypes.Add(new Tuple<int, string>(7, "dziennik pomiarowy (obliczenia)"));
            DocTypes.Add(new Tuple<int, string>(22, "inny (decyzje, postanowienia itp.)"));
        }
        public static string getDescription(int index)
        {
            foreach (Tuple<int, string> t in DocDescs)
            {
                if (t.Item1 == index) return t.Item2;
            }
            return null;
        }
    }
}
