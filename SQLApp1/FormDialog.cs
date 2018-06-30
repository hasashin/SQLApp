using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using SQLConnections;
using System.Data.Odbc;
using System.Data;

namespace SQLApp1
{
    public partial class FormDialog : Form
    {
        public string c_ID;
        public FormDialog()
        {
            InitializeComponent();
        }
        public FormDialog(string WName)
        {
            InitializeComponent();
            WrongDataLabel.Text = WName;
            c_ID = "";
        }
        public string GetGoodName()
        {
            return NameTBox.Text;
        }
        public int GetGoodDesc()
        {
            return int.Parse(CorrectDescCombo.Text.Substring(0,1));
        }
        public int GetGoodType()
        {
            return int.Parse(TypeTBox.Text);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CANCELButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TypeTBox_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(e.ToString(), out a)) return;
        }

        private void IGNOREButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            Close();
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                CorrectDescCombo.Items.Add(i + " " + geodezja.geodezja.getDescription(i));
            }
        }

        private void showFileButton_Click(object sender, EventArgs e)
        {
            DriveInfo[] dyski = DriveInfo.GetDrives();
            string line;
            foreach (DriveInfo dysk in dyski)
            {
                MessageBox.Show(dysk.Name + "Systherm Info\\GEO-INFO Mapa\\System\\Gei-Info.ini");
                if (File.Exists(dysk.Name + "Systherm Info\\GEO-INFO Mapa\\System\\Gei-Info.ini"))
                {
                    StreamReader sr = File.OpenText(dysk.Name + "Systherm Info\\GEO-INFO Mapa\\System\\Gei-Info.ini");
                    line = sr.ReadLine();
                    if (line.Contains("P.3023="))
                    {
                        line = line.Substring(line.IndexOf('=')+1);
                        MessageBox.Show(line);
                        try
                        {
                            Process.Start(line + DataManip.DataManip.GenerateDocumentPath() + WrongDataLabel.Text.Substring(1, WrongDataLabel.Text.IndexOf(":") - 1));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Błąd", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    sr.Close();
                    return;
                }
            }
            MessageBox.Show("Nie można znaleźć danyh aliasu programu Geo-Info.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcDataReader dr =  SqlConnect.ExecuteDataReader("*", "ObjectTbl, G_SZKICE","ObjectTbl.c_ID = G_SZKICE.c_object_ID AND ObjectTbl.c_ID = "+c_ID);
            DataTable table = new DataTable();
            table.Load(dr);
            ObjectDetail objectDetail = new ObjectDetail(table.Rows[0],new System.Drawing.Point(this.Location.X - 352, this.Location.Y));
            objectDetail.Show(this);
            dr.Close();
        }
    }
}
