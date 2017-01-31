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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UI_HomeButton = new System.Windows.Forms.Button();
            this.UI_GoButton = new System.Windows.Forms.Button();
            this.UI_BackButton = new System.Windows.Forms.Button();
            this.UI_ForwardButton = new System.Windows.Forms.Button();
            this.UI_AddressCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_AddBookmarkBox = new System.Windows.Forms.TextBox();
            this.UI_BookmarkBox = new System.Windows.Forms.ListBox();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_WebBrowser
            // 
            this.UI_WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_WebBrowser.Location = new System.Drawing.Point(131, 56);
            this.UI_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.UI_WebBrowser.Name = "UI_WebBrowser";
            this.UI_WebBrowser.ScriptErrorsSuppressed = true;
            this.UI_WebBrowser.Size = new System.Drawing.Size(853, 706);
            this.UI_WebBrowser.TabIndex = 6;
            this.UI_WebBrowser.Url = new System.Uri("http://www.google.ca", System.UriKind.Absolute);
            this.UI_WebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.UI_WebBrowser_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bookmarkToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // UI_HomeButton
            // 
            this.UI_HomeButton.Location = new System.Drawing.Point(5, 27);
            this.UI_HomeButton.Name = "UI_HomeButton";
            this.UI_HomeButton.Size = new System.Drawing.Size(75, 23);
            this.UI_HomeButton.TabIndex = 2;
            this.UI_HomeButton.Text = "Home";
            this.UI_HomeButton.UseVisualStyleBackColor = true;
            // 
            // UI_GoButton
            // 
            this.UI_GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_GoButton.Location = new System.Drawing.Point(823, 27);
            this.UI_GoButton.Name = "UI_GoButton";
            this.UI_GoButton.Size = new System.Drawing.Size(75, 23);
            this.UI_GoButton.TabIndex = 1;
            this.UI_GoButton.Text = "Go";
            this.UI_GoButton.UseVisualStyleBackColor = true;
            this.UI_GoButton.Click += new System.EventHandler(this.UI_GoButton_Click);
            // 
            // UI_BackButton
            // 
            this.UI_BackButton.Location = new System.Drawing.Point(86, 27);
            this.UI_BackButton.Name = "UI_BackButton";
            this.UI_BackButton.Size = new System.Drawing.Size(43, 23);
            this.UI_BackButton.TabIndex = 3;
            this.UI_BackButton.Text = "<<";
            this.UI_BackButton.UseVisualStyleBackColor = true;
            this.UI_BackButton.Click += new System.EventHandler(this.UI_BackButton_Click);
            // 
            // UI_ForwardButton
            // 
            this.UI_ForwardButton.Location = new System.Drawing.Point(135, 27);
            this.UI_ForwardButton.Name = "UI_ForwardButton";
            this.UI_ForwardButton.Size = new System.Drawing.Size(39, 23);
            this.UI_ForwardButton.TabIndex = 4;
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
            this.UI_AddressCombo.Size = new System.Drawing.Size(637, 21);
            this.UI_AddressCombo.TabIndex = 0;
            this.UI_AddressCombo.Text = "google.ca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bookmark Name:";
            // 
            // UI_AddBookmarkBox
            // 
            this.UI_AddBookmarkBox.Location = new System.Drawing.Point(5, 72);
            this.UI_AddBookmarkBox.Name = "UI_AddBookmarkBox";
            this.UI_AddBookmarkBox.Size = new System.Drawing.Size(100, 20);
            this.UI_AddBookmarkBox.TabIndex = 8;
            // 
            // UI_BookmarkBox
            // 
            this.UI_BookmarkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_BookmarkBox.FormattingEnabled = true;
            this.UI_BookmarkBox.Location = new System.Drawing.Point(5, 98);
            this.UI_BookmarkBox.Name = "UI_BookmarkBox";
            this.UI_BookmarkBox.Size = new System.Drawing.Size(120, 654);
            this.UI_BookmarkBox.TabIndex = 9;
            this.UI_BookmarkBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UI_BookmarkBox_MouseDoubleClick);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.UI_GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.UI_BookmarkBox);
            this.Controls.Add(this.UI_AddBookmarkBox);
            this.Controls.Add(this.label1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_AddBookmarkBox;
        private System.Windows.Forms.ListBox UI_BookmarkBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
    }
}

