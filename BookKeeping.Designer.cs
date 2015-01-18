namespace LibraryManagementSystem
{
    partial class BookKeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookKeeping));
            this.btnModify = new System.Windows.Forms.Button();
            this.lbCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.dgBorrower = new System.Windows.Forms.DataGridView();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(468, 59);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(77, 27);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Go";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.Location = new System.Drawing.Point(61, 70);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(82, 14);
            this.lbCardNo.TabIndex = 9;
            this.lbCardNo.Text = "Card Number";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(272, 61);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(135, 22);
            this.txtCardNo.TabIndex = 8;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisplay.Controls.Add(this.dgBorrower);
            this.pnlDisplay.Location = new System.Drawing.Point(-134, 138);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(880, 196);
            this.pnlDisplay.TabIndex = 11;
            this.pnlDisplay.Visible = false;
            // 
            // dgBorrower
            // 
            this.dgBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrower.Location = new System.Drawing.Point(169, 18);
            this.dgBorrower.Name = "dgBorrower";
            this.dgBorrower.Size = new System.Drawing.Size(645, 174);
            this.dgBorrower.TabIndex = 9;
            // 
            // BookKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 433);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.txtCardNo);
            this.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookKeeping";
            this.Text = "BookKeeping";
            this.Load += new System.EventHandler(this.BookKeeping_Load);
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.DataGridView dgBorrower;
    }
}