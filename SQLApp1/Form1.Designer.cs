namespace SQLApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ObrebSelectCombo = new System.Windows.Forms.ComboBox();
            this.ObrebSelectLabel = new System.Windows.Forms.Label();
            this.panelRoboczy = new System.Windows.Forms.Panel();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.ObjectsGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GoButton = new System.Windows.Forms.Button();
            this.ObjectCountTBox = new System.Windows.Forms.TextBox();
            this.ObjectCountLabel = new System.Windows.Forms.Label();
            this.SystematykaGroup = new System.Windows.Forms.GroupBox();
            this.SystematicsSelectButton = new System.Windows.Forms.Button();
            this.JEwidencyjnaSelectCombo = new System.Windows.Forms.ComboBox();
            this.JEwidencyjnaLabel = new System.Windows.Forms.Label();
            this.PowiatSelectCombo = new System.Windows.Forms.ComboBox();
            this.PowiatLabel = new System.Windows.Forms.Label();
            this.SQLSrvNameTBox = new System.Windows.Forms.TextBox();
            this.SQLSrvNameLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DBSelectLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DBSelectCombo = new System.Windows.Forms.ComboBox();
            this.SQLPasswdTBox = new System.Windows.Forms.TextBox();
            this.SQLPasswdLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.panelRoboczy.SuspendLayout();
            this.ObjectsGroupBox.SuspendLayout();
            this.SystematykaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObrebSelectCombo
            // 
            this.ObrebSelectCombo.FormattingEnabled = true;
            resources.ApplyResources(this.ObrebSelectCombo, "ObrebSelectCombo");
            this.ObrebSelectCombo.Name = "ObrebSelectCombo";
            this.ObrebSelectCombo.SelectedIndexChanged += new System.EventHandler(this.ObrebSelectCombo_SelectedIndexChanged);
            // 
            // ObrebSelectLabel
            // 
            resources.ApplyResources(this.ObrebSelectLabel, "ObrebSelectLabel");
            this.ObrebSelectLabel.Name = "ObrebSelectLabel";
            // 
            // panelRoboczy
            // 
            this.panelRoboczy.Controls.Add(this.aliasLabel);
            this.panelRoboczy.Controls.Add(this.aliasTextBox);
            this.panelRoboczy.Controls.Add(this.ObjectsGroupBox);
            this.panelRoboczy.Controls.Add(this.SystematykaGroup);
            resources.ApplyResources(this.panelRoboczy, "panelRoboczy");
            this.panelRoboczy.Name = "panelRoboczy";
            // 
            // aliasLabel
            // 
            resources.ApplyResources(this.aliasLabel, "aliasLabel");
            this.aliasLabel.Name = "aliasLabel";
            // 
            // aliasTextBox
            // 
            resources.ApplyResources(this.aliasTextBox, "aliasTextBox");
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.ReadOnly = true;
            // 
            // ObjectsGroupBox
            // 
            this.ObjectsGroupBox.Controls.Add(this.progressBar1);
            this.ObjectsGroupBox.Controls.Add(this.GoButton);
            this.ObjectsGroupBox.Controls.Add(this.ObjectCountTBox);
            this.ObjectsGroupBox.Controls.Add(this.ObjectCountLabel);
            resources.ApplyResources(this.ObjectsGroupBox, "ObjectsGroupBox");
            this.ObjectsGroupBox.Name = "ObjectsGroupBox";
            this.ObjectsGroupBox.TabStop = false;
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // GoButton
            // 
            resources.ApplyResources(this.GoButton, "GoButton");
            this.GoButton.Name = "GoButton";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ObjectCountTBox
            // 
            resources.ApplyResources(this.ObjectCountTBox, "ObjectCountTBox");
            this.ObjectCountTBox.Name = "ObjectCountTBox";
            this.ObjectCountTBox.ReadOnly = true;
            // 
            // ObjectCountLabel
            // 
            resources.ApplyResources(this.ObjectCountLabel, "ObjectCountLabel");
            this.ObjectCountLabel.Name = "ObjectCountLabel";
            // 
            // SystematykaGroup
            // 
            this.SystematykaGroup.Controls.Add(this.SystematicsSelectButton);
            this.SystematykaGroup.Controls.Add(this.JEwidencyjnaSelectCombo);
            this.SystematykaGroup.Controls.Add(this.JEwidencyjnaLabel);
            this.SystematykaGroup.Controls.Add(this.ObrebSelectCombo);
            this.SystematykaGroup.Controls.Add(this.PowiatSelectCombo);
            this.SystematykaGroup.Controls.Add(this.PowiatLabel);
            this.SystematykaGroup.Controls.Add(this.ObrebSelectLabel);
            resources.ApplyResources(this.SystematykaGroup, "SystematykaGroup");
            this.SystematykaGroup.Name = "SystematykaGroup";
            this.SystematykaGroup.TabStop = false;
            // 
            // SystematicsSelectButton
            // 
            resources.ApplyResources(this.SystematicsSelectButton, "SystematicsSelectButton");
            this.SystematicsSelectButton.Name = "SystematicsSelectButton";
            this.SystematicsSelectButton.UseVisualStyleBackColor = true;
            this.SystematicsSelectButton.Click += new System.EventHandler(this.SystematicsSelectButton_Click);
            // 
            // JEwidencyjnaSelectCombo
            // 
            this.JEwidencyjnaSelectCombo.FormattingEnabled = true;
            resources.ApplyResources(this.JEwidencyjnaSelectCombo, "JEwidencyjnaSelectCombo");
            this.JEwidencyjnaSelectCombo.Name = "JEwidencyjnaSelectCombo";
            this.JEwidencyjnaSelectCombo.SelectedIndexChanged += new System.EventHandler(this.JEwidencyjnaSelectCombo_SelectedIndexChanged);
            // 
            // JEwidencyjnaLabel
            // 
            resources.ApplyResources(this.JEwidencyjnaLabel, "JEwidencyjnaLabel");
            this.JEwidencyjnaLabel.Name = "JEwidencyjnaLabel";
            // 
            // PowiatSelectCombo
            // 
            this.PowiatSelectCombo.FormattingEnabled = true;
            resources.ApplyResources(this.PowiatSelectCombo, "PowiatSelectCombo");
            this.PowiatSelectCombo.Name = "PowiatSelectCombo";
            this.PowiatSelectCombo.SelectedIndexChanged += new System.EventHandler(this.PowiatSelectCombo_SelectedIndexChanged);
            // 
            // PowiatLabel
            // 
            resources.ApplyResources(this.PowiatLabel, "PowiatLabel");
            this.PowiatLabel.Name = "PowiatLabel";
            // 
            // SQLSrvNameTBox
            // 
            resources.ApplyResources(this.SQLSrvNameTBox, "SQLSrvNameTBox");
            this.SQLSrvNameTBox.Name = "SQLSrvNameTBox";
            // 
            // SQLSrvNameLabel
            // 
            resources.ApplyResources(this.SQLSrvNameLabel, "SQLSrvNameLabel");
            this.SQLSrvNameLabel.Name = "SQLSrvNameLabel";
            // 
            // ConnectButton
            // 
            resources.ApplyResources(this.ConnectButton, "ConnectButton");
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DBSelectLabel
            // 
            resources.ApplyResources(this.DBSelectLabel, "DBSelectLabel");
            this.DBSelectLabel.Name = "DBSelectLabel";
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DBSelectCombo
            // 
            this.DBSelectCombo.FormattingEnabled = true;
            this.DBSelectCombo.Items.AddRange(new object[] {
            resources.GetString("DBSelectCombo.Items")});
            resources.ApplyResources(this.DBSelectCombo, "DBSelectCombo");
            this.DBSelectCombo.Name = "DBSelectCombo";
            // 
            // SQLPasswdTBox
            // 
            resources.ApplyResources(this.SQLPasswdTBox, "SQLPasswdTBox");
            this.SQLPasswdTBox.Name = "SQLPasswdTBox";
            this.SQLPasswdTBox.UseSystemPasswordChar = true;
            // 
            // SQLPasswdLabel
            // 
            resources.ApplyResources(this.SQLPasswdLabel, "SQLPasswdLabel");
            this.SQLPasswdLabel.Name = "SQLPasswdLabel";
            // 
            // StateLabel
            // 
            resources.ApplyResources(this.StateLabel, "StateLabel");
            this.StateLabel.Name = "StateLabel";
            // 
            // Form1
            // 
            this.AcceptButton = this.ConnectButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.SQLPasswdLabel);
            this.Controls.Add(this.SQLPasswdTBox);
            this.Controls.Add(this.DBSelectCombo);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DBSelectLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SQLSrvNameLabel);
            this.Controls.Add(this.SQLSrvNameTBox);
            this.Controls.Add(this.panelRoboczy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelRoboczy.ResumeLayout(false);
            this.panelRoboczy.PerformLayout();
            this.ObjectsGroupBox.ResumeLayout(false);
            this.ObjectsGroupBox.PerformLayout();
            this.SystematykaGroup.ResumeLayout(false);
            this.SystematykaGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ObrebSelectCombo;
        private System.Windows.Forms.Label ObrebSelectLabel;
        private System.Windows.Forms.Panel panelRoboczy;
        private System.Windows.Forms.TextBox SQLSrvNameTBox;
        private System.Windows.Forms.Label SQLSrvNameLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label DBSelectLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox DBSelectCombo;
        private System.Windows.Forms.TextBox SQLPasswdTBox;
        private System.Windows.Forms.Label SQLPasswdLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label JEwidencyjnaLabel;
        private System.Windows.Forms.ComboBox PowiatSelectCombo;
        private System.Windows.Forms.ComboBox JEwidencyjnaSelectCombo;
        private System.Windows.Forms.Label PowiatLabel;
        private System.Windows.Forms.GroupBox SystematykaGroup;
        private System.Windows.Forms.Button SystematicsSelectButton;
        private System.Windows.Forms.GroupBox ObjectsGroupBox;
        private System.Windows.Forms.TextBox ObjectCountTBox;
        private System.Windows.Forms.Label ObjectCountLabel;
        private System.Windows.Forms.Button GoButton;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.TextBox aliasTextBox;
    }
}

