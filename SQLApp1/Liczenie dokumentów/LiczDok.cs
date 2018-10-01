using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;

namespace SQLApp1.Liczenie_dokumentów
{
    public partial class LiczStrony : Form
    {
        delegate void StringArgReturningVoidDelegate(ref int dok,ref int str);
        bool robotaWre = false;
        public void CountPages(string file, ref int str)
        {
            PdfReader pdfReader = new PdfReader(file);
            str += pdfReader.NumberOfPages;
        }
        public void MakeItDone(string path,ref int dok, ref int str)
        {
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);
            foreach (string file in files)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    throw new Exception("Przerwano na żądanie użytkownika");
                }
                if (Path.GetExtension(file) == ".pdf")
                {
                    dok += 1;
                    CountPages(file, ref str);
                }
                UpdateTBoxes(ref dok, ref str);
            }
            foreach(string dir in dirs)
            {
                MakeItDone(dir, ref dok, ref str);
            }
        }
        public void UpdateTBoxes(ref int dok, ref int str)
        {
            if (textBox2.InvokeRequired || textBox3.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(UpdateTBoxes);
                Invoke(d, new object[] { dok, str });
            }
            else
            {
                textBox2.Text = dok.ToString();
                textBox3.Text = str.ToString();
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
            int dok = 0, str = 0;
            try
            {
                MakeItDone(e.Argument as string, ref dok, ref str);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd: "+ex.Message);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Licz_Click(null, null);
        }
    }
}
