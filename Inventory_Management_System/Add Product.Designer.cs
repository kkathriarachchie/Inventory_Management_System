namespace Inventory_Management_System
{
    partial class Add_Product
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
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.txt_supplierName = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.lbl_supplierPhone_number = new System.Windows.Forms.Label();
            this.txt_supplierPhone_number = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(33, 34);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(267, 22);
            this.txt_productName.TabIndex = 0;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(30, 18);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(79, 13);
            this.lbl_productName.TabIndex = 1;
            this.lbl_productName.Text = "Product Name";
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.Location = new System.Drawing.Point(30, 67);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(130, 13);
            this.lbl_unitPrice.TabIndex = 3;
            this.lbl_unitPrice.Text = "Unit Price (Per Kg / L )    ";
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Location = new System.Drawing.Point(33, 83);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(267, 22);
            this.txt_unitPrice.TabIndex = 2;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(30, 118);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(50, 13);
            this.lbl_quantity.TabIndex = 5;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(33, 134);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(267, 22);
            this.txt_quantity.TabIndex = 4;
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(30, 171);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(82, 13);
            this.lbl_supplierName.TabIndex = 7;
            this.lbl_supplierName.Text = "Supplier Name";
            // 
            // txt_supplierName
            // 
            this.txt_supplierName.Location = new System.Drawing.Point(33, 187);
            this.txt_supplierName.Name = "txt_supplierName";
            this.txt_supplierName.Size = new System.Drawing.Size(267, 22);
            this.txt_supplierName.TabIndex = 6;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(33, 283);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(267, 23);
            this.btn_addProduct.TabIndex = 10;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // lbl_supplierPhone_number
            // 
            this.lbl_supplierPhone_number.AutoSize = true;
            this.lbl_supplierPhone_number.Location = new System.Drawing.Point(30, 222);
            this.lbl_supplierPhone_number.Name = "lbl_supplierPhone_number";
            this.lbl_supplierPhone_number.Size = new System.Drawing.Size(127, 13);
            this.lbl_supplierPhone_number.TabIndex = 12;
            this.lbl_supplierPhone_number.Text = "Supplier Phone Number";
            // 
            // txt_supplierPhone_number
            // 
            this.txt_supplierPhone_number.Location = new System.Drawing.Point(33, 238);
            this.txt_supplierPhone_number.Name = "txt_supplierPhone_number";
            this.txt_supplierPhone_number.Size = new System.Drawing.Size(267, 22);
            this.txt_supplierPhone_number.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_supplierPhone_number);
            this.groupBox1.Controls.Add(this.lbl_supplierPhone_number);
            this.groupBox1.Controls.Add(this.txt_productName);
            this.groupBox1.Controls.Add(this.lbl_productName);
            this.groupBox1.Controls.Add(this.btn_addProduct);
            this.groupBox1.Controls.Add(this.txt_unitPrice);
            this.groupBox1.Controls.Add(this.lbl_supplierName);
            this.groupBox1.Controls.Add(this.lbl_unitPrice);
            this.groupBox1.Controls.Add(this.txt_supplierName);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.lbl_quantity);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 340);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 402);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.TextBox txt_unitPrice;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.TextBox txt_supplierName;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label lbl_supplierPhone_number;
        private System.Windows.Forms.TextBox txt_supplierPhone_number;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}