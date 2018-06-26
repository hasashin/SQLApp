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
    }
}
