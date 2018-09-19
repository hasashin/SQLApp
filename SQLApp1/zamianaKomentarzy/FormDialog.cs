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
        public FormDialog(string WName, bool czyString)
        {
            InitializeComponent();
            WrongDataLabel.Text = WName;
            EditStringTBox.Text = WName;
            c_ID = "";
            radioButton2.Enabled = czyString;

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
            return int.Parse(CorrectTypeComboBox.Text.Substring(0,1));
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
            foreach(Tuple<int,string> elem in geodezja.geodezja.DocDescs)
            {
                CorrectDescCombo.Items.Add(elem.Item1 + " " + elem.Item2);
            }
            foreach(Tuple<int,string> elem in geodezja.geodezja.DocTypes)
            {
                CorrectTypeComboBox.Items.Add(elem.Item1 + " " + elem.Item2);
            }
        }

        private void showFileButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            DriveInfo[] dyski = DriveInfo.GetDrives();
            string line;
            foreach (DriveInfo dysk in dyski)
            {
                MessageBox.Show(dysk.Name + "Systherm Info\\GEO-INFO Mapa\\System\\Geo-Info.ini");
                if (File.Exists(dysk.Name + "Systherm Info\\GEO-INFO Mapa\\System\\Geo-Info.ini"))
                {
                    found = true;
                    MessageBox.Show("Exists");
                    StreamReader sr = File.OpenText(dysk.Name + "Systherm Info\\GEO-INFO Mapa\\System\\Gei-Info.ini");
                    line = sr.ReadLine();
                    if (line.Contains("P.3023="))
                    {
                        line = line.Substring(line.IndexOf('=')+1);
                        MessageBox.Show(line);
                        try
                        {
                            Process.Start(line + DataManip.DataManip.GenerateDocumentPath() + WrongDataLabel.Text.Substring(1, WrongDataLabel.Text.IndexOf(":")));
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
            if(!found) MessageBox.Show("Nie można znaleźć danyh aliasu programu Geo-Info.");

        }

        public string getGoodString()
        {
            return EditStringTBox.Text;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                EditStringTBox.Enabled = false;
                CorrectDescCombo.Enabled = true;
                NameTBox.Enabled = true;
                CorrectTypeComboBox.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = true;
                EditStringTBox.Enabled = true;
                CorrectDescCombo.Enabled = false;
                NameTBox.Enabled = false;
                CorrectTypeComboBox.Enabled = false;
            }
        }
    }
}
