namespace LibraryManagementSystem
{
    partial class LMSMainForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMSMainForAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBorrower = new System.Windows.Forms.ToolStripMenuItem();
            this.addBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookKeepingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookSearchToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.checkinToolStripMenuItem,
            this.menuBorrower,
            this.bookKeepingToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookSearchToolStripMenuItem.Text = "Book Search";
            this.bookSearchToolStripMenuItem.Click += new System.EventHandler(this.bookSearchToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkoutToolStripMenuItem.Text = "Check out";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // checkinToolStripMenuItem
            // 
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkinToolStripMenuItem.Text = "Check in";
            this.checkinToolStripMenuItem.Click += new System.EventHandler(this.checkinToolStripMenuItem_Click);
            // 
            // menuBorrower
            // 
            this.menuBorrower.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBorrowerToolStripMenuItem,
            this.modifyBorrowerToolStripMenuItem});
            this.menuBorrower.Name = "menuBorrower";
            this.menuBorrower.Size = new System.Drawing.Size(152, 22);
            this.menuBorrower.Text = "Borrower";
            this.menuBorrower.Visible = false;
            // 
            // addBorrowerToolStripMenuItem
            // 
            this.addBorrowerToolStripMenuItem.Name = "addBorrowerToolStripMenuItem";
            this.addBorrowerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addBorrowerToolStripMenuItem.Text = "Add Borrower";
            this.addBorrowerToolStripMenuItem.Click += new System.EventHandler(this.addBorrowerToolStripMenuItem_Click);
            // 
            // modifyBorrowerToolStripMenuItem
            // 
            this.modifyBorrowerToolStripMenuItem.Name = "modifyBorrowerToolStripMenuItem";
            this.modifyBorrowerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modifyBorrowerToolStripMenuItem.Text = "Modify Borrower";
            this.modifyBorrowerToolStripMenuItem.Click += new System.EventHandler(this.modifyBorrowerToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bookKeepingToolStripMenuItem
            // 
            this.bookKeepingToolStripMenuItem.Name = "bookKeepingToolStripMenuItem";
            this.bookKeepingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookKeepingToolStripMenuItem.Text = "Book Keeping";
            this.bookKeepingToolStripMenuItem.Click += new System.EventHandler(this.bookKeepingToolStripMenuItem_Click);
            // 
            // LMSMainForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LMSMainForAdmin";
            this.Text = "Library Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuBorrower;
        private System.Windows.Forms.ToolStripMenuItem modifyBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookKeepingToolStripMenuItem;
    }
}