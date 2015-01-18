namespace LibraryManagementSystem
{
    partial class CheckinBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckinBooks));
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtBorrowerFirstName = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookid = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtBorrowerLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCheckInBooks = new System.Windows.Forms.DataGridView();
            this.lbText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckInBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(233, 66);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(116, 22);
            this.txtCardNo.TabIndex = 0;
            // 
            // txtBorrowerFirstName
            // 
            this.txtBorrowerFirstName.Location = new System.Drawing.Point(499, 66);
            this.txtBorrowerFirstName.Name = "txtBorrowerFirstName";
            this.txtBorrowerFirstName.Size = new System.Drawing.Size(116, 22);
            this.txtBorrowerFirstName.TabIndex = 1;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(38, 66);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(116, 22);
            this.txtBookId.TabIndex = 2;
            // 
            // lblBookid
            // 
            this.lblBookid.AutoSize = true;
            this.lblBookid.BackColor = System.Drawing.Color.Transparent;
            this.lblBookid.ForeColor = System.Drawing.Color.White;
            this.lblBookid.Location = new System.Drawing.Point(72, 24);
            this.lblBookid.Name = "lblBookid";
            this.lblBookid.Size = new System.Drawing.Size(50, 14);
            this.lblBookid.TabIndex = 3;
            this.lblBookid.Text = "Book ID";
            this.lblBookid.Click += new System.EventHandler(this.lblBookid_Click);
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCardNo.ForeColor = System.Drawing.Color.White;
            this.lblCardNo.Location = new System.Drawing.Point(253, 24);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(82, 14);
            this.lblCardNo.TabIndex = 4;
            this.lblCardNo.Text = "Card Number";
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrowerName.ForeColor = System.Drawing.Color.White;
            this.lblBorrowerName.Location = new System.Drawing.Point(497, 24);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(127, 14);
            this.lblBorrowerName.TabIndex = 5;
            this.lblBorrowerName.Text = "Borrower First Name";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(403, 122);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(43, 25);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtBorrowerLastName
            // 
            this.txtBorrowerLastName.Location = new System.Drawing.Point(693, 65);
            this.txtBorrowerLastName.Name = "txtBorrowerLastName";
            this.txtBorrowerLastName.Size = new System.Drawing.Size(116, 22);
            this.txtBorrowerLastName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(693, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Borrower Last Name";
            // 
            // dgCheckInBooks
            // 
            this.dgCheckInBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCheckInBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCheckInBooks.GridColor = System.Drawing.Color.Chocolate;
            this.dgCheckInBooks.Location = new System.Drawing.Point(220, 207);
            this.dgCheckInBooks.Name = "dgCheckInBooks";
            this.dgCheckInBooks.Size = new System.Drawing.Size(418, 162);
            this.dgCheckInBooks.TabIndex = 9;
            this.dgCheckInBooks.Visible = false;
            this.dgCheckInBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCheckInBooks_CellDoubleClick);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Calibri Light", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(268, 165);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(349, 18);
            this.lbText.TabIndex = 10;
            this.lbText.Text = "Double click on the Book_id  to check in the book";
            this.lbText.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CheckinBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.dgCheckInBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBorrowerLastName);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblBorrowerName);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.lblBookid);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtBorrowerFirstName);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CheckinBooks";
            this.Text = "Check in Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckInBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtBorrowerFirstName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookid;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtBorrowerLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCheckInBooks;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}