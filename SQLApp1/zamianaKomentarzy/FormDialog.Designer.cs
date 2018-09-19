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
            this.label4 = new System.Windows.Forms.Label();
            this.IGNOREButton = new System.Windows.Forms.Button();
            this.CorrectDescCombo = new System.Windows.Forms.ComboBox();
            this.showFileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.EditStringTBox = new System.Windows.Forms.TextBox();
            this.CorrectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(492, 418);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(112, 35);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CANCELButton
            // 
            this.CANCELButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCELButton.Location = new System.Drawing.Point(249, 418);
            this.CANCELButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANCELButton.Name = "CANCELButton";
            this.CANCELButton.Size = new System.Drawing.Size(112, 35);
            this.CANCELButton.TabIndex = 1;
            this.CANCELButton.Text = "Anuluj";
            this.CANCELButton.UseVisualStyleBackColor = true;
            this.CANCELButton.Click += new System.EventHandler(this.CANCELButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wykryto nieprawidłową wartość: ";
            // 
            // WrongDataLabel
            // 
            this.WrongDataLabel.AutoSize = true;
            this.WrongDataLabel.Location = new System.Drawing.Point(268, 14);
            this.WrongDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WrongDataLabel.Name = "WrongDataLabel";
            this.WrongDataLabel.Size = new System.Drawing.Size(0, 20);
            this.WrongDataLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poprawna nazwa pliku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poprawny typ pliku";
            // 
            // NameTBox
            // 
            this.NameTBox.Location = new System.Drawing.Point(251, 114);
            this.NameTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(351, 26);
            this.NameTBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poprawny opis pliku";
            // 
            // IGNOREButton
            // 
            this.IGNOREButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IGNOREButton.Location = new System.Drawing.Point(370, 418);
            this.IGNOREButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IGNOREButton.Name = "IGNOREButton";
            this.IGNOREButton.Size = new System.Drawing.Size(112, 35);
            this.IGNOREButton.TabIndex = 10;
            this.IGNOREButton.Text = "Pomiń";
            this.IGNOREButton.UseVisualStyleBackColor = true;
            this.IGNOREButton.Click += new System.EventHandler(this.IGNOREButton_Click);
            // 
            // CorrectDescCombo
            // 
            this.CorrectDescCombo.FormattingEnabled = true;
            this.CorrectDescCombo.Location = new System.Drawing.Point(251, 194);
            this.CorrectDescCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CorrectDescCombo.Name = "CorrectDescCombo";
            this.CorrectDescCombo.Size = new System.Drawing.Size(351, 28);
            this.CorrectDescCombo.TabIndex = 11;
            // 
            // showFileButton
            // 
            this.showFileButton.Location = new System.Drawing.Point(21, 374);
            this.showFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showFileButton.Name = "showFileButton";
            this.showFileButton.Size = new System.Drawing.Size(112, 35);
            this.showFileButton.TabIndex = 12;
            this.showFileButton.Text = "Zbacz plik";
            this.showFileButton.UseVisualStyleBackColor = true;
            this.showFileButton.Click += new System.EventHandler(this.showFileButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Szczegóły obiektu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(50, 75);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(167, 24);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Poprawne wartości";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(50, 255);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(184, 24);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Poprawny ciąg tekstu";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // EditStringTBox
            // 
            this.EditStringTBox.Enabled = false;
            this.EditStringTBox.Location = new System.Drawing.Point(22, 317);
            this.EditStringTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditStringTBox.Name = "EditStringTBox";
            this.EditStringTBox.Size = new System.Drawing.Size(580, 26);
            this.EditStringTBox.TabIndex = 16;
            // 
            // CorrectTypeComboBox
            // 
            this.CorrectTypeComboBox.FormattingEnabled = true;
            this.CorrectTypeComboBox.Location = new System.Drawing.Point(251, 154);
            this.CorrectTypeComboBox.Name = "CorrectTypeComboBox";
            this.CorrectTypeComboBox.Size = new System.Drawing.Size(351, 28);
            this.CorrectTypeComboBox.TabIndex = 17;
            // 
            // FormDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CANCELButton;
            this.ClientSize = new System.Drawing.Size(622, 495);
            this.ControlBox = false;
            this.Controls.Add(this.CorrectTypeComboBox);
            this.Controls.Add(this.EditStringTBox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showFileButton);
            this.Controls.Add(this.CorrectDescCombo);
            this.Controls.Add(this.IGNOREButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WrongDataLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CANCELButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popraw nazwę";
            this.Load += new System.EventHandler(this.FormDialog_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IGNOREButton;
        private System.Windows.Forms.ComboBox CorrectDescCombo;
        private System.Windows.Forms.Button showFileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EditStringTBox;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox CorrectTypeComboBox;
    }
}