using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
using System.Collections.Generic;
using SQLConnections;
using geodezja;
using DataManip;
using SQLManip;

namespace SQLApp1
{
    public partial class Form1 : Form
    {
        public int cCodeID=0;
        
        public Form1()
        {
            InitializeComponent();
            StateLabel.Text = "Nie połączono z bazą danych";
        }
        
        private void EnableWork()
        {
            panelRoboczy.Enabled = true;
            DBSelectCombo.Enabled = false;
            SQLPasswdTBox.Enabled = false;
            SQLSrvNameTBox.Enabled = false;
            ConnectButton.Text = "Rozłącz";
        }

        private void DisableWork()
        {
            panelRoboczy.Enabled = false;
            DBSelectCombo.Enabled = true;
            SQLPasswdTBox.Enabled = true;
            SQLSrvNameTBox.Enabled = true;
            ConnectButton.Text = "Połącz";
            ObrebSelectCombo.Items.Clear();
            ObrebSelectCombo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SqlConnect.GetConnectionState() == ConnectionState.Closed)
                try
                {
                    if (SQLSrvNameTBox.Text != "" && SQLPasswdTBox.Text != "" && DBSelectCombo.Text != "")
                    {
                        Cursor = Cursors.WaitCursor;
                        SqlConnect.OpenConnection(SQLSrvNameTBox.Text,DBSelectCombo.Text,SQLPasswdTBox.Text);
                        Cursor = Cursors.Default;
                        if (SqlConnect.GetConnectionState() == ConnectionState.Open)
                        {
                            StateLabel.Text = "Połączono z bazą danych\n" + SQLSrvNameTBox.Text;
                            EnableWork();
                        }
                        if (!Directory.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\SQLChanger")){
                            Directory.CreateDirectory(Environment.GetEnvironmentVariable("TEMP") + "\\SQLChanger");
                        }
                        StreamWriter writer = File.CreateText(Environment.GetEnvironmentVariable("TEMP") + "\\SQLChanger\\data");
                        writer.Write(SQLSrvNameTBox.Text);
                        writer.Close();
                        writer.Dispose();
                        PowiatSelectCombo.Items.Clear();
                        PowiatSelectCombo.Text = "";
                        JEwidencyjnaSelectCombo.Items.Clear();
                        JEwidencyjnaSelectCombo.Text = "";
                        ObrebSelectCombo.Items.Clear();
                        ObrebSelectCombo.Text = "";
                        DataManip.DataManip.FillPowiatSelectCombo(PowiatSelectCombo);
                        OdbcDataReader rd = SqlConnect.ExecuteDataReader("c_ID","ClassTbl","c_name LIKE 'GOSZZG'");
                        rd.Read();
                        cCodeID = int.Parse(rd["c_ID"].ToString());
                        rd.Close();
                        DataManip.DataManip.initDictionaryIDs();
                        
                    }
                    else
                    {
                        MessageBox.Show("Wpisz nazwę serwera, nazwę bazy i hasło do konta (sa)", "Połączenie SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception exept)
                {
                    MessageBox.Show(exept.Message,"Wystąpił błąd");
                }
            else
            {
                SqlConnect.CloseConnection();
                DisableWork();
                StateLabel.Text = "Rozłączono";
                SQLPasswdTBox.Text = "";
            }
            Cursor = Cursors.Arrow;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnect.CloseConnection();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\SQLChanger\\data"))
            {
                StreamReader reader = File.OpenText(Environment.GetEnvironmentVariable("TEMP") + "\\SQLChanger\\data");
                string str = reader.ReadLine();
                SQLSrvNameTBox.Text = str;
                reader.Close();
                reader.Dispose();
            }
            DBSelectCombo.SelectedIndex = 0;
            aliasTextBox.Text = geodezja.geodezja.DocumentsAlias;
            geodezja.geodezja.setDescriptions();
        }

        private void PowiatSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GoButton.Enabled = false;
            JEwidencyjnaSelectCombo.Items.Clear();
            JEwidencyjnaSelectCombo.Text = "";
            DataManip.DataManip.FillJESelectCombo(PowiatSelectCombo.Text.Substring(0,PowiatSelectCombo.Text.IndexOf(' ')),JEwidencyjnaSelectCombo);
            Obreb.Clear();
        }

        private void JEwidencyjnaSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GoButton.Enabled = false;
            ObrebSelectCombo.Items.Clear();
            ObrebSelectCombo.Text = "";
            DataManip.DataManip.FillObrebSelectCombo(JEwidencyjnaSelectCombo.Text.Substring(0, JEwidencyjnaSelectCombo.Text.IndexOf(' ')), ObrebSelectCombo);
            Obreb.Clear();
            string temp = JEwidencyjnaSelectCombo.Text.Remove(0,JEwidencyjnaSelectCombo.Text.IndexOf(' '));
            temp = temp.Remove(0, 3);
            if (temp.Contains("-")) temp = temp.Remove(temp.IndexOf('-') - 1);
            Obreb.parentnazwa = temp;

        }

        

        private void SystematicsSelectButton_Click(object sender, EventArgs e)
        {
            OdbcDataReader rd;
            string IDs = DataManip.DataManip.GenerateSearchIDs();
            if(ObrebSelectCombo.Text != "")
            {
                rd = SqlConnect.ExecuteDataReader("SELECT Count(*) AS c_liczba FROM ObjectTbl, RemarkTbl WHERE ObjectTbl.c_ID = RemarkTbl.c_object_ID AND ObjectTbl.c_code_ID="+cCodeID+" AND ObjectTbl.c_syst_ID IN (" + IDs + ") AND RemarkTbl.c_value LIKE '#%'");
            }
            else
            {
                MessageBox.Show("Wybierz obręb do dodania plików");
                rd = null;
            }
            if (rd != null && rd.HasRows)
            {
                ObjectCountTBox.Text = rd["c_liczba"].ToString();
                progressBar1.Maximum = int.Parse(rd["c_liczba"].ToString());
                rd.Close();
                GoButton.Enabled = true;
            }
            else MessageBox.Show("rd.HasRows == 0 ");
        }
        
        private void GoButton_Click(object sender, EventArgs e)
        {
            PowiatSelectCombo.Enabled = false;
            JEwidencyjnaSelectCombo.Enabled = false;
            ObrebSelectCombo.Enabled = false;
            try
            {
                DataTable dt = DataManip.DataManip.FillDataTable(Obreb.id,cCodeID);
                progressBar1.Maximum = dt.Rows.Count;
                SQLManip.SQLManip.WstawPliki(dt,progressBar1,this,ReverseOrderChkBox.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: "+ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            PowiatSelectCombo.Enabled = true;
            JEwidencyjnaSelectCombo.Enabled = true;
            ObrebSelectCombo.Enabled = true;
            progressBar1.Value = progressBar1.Minimum;
        }

        private void ObrebSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GoButton.Enabled = false;
            string temp = ObrebSelectCombo.Text.Remove(0,ObrebSelectCombo.Text.IndexOf(' '));
            temp = temp.Remove(0, 3);
            OdbcDataReader rd = SqlConnect.ExecuteDataReader("c_ID,c_name,c_description,c_parent_ID", "SystematicsTbl", "c_description LIKE '" + temp +"'");
            rd.Read();
            Obreb.Fill(int.Parse(rd["c_ID"].ToString()), int.Parse(rd["c_parent_ID"].ToString()), rd["c_name"].ToString(), rd["c_description"].ToString());
            rd.Close();
            DataManip.DataManip.WyszukajArkusze();
        }

        private void ReverseOrderChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReverseOrderChkBox.Checked)
            {
                OrderLabel.Text = "Nazwa | Opis | Typ";
            }
            else
            {
                OrderLabel.Text = "Nazwa | Typ | Opis";
            }
        }
    }
}
