namespace LibraryManagementSystem
{
    partial class ModifyBorrower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyBorrower));
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lbCardNo = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.dgBorrower = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(474, 57);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(116, 22);
            this.txtCardNo.TabIndex = 0;
            this.txtCardNo.TextChanged += new System.EventHandler(this.txtCardNo_TextChanged);
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.Location = new System.Drawing.Point(293, 65);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(82, 14);
            this.lbCardNo.TabIndex = 1;
            this.lbCardNo.Text = "Card Number";
            this.lbCardNo.Click += new System.EventHandler(this.lbCardNo_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.dgBorrower);
            this.pnlDisplay.Controls.Add(this.btnEdit);
            this.pnlDisplay.Controls.Add(this.btnDelete);
            this.pnlDisplay.Location = new System.Drawing.Point(96, 140);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(754, 243);
            this.pnlDisplay.TabIndex = 2;
            this.pnlDisplay.Visible = false;
            // 
            // dgBorrower
            // 
            this.dgBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrower.Location = new System.Drawing.Point(99, 100);
            this.dgBorrower.Name = "dgBorrower";
            this.dgBorrower.Size = new System.Drawing.Size(553, 162);
            this.dgBorrower.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(190, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 25);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(642, 55);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(66, 25);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Go";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // ModifyBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 396);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.txtCardNo);
            this.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifyBorrower";
            this.Text = "Modify  Borrower";
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgBorrower;
    }
}