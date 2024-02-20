namespace Inventory_Management_System
{
    partial class Delete_Product
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
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.chk_delete = new System.Windows.Forms.CheckBox();
            this.lbl_productId = new System.Windows.Forms.Label();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_productName
            // 
            this.txt_productName.Enabled = false;
            this.txt_productName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.Location = new System.Drawing.Point(189, 57);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(211, 22);
            this.txt_productName.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(189, 148);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 27);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(94, 64);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(79, 13);
            this.lbl_productName.TabIndex = 2;
            this.lbl_productName.Text = "Product Name";
            // 
            // lbl_info
            // 
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(118, 93);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(306, 52);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "You are about to delete product(s) from the database. This action is irreversible" +
    " and will permanently remove associated data. Proceed only if you\'re certain.";
            // 
            // chk_delete
            // 
            this.chk_delete.AutoSize = true;
            this.chk_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_delete.Location = new System.Drawing.Point(97, 93);
            this.chk_delete.Name = "chk_delete";
            this.chk_delete.Size = new System.Drawing.Size(15, 14);
            this.chk_delete.TabIndex = 4;
            this.chk_delete.UseVisualStyleBackColor = true;
            this.chk_delete.CheckedChanged += new System.EventHandler(this.chk_delete_CheckedChanged);
            // 
            // lbl_productId
            // 
            this.lbl_productId.AutoSize = true;
            this.lbl_productId.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productId.Location = new System.Drawing.Point(94, 38);
            this.lbl_productId.Name = "lbl_productId";
            this.lbl_productId.Size = new System.Drawing.Size(59, 13);
            this.lbl_productId.TabIndex = 6;
            this.lbl_productId.Text = "Product Id";
            // 
            // txt_productId
            // 
            this.txt_productId.Enabled = false;
            this.txt_productId.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productId.Location = new System.Drawing.Point(189, 31);
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(211, 22);
            this.txt_productId.TabIndex = 5;
            // 
            // Delete_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 207);
            this.Controls.Add(this.lbl_productId);
            this.Controls.Add(this.txt_productId);
            this.Controls.Add(this.chk_delete);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_productName);
            this.Name = "Delete_Product";
            this.Text = "Delete_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.CheckBox chk_delete;
        private System.Windows.Forms.Label lbl_productId;
        private System.Windows.Forms.TextBox txt_productId;
    }
}