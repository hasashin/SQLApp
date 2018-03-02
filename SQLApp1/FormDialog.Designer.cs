namespace SQLApp1
{
    partial class FormDialog
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CANCELButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WrongDataLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.TypeTBox = new System.Windows.Forms.TextBox();
            this.CorrectDescTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IGNOREButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(295, 146);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CANCELButton
            // 
            this.CANCELButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCELButton.Location = new System.Drawing.Point(133, 146);
            this.CANCELButton.Name = "CANCELButton";
            this.CANCELButton.Size = new System.Drawing.Size(75, 23);
            this.CANCELButton.TabIndex = 1;
            this.CANCELButton.Text = "Anuluj";
            this.CANCELButton.UseVisualStyleBackColor = true;
            this.CANCELButton.Click += new System.EventHandler(this.CANCELButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wykryto nieprawidłową wartość";
            // 
            // WrongDataLabel
            // 
            this.WrongDataLabel.AutoSize = true;
            this.WrongDataLabel.Location = new System.Drawing.Point(179, 9);
            this.WrongDataLabel.Name = "WrongDataLabel";
            this.WrongDataLabel.Size = new System.Drawing.Size(0, 13);
            this.WrongDataLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poprawna nazwa pliku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poprawny typ pliku";
            // 
            // NameTBox
            // 
            this.NameTBox.Location = new System.Drawing.Point(132, 51);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(238, 20);
            this.NameTBox.TabIndex = 6;
            // 
            // TypeTBox
            // 
            this.TypeTBox.Location = new System.Drawing.Point(132, 78);
            this.TypeTBox.Name = "TypeTBox";
            this.TypeTBox.Size = new System.Drawing.Size(238, 20);
            this.TypeTBox.TabIndex = 7;
            this.TypeTBox.TextChanged += new System.EventHandler(this.TypeTBox_TextChanged);
            // 
            // CorrectDescTBox
            // 
            this.CorrectDescTBox.Location = new System.Drawing.Point(132, 104);
            this.CorrectDescTBox.Name = "CorrectDescTBox";
            this.CorrectDescTBox.Size = new System.Drawing.Size(238, 20);
            this.CorrectDescTBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poprawny opis pliku";
            // 
            // IGNOREButton
            // 
            this.IGNOREButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IGNOREButton.Location = new System.Drawing.Point(214, 146);
            this.IGNOREButton.Name = "IGNOREButton";
            this.IGNOREButton.Size = new System.Drawing.Size(75, 23);
            this.IGNOREButton.TabIndex = 10;
            this.IGNOREButton.Text = "Pomiń";
            this.IGNOREButton.UseVisualStyleBackColor = true;
            this.IGNOREButton.Click += new System.EventHandler(this.IGNOREButton_Click);
            // 
            // FormDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CANCELButton;
            this.ClientSize = new System.Drawing.Size(382, 181);
            this.ControlBox = false;
            this.Controls.Add(this.IGNOREButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CorrectDescTBox);
            this.Controls.Add(this.TypeTBox);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WrongDataLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CANCELButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popraw nazwę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CANCELButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WrongDataLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTBox;
        private System.Windows.Forms.TextBox TypeTBox;
        private System.Windows.Forms.TextBox CorrectDescTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IGNOREButton;
    }
}