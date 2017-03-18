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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCheckResult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxBody = new System.Windows.Forms.GroupBox();
            this.webBody = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStripTextBoxDetectedLanguage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.toolStripTextBoxDetectedLanguage,
            this.toolStripSeparator3,
            this.toolStripLabelModerateContent,
            this.toolStripButtonModerateContent,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1204, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabelEmail
            // 
            this.toolStripLabelEmail.Name = "toolStripLabelEmail";
            this.toolStripLabelEmail.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabelEmail.Text = "Email-Konto:   ";
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(1204, 669);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer2.Size = new System.Drawing.Size(500, 669);
            this.splitContainer2.SplitterDistance = 374;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxEmails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Emails-Liste ";
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmails.ForeColor = System.Drawing.Color.Blue;
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.Location = new System.Drawing.Point(3, 16);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(494, 355);
            this.listBoxEmails.TabIndex = 0;
            this.listBoxEmails.SelectedIndexChanged += new System.EventHandler(this.listBoxEmails_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCheckResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Prüfergebnis ";
            // 
            // txtCheckResult
            // 
            this.txtCheckResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCheckResult.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckResult.ForeColor = System.Drawing.Color.Red;
            this.txtCheckResult.Location = new System.Drawing.Point(3, 16);
            this.txtCheckResult.Multiline = true;
            this.txtCheckResult.Name = "txtCheckResult";
            this.txtCheckResult.Size = new System.Drawing.Size(494, 272);
            this.txtCheckResult.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxBody);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 617);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxBody
            // 
            this.groupBoxBody.Controls.Add(this.webBody);
            this.groupBoxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBody.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBody.Name = "groupBoxBody";
            this.groupBoxBody.Size = new System.Drawing.Size(700, 617);
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
            this.webBody.Size = new System.Drawing.Size(694, 598);
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
            this.panel1.Size = new System.Drawing.Size(700, 52);
            this.panel1.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(57, 16);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(631, 20);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 694);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 25);
            this.panel3.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1204, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainStatus
            // 
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(23, 17);
            this.mainStatus.Text = "OK";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1204, 669);
            this.panel4.TabIndex = 3;
            // 
            // toolStripTextBoxDetectedLanguage
            // 
            this.toolStripTextBoxDetectedLanguage.Name = "toolStripTextBoxDetectedLanguage";
            this.toolStripTextBoxDetectedLanguage.Size = new System.Drawing.Size(30, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1204, 719);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mainStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDetectedLanguage;
    }
}

