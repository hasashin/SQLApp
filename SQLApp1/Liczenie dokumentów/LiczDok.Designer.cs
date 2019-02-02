namespace SQLApp1.Liczenie_dokumentów
{
    partial class LiczStrony
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zrobione = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Licz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.faultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Zrobione
            // 
            this.Zrobione.Location = new System.Drawing.Point(367, 389);
            this.Zrobione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zrobione.Name = "Zrobione";
            this.Zrobione.Size = new System.Drawing.Size(141, 48);
            this.Zrobione.TabIndex = 0;
            this.Zrobione.Text = "Zrobione";
            this.Zrobione.UseVisualStyleBackColor = true;
            this.Zrobione.Click += new System.EventHandler(this.Zrobione_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(737, 41);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(137, 46);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Przeglądaj...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // Licz
            // 
            this.Licz.Location = new System.Drawing.Point(367, 126);
            this.Licz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Licz.Name = "Licz";
            this.Licz.Size = new System.Drawing.Size(141, 40);
            this.Licz.TabIndex = 4;
            this.Licz.Text = "Licz";
            this.Licz.UseVisualStyleBackColor = true;
            this.Licz.Click += new System.EventHandler(this.Licz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pliki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Strony";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 245);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(208, 31);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 305);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(208, 31);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // faultTextBox
            // 
            this.faultTextBox.Location = new System.Drawing.Point(585, 245);
            this.faultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.faultTextBox.Name = "faultTextBox";
            this.faultTextBox.ReadOnly = true;
            this.faultTextBox.Size = new System.Drawing.Size(208, 31);
            this.faultTextBox.TabIndex = 10;
            this.faultTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Błędne";
            // 
            // LiczStrony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.ControlBox = false;
            this.Controls.Add(this.faultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Licz);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Zrobione);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LiczStrony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liczenie stron i dokumentów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zrobione;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Licz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox faultTextBox;
        private System.Windows.Forms.Label label4;
    }
}