using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace SQLApp1.Liczenie_dokumentów
{
    public partial class LiczStrony : Form
    {
        private int A4W=210;
        private int A4H=297;
        private bool virtClick = false;

        delegate void StringArgReturningVoidDelegate(ref int dok,ref int str,ref int fault);
        bool robotaWre = false;
        public void CountPages(string file, ref int str)
        {
            PdfReader pdfReader = new PdfReader(file);
            Rectangle page;
            for (int i = 1; i <= pdfReader.NumberOfPages; i++)
            {
                page = pdfReader.GetCropBox(i);
                float area = Utilities.PointsToMillimeters(page.Height) * Utilities.PointsToMillimeters(page.Width);
                str += Convert.ToInt32(Math.Round(area / (A4H * A4W)));
            }
        }
        public void MakeItDone(string path,ref int dok, ref int str,ref int fault)
        {
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);
            foreach (string file in files)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    throw new Exception("Przerwano na żądanie użytkownika");
                }
                if (Path.GetExtension(file) == ".pdf" && !Path.GetFileNameWithoutExtension(file).StartsWith("._"))
                {
                    dok += 1;
                    try
                    {
                        CountPages(file, ref str);
                    }
                    catch(Exception e)
                    {
                        fault++;
                        MessageBox.Show(null, "Wystąpił problem z plikiem\n" + file + "\nBłąd: " + e.Message, "Błąd podczas liczenia stron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                UpdateTBoxes(ref dok, ref str,ref fault);
            }
            foreach(string dir in dirs)
            {
                MakeItDone(dir, ref dok, ref str,ref fault);
            }
        }
        public void UpdateTBoxes(ref int dok, ref int str,ref int fault)
        {
            if (textBox2.InvokeRequired || textBox3.InvokeRequired || faultTextBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(UpdateTBoxes);
                Invoke(d, new object[] { dok, str, fault });
            }
            else
            {
                textBox2.Text = dok.ToString();
                textBox3.Text = str.ToString();
                faultTextBox.Text = fault.ToString();
            }

        }
        public LiczStrony()
        {
            InitializeComponent();
        }

        void SetControlsAble(bool data)
        {
            Zrobione.Enabled = data;
            textBox1.Enabled = data;
            BrowseButton.Enabled = data;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Licz_Click(object sender, EventArgs e)
        {
            if (!robotaWre)
            {
                robotaWre = true;
                SetControlsAble(false);
                Licz.Text = "Przerwij";
                backgroundWorker1.RunWorkerAsync(textBox1.Text);
                return;
            }
            if (robotaWre)
            {
                robotaWre = false;
                SetControlsAble(true);
                Licz.Text = "Licz";
                backgroundWorker1.CancelAsync();
                return;
            }
        }

        private void Zrobione_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int dok = 0, str = 0, fault = 0 ;
            try
            {
                MakeItDone(e.Argument as string, ref dok, ref str,ref fault);
                virtClick = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(null,"Błąd: "+ex.Message,"Błąd!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (virtClick)
            {
                Licz_Click(null, null);
                virtClick = false;
            }
            MessageBox.Show(null, "Zakończono liczenie plików PDF.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
