namespace CMPE1600_Lab1
{
    partial class Form1
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
            this.UI_WebBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UI_HomeButton = new System.Windows.Forms.Button();
            this.UI_GoButton = new System.Windows.Forms.Button();
            this.UI_BackButton = new System.Windows.Forms.Button();
            this.UI_ForwardButton = new System.Windows.Forms.Button();
            this.UI_AddressCombo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_WebBrowser
            // 
            this.UI_WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_WebBrowser.Location = new System.Drawing.Point(147, 56);
            this.UI_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.UI_WebBrowser.Name = "UI_WebBrowser";
            this.UI_WebBrowser.Size = new System.Drawing.Size(492, 323);
            this.UI_WebBrowser.TabIndex = 0;
            this.UI_WebBrowser.Url = new System.Uri("http://www.google.ca", System.UriKind.Absolute);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bookmarkToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // UI_HomeButton
            // 
            this.UI_HomeButton.Location = new System.Drawing.Point(5, 27);
            this.UI_HomeButton.Name = "UI_HomeButton";
            this.UI_HomeButton.Size = new System.Drawing.Size(75, 23);
            this.UI_HomeButton.TabIndex = 3;
            this.UI_HomeButton.Text = "Home";
            this.UI_HomeButton.UseVisualStyleBackColor = true;
            // 
            // UI_GoButton
            // 
            this.UI_GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_GoButton.Location = new System.Drawing.Point(478, 27);
            this.UI_GoButton.Name = "UI_GoButton";
            this.UI_GoButton.Size = new System.Drawing.Size(75, 23);
            this.UI_GoButton.TabIndex = 4;
            this.UI_GoButton.Text = "Go";
            this.UI_GoButton.UseVisualStyleBackColor = true;
            this.UI_GoButton.Click += new System.EventHandler(this.UI_GoButton_Click);
            // 
            // UI_BackButton
            // 
            this.UI_BackButton.Location = new System.Drawing.Point(86, 27);
            this.UI_BackButton.Name = "UI_BackButton";
            this.UI_BackButton.Size = new System.Drawing.Size(43, 23);
            this.UI_BackButton.TabIndex = 5;
            this.UI_BackButton.Text = "<<";
            this.UI_BackButton.UseVisualStyleBackColor = true;
            this.UI_BackButton.Click += new System.EventHandler(this.UI_BackButton_Click);
            // 
            // UI_ForwardButton
            // 
            this.UI_ForwardButton.Location = new System.Drawing.Point(135, 27);
            this.UI_ForwardButton.Name = "UI_ForwardButton";
            this.UI_ForwardButton.Size = new System.Drawing.Size(39, 23);
            this.UI_ForwardButton.TabIndex = 6;
            this.UI_ForwardButton.Text = ">>";
            this.UI_ForwardButton.UseVisualStyleBackColor = true;
            this.UI_ForwardButton.Click += new System.EventHandler(this.UI_ForwardButton_Click);
            // 
            // UI_AddressCombo
            // 
            this.UI_AddressCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_AddressCombo.FormattingEnabled = true;
            this.UI_AddressCombo.Location = new System.Drawing.Point(180, 29);
            this.UI_AddressCombo.Name = "UI_AddressCombo";
            this.UI_AddressCombo.Size = new System.Drawing.Size(292, 21);
            this.UI_AddressCombo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.UI_GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 378);
            this.Controls.Add(this.UI_AddressCombo);
            this.Controls.Add(this.UI_ForwardButton);
            this.Controls.Add(this.UI_BackButton);
            this.Controls.Add(this.UI_GoButton);
            this.Controls.Add(this.UI_HomeButton);
            this.Controls.Add(this.UI_WebBrowser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser UI_WebBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Button UI_HomeButton;
        private System.Windows.Forms.Button UI_GoButton;
        private System.Windows.Forms.Button UI_BackButton;
        private System.Windows.Forms.Button UI_ForwardButton;
        private System.Windows.Forms.ComboBox UI_AddressCombo;
    }
}

