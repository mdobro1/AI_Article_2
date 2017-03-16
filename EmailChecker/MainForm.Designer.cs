namespace EmailChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelEmail = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_Accounts = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelQueryEmails = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonReadEmail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelDetectLanguage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonDetectLanguage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelModerateContent = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonModerateContent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxBody = new System.Windows.Forms.GroupBox();
            this.webBody = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtCheckResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxBody.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelEmail,
            this.toolStripComboBox_Accounts,
            this.toolStripSeparator1,
            this.toolStripLabelQueryEmails,
            this.toolStripButtonReadEmail,
            this.toolStripSeparator2,
            this.toolStripLabelDetectLanguage,
            this.toolStripButtonDetectLanguage,
            this.toolStripSeparator3,
            this.toolStripLabelModerateContent,
            this.toolStripButtonModerateContent,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabelEmail
            // 
            this.toolStripLabelEmail.Name = "toolStripLabelEmail";
            this.toolStripLabelEmail.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabelEmail.Text = "Email: ";
            // 
            // toolStripComboBox_Accounts
            // 
            this.toolStripComboBox_Accounts.Name = "toolStripComboBox_Accounts";
            this.toolStripComboBox_Accounts.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelQueryEmails
            // 
            this.toolStripLabelQueryEmails.Name = "toolStripLabelQueryEmails";
            this.toolStripLabelQueryEmails.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabelQueryEmails.Text = "Mails abfragen";
            this.toolStripLabelQueryEmails.Click += new System.EventHandler(this.toolStripLabelQueryEmails_Click);
            // 
            // toolStripButtonReadEmail
            // 
            this.toolStripButtonReadEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReadEmail.Image = global::EmailChecker.Properties.Resources.ReadEmailImage;
            this.toolStripButtonReadEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReadEmail.Name = "toolStripButtonReadEmail";
            this.toolStripButtonReadEmail.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReadEmail.ToolTipText = "Emails abfragen";
            this.toolStripButtonReadEmail.Click += new System.EventHandler(this.toolStripButtonReadEmail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelDetectLanguage
            // 
            this.toolStripLabelDetectLanguage.Name = "toolStripLabelDetectLanguage";
            this.toolStripLabelDetectLanguage.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabelDetectLanguage.Text = "Sprache erkennen";
            this.toolStripLabelDetectLanguage.Click += new System.EventHandler(this.toolStripLabelDetectLanguage_Click);
            // 
            // toolStripButtonDetectLanguage
            // 
            this.toolStripButtonDetectLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDetectLanguage.Image = global::EmailChecker.Properties.Resources.Translate;
            this.toolStripButtonDetectLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDetectLanguage.Name = "toolStripButtonDetectLanguage";
            this.toolStripButtonDetectLanguage.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDetectLanguage.Text = "toolStripButton1";
            this.toolStripButtonDetectLanguage.Click += new System.EventHandler(this.toolStripButtonDetectLanguage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelModerateContent
            // 
            this.toolStripLabelModerateContent.Name = "toolStripLabelModerateContent";
            this.toolStripLabelModerateContent.Size = new System.Drawing.Size(81, 22);
            this.toolStripLabelModerateContent.Text = "Inhalte Prüfen";
            this.toolStripLabelModerateContent.Click += new System.EventHandler(this.toolStripLabelModerateContent_Click);
            // 
            // toolStripButtonModerateContent
            // 
            this.toolStripButtonModerateContent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonModerateContent.Image = global::EmailChecker.Properties.Resources.OK_Thumb;
            this.toolStripButtonModerateContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModerateContent.Name = "toolStripButtonModerateContent";
            this.toolStripButtonModerateContent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonModerateContent.Text = "toolStripButton1";
            this.toolStripButtonModerateContent.ToolTipText = "Emails prüfen";
            this.toolStripButtonModerateContent.Click += new System.EventHandler(this.toolStripButtonModerateContent_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(870, 455);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 1;
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.Location = new System.Drawing.Point(3, 16);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(284, 236);
            this.listBoxEmails.TabIndex = 0;
            this.listBoxEmails.SelectedIndexChanged += new System.EventHandler(this.listBoxEmails_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxBody);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 403);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxBody
            // 
            this.groupBoxBody.Controls.Add(this.webBody);
            this.groupBoxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBody.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBody.Name = "groupBoxBody";
            this.groupBoxBody.Size = new System.Drawing.Size(576, 403);
            this.groupBoxBody.TabIndex = 0;
            this.groupBoxBody.TabStop = false;
            this.groupBoxBody.Text = "Email Inhalt";
            // 
            // webBody
            // 
            this.webBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBody.Location = new System.Drawing.Point(3, 16);
            this.webBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBody.Name = "webBody";
            this.webBody.Size = new System.Drawing.Size(570, 384);
            this.webBody.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.labelSubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 52);
            this.panel1.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(57, 16);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(506, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSubject.Location = new System.Drawing.Point(13, 19);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(38, 13);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Betreff";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(290, 455);
            this.splitContainer2.SplitterDistance = 255;
            this.splitContainer2.TabIndex = 1;
            // 
            // txtCheckResult
            // 
            this.txtCheckResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCheckResult.Location = new System.Drawing.Point(3, 16);
            this.txtCheckResult.Multiline = true;
            this.txtCheckResult.Name = "txtCheckResult";
            this.txtCheckResult.Size = new System.Drawing.Size(284, 177);
            this.txtCheckResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCheckResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Prüfergebnis ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxEmails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Emails-Liste ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(870, 480);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Outlook Email-Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxEmails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ToolStripButton toolStripButtonReadEmail;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Accounts;
        private System.Windows.Forms.ToolStripButton toolStripButtonModerateContent;
        private System.Windows.Forms.WebBrowser webBody;
        private System.Windows.Forms.ToolStripLabel toolStripLabelEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelQueryEmails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDetectLanguage;
        private System.Windows.Forms.ToolStripButton toolStripButtonDetectLanguage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelModerateContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCheckResult;
    }
}

