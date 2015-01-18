namespace LibraryManagementSystem
{
    partial class BookSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSearch));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookid = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.subSearch = new System.Windows.Forms.Button();
            this.dgBookSearch = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(390, 66);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(116, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(574, 67);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(116, 22);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(199, 67);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(116, 22);
            this.txtBookId.TabIndex = 3;
            // 
            // lblBookid
            // 
            this.lblBookid.AutoSize = true;
            this.lblBookid.BackColor = System.Drawing.Color.Transparent;
            this.lblBookid.ForeColor = System.Drawing.Color.White;
            this.lblBookid.Location = new System.Drawing.Point(238, 28);
            this.lblBookid.Name = "lblBookid";
            this.lblBookid.Size = new System.Drawing.Size(50, 14);
            this.lblBookid.TabIndex = 4;
            this.lblBookid.Text = "Book ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(422, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 14);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.ForeColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Location = new System.Drawing.Point(618, 28);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 14);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            // 
            // subSearch
            // 
            this.subSearch.BackColor = System.Drawing.Color.Transparent;
            this.subSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subSearch.ForeColor = System.Drawing.Color.White;
            this.subSearch.Location = new System.Drawing.Point(390, 136);
            this.subSearch.Name = "subSearch";
            this.subSearch.Size = new System.Drawing.Size(87, 25);
            this.subSearch.TabIndex = 7;
            this.subSearch.Text = "Search";
            this.subSearch.UseVisualStyleBackColor = false;
            this.subSearch.Click += new System.EventHandler(this.subSearch_Click);
            // 
            // dgBookSearch
            // 
            this.dgBookSearch.AllowUserToOrderColumns = true;
            this.dgBookSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgBookSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgBookSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgBookSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBookSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookSearch.GridColor = System.Drawing.Color.Chocolate;
            this.dgBookSearch.Location = new System.Drawing.Point(14, 189);
            this.dgBookSearch.Name = "dgBookSearch";
            this.dgBookSearch.RowHeadersWidth = 80;
            this.dgBookSearch.Size = new System.Drawing.Size(875, 161);
            this.dgBookSearch.TabIndex = 8;
            this.dgBookSearch.Visible = false;
            this.dgBookSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookSearch_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgBookSearch);
            this.Controls.Add(this.subSearch);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookid);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookSearch";
            this.Text = "Book  Search";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button subSearch;
        private System.Windows.Forms.DataGridView dgBookSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}