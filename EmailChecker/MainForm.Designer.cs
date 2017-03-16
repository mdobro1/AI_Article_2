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
            this.toolStripComboBox_Accounts = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonReadEmail = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonValidate = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxBody = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.webBody = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_Accounts,
            this.toolStripButtonReadEmail,
            this.toolStripButtonValidate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripComboBox_Accounts
            // 
            this.toolStripComboBox_Accounts.Name = "toolStripComboBox_Accounts";
            this.toolStripComboBox_Accounts.Size = new System.Drawing.Size(300, 25);
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
            // toolStripButtonValidate
            // 
            this.toolStripButtonValidate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonValidate.Image = global::EmailChecker.Properties.Resources.OK_Thumb;
            this.toolStripButtonValidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonValidate.Name = "toolStripButtonValidate";
            this.toolStripButtonValidate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonValidate.Text = "toolStripButton1";
            this.toolStripButtonValidate.ToolTipText = "Emails prüfen";
            this.toolStripButtonValidate.Click += new System.EventHandler(this.toolStripButtonValidate_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.listBoxEmails);
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
            this.listBoxEmails.Location = new System.Drawing.Point(0, 0);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(290, 455);
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
            // webBody
            // 
            this.webBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBody.Location = new System.Drawing.Point(3, 16);
            this.webBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBody.Name = "webBody";
            this.webBody.Size = new System.Drawing.Size(570, 384);
            this.webBody.TabIndex = 0;
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
        private System.Windows.Forms.ToolStripButton toolStripButtonValidate;
        private System.Windows.Forms.WebBrowser webBody;
    }
}

