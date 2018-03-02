using System;
using System.Windows.Forms;

namespace SQLApp1
{
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
        }
        public FormDialog(string WName)
        {
            InitializeComponent();
            WrongDataLabel.Text = WName;
        }
        public string GetGoodName()
        {
            return NameTBox.Text;
        }
        public string GetGoodDesc()
        {
            return CorrectDescTBox.Text;
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
    }
}
