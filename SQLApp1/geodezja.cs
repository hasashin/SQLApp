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
    }
}
