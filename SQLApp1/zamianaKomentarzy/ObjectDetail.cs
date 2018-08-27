using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLConnections;

namespace SQLApp1
{
    public partial class ObjectDetail : Form
    {
        public ObjectDetail(DataRow row, Point location)
        {
            InitializeComponent();
            label5.Text = row["c_ID"].ToString();
            label6.Text = row["c_Identifier"].ToString();
            OdbcDataReader read =  SqlConnect.ExecuteDataReader("*","DictionaryEntryTbl","c_ID = "+row["OPT"].ToString());
            read.Read();
            label7.Text = read["c_value"].ToString();
            read.Close();
            read = SqlConnect.ExecuteDataReader("*", "DictionaryEntryTbl", "c_ID = " + row["KRG"].ToString());
            read.Read();
            label8.Text = read["c_value"].ToString();
            read.Close();
            this.Location = location;
        }

        private void ObjectDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
