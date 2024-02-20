namespace Inventory_Management_System
{
    partial class Update_Product
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
            this.btn_updateProduct = new System.Windows.Forms.Button();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.txt_productQuantity = new System.Windows.Forms.TextBox();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.lbl_productQuantity = new System.Windows.Forms.Label();
            this.lbl_productId = new System.Windows.Forms.Label();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.btn_Increase = new System.Windows.Forms.Button();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_supplierPhone_number = new System.Windows.Forms.TextBox();
            this.lbl_supplierPhone_number = new System.Windows.Forms.Label();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.txt_supplierName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_updateProduct
            // 
            this.btn_updateProduct.Location = new System.Drawing.Point(488, 193);
            this.btn_updateProduct.Name = "btn_updateProduct";
            this.btn_updateProduct.Size = new System.Drawing.Size(441, 42);
            this.btn_updateProduct.TabIndex = 0;
            this.btn_updateProduct.Text = "Update Product";
            this.btn_updateProduct.UseVisualStyleBackColor = true;
            this.btn_updateProduct.Click += new System.EventHandler(this.btn_updateProduct_Click);
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(24, 111);
            this.txt_productName.Multiline = true;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(386, 20);
            this.txt_productName.TabIndex = 1;
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Location = new System.Drawing.Point(24, 164);
            this.txt_unitPrice.Multiline = true;
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(386, 20);
            this.txt_unitPrice.TabIndex = 2;
            // 
            // txt_productQuantity
            // 
            this.txt_productQuantity.Location = new System.Drawing.Point(24, 220);
            this.txt_productQuantity.Multiline = true;
            this.txt_productQuantity.Name = "txt_productQuantity";
            this.txt_productQuantity.Size = new System.Drawing.Size(341, 20);
            this.txt_productQuantity.TabIndex = 3;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(21, 95);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(79, 13);
            this.lbl_productName.TabIndex = 4;
            this.lbl_productName.Text = "Product Name";
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.Location = new System.Drawing.Point(21, 148);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(115, 13);
            this.lbl_unitPrice.TabIndex = 5;
            this.lbl_unitPrice.Text = "Unit Price (Per Kg / L)";
            // 
            // lbl_productQuantity
            // 
            this.lbl_productQuantity.AutoSize = true;
            this.lbl_productQuantity.Location = new System.Drawing.Point(21, 204);
            this.lbl_productQuantity.Name = "lbl_productQuantity";
            this.lbl_productQuantity.Size = new System.Drawing.Size(92, 13);
            this.lbl_productQuantity.TabIndex = 6;
            this.lbl_productQuantity.Text = "Product Quantity";
            // 
            // lbl_productId
            // 
            this.lbl_productId.AutoSize = true;
            this.lbl_productId.Location = new System.Drawing.Point(21, 37);
            this.lbl_productId.Name = "lbl_productId";
            this.lbl_productId.Size = new System.Drawing.Size(60, 13);
            this.lbl_productId.TabIndex = 8;
            this.lbl_productId.Text = "Product ID";
            // 
            // txt_productId
            // 
            this.txt_productId.Location = new System.Drawing.Point(24, 53);
            this.txt_productId.Multiline = true;
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(386, 20);
            this.txt_productId.TabIndex = 7;
            // 
            // btn_Increase
            // 
            this.btn_Increase.Location = new System.Drawing.Point(367, 211);
            this.btn_Increase.Name = "btn_Increase";
            this.btn_Increase.Size = new System.Drawing.Size(37, 19);
            this.btn_Increase.TabIndex = 9;
            this.btn_Increase.Text = "▲";
            this.btn_Increase.UseVisualStyleBackColor = true;
            this.btn_Increase.Click += new System.EventHandler(this.btn_Increase_Click);
            // 
            // btn_decrease
            // 
            this.btn_decrease.Location = new System.Drawing.Point(367, 230);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(37, 19);
            this.btn_decrease.TabIndex = 10;
            this.btn_decrease.Text = "▼";
            this.btn_decrease.UseVisualStyleBackColor = true;
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_productId);
            this.groupBox1.Controls.Add(this.btn_decrease);
            this.groupBox1.Controls.Add(this.btn_Increase);
            this.groupBox1.Controls.Add(this.txt_productName);
            this.groupBox1.Controls.Add(this.lbl_productId);
            this.groupBox1.Controls.Add(this.txt_unitPrice);
            this.groupBox1.Controls.Add(this.txt_productQuantity);
            this.groupBox1.Controls.Add(this.lbl_productQuantity);
            this.groupBox1.Controls.Add(this.lbl_productName);
            this.groupBox1.Controls.Add(this.lbl_unitPrice);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 284);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_supplierPhone_number);
            this.groupBox2.Controls.Add(this.lbl_supplierPhone_number);
            this.groupBox2.Controls.Add(this.lbl_supplierName);
            this.groupBox2.Controls.Add(this.txt_supplierName);
            this.groupBox2.Location = new System.Drawing.Point(488, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 152);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier Details";
            // 
            // txt_supplierPhone_number
            // 
            this.txt_supplierPhone_number.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplierPhone_number.Location = new System.Drawing.Point(24, 102);
            this.txt_supplierPhone_number.Name = "txt_supplierPhone_number";
            this.txt_supplierPhone_number.Size = new System.Drawing.Size(386, 22);
            this.txt_supplierPhone_number.TabIndex = 15;
            // 
            // lbl_supplierPhone_number
            // 
            this.lbl_supplierPhone_number.AutoSize = true;
            this.lbl_supplierPhone_number.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplierPhone_number.Location = new System.Drawing.Point(23, 86);
            this.lbl_supplierPhone_number.Name = "lbl_supplierPhone_number";
            this.lbl_supplierPhone_number.Size = new System.Drawing.Size(127, 13);
            this.lbl_supplierPhone_number.TabIndex = 16;
            this.lbl_supplierPhone_number.Text = "Supplier Phone Number";
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplierName.Location = new System.Drawing.Point(23, 35);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(82, 13);
            this.lbl_supplierName.TabIndex = 14;
            this.lbl_supplierName.Text = "Supplier Name";
            // 
            // txt_supplierName
            // 
            this.txt_supplierName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplierName.Location = new System.Drawing.Point(24, 51);
            this.txt_supplierName.Name = "txt_supplierName";
            this.txt_supplierName.Size = new System.Drawing.Size(386, 22);
            this.txt_supplierName.TabIndex = 13;
            // 
            // Update_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_updateProduct);
            this.Name = "Update_Product";
            this.Text = "Update_Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_updateProduct;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.Label lbl_productQuantity;
        public System.Windows.Forms.TextBox txt_productName;
        public System.Windows.Forms.TextBox txt_unitPrice;
        public System.Windows.Forms.TextBox txt_productQuantity;
        private System.Windows.Forms.Label lbl_productId;
        public System.Windows.Forms.TextBox txt_productId;
        private System.Windows.Forms.Button btn_Increase;
        private System.Windows.Forms.Button btn_decrease;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_supplierPhone_number;
        private System.Windows.Forms.Label lbl_supplierPhone_number;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.TextBox txt_supplierName;
    }
}