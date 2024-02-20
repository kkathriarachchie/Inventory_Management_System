namespace Inventory_Management_System
{
    partial class Dashboard
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
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_updateProduct = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.btn_getReport = new System.Windows.Forms.Button();
            this.dtg_product = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_inv_total = new System.Windows.Forms.Label();
            this.lbl_item_quan = new System.Windows.Forms.Label();
            this.gb_inveInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_product)).BeginInit();
            this.gb_inveInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.Location = new System.Drawing.Point(28, 320);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(243, 42);
            this.btn_addProduct.TabIndex = 0;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_updateProduct
            // 
            this.btn_updateProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateProduct.Location = new System.Drawing.Point(286, 320);
            this.btn_updateProduct.Name = "btn_updateProduct";
            this.btn_updateProduct.Size = new System.Drawing.Size(243, 42);
            this.btn_updateProduct.TabIndex = 1;
            this.btn_updateProduct.Text = "Update Product";
            this.btn_updateProduct.UseVisualStyleBackColor = true;
            this.btn_updateProduct.Click += new System.EventHandler(this.btn_updateProduct_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProduct.Location = new System.Drawing.Point(544, 320);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(243, 42);
            this.btn_deleteProduct.TabIndex = 2;
            this.btn_deleteProduct.Text = "Delete Product";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // btn_getReport
            // 
            this.btn_getReport.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getReport.Location = new System.Drawing.Point(655, 36);
            this.btn_getReport.Name = "btn_getReport";
            this.btn_getReport.Size = new System.Drawing.Size(131, 23);
            this.btn_getReport.TabIndex = 3;
            this.btn_getReport.Text = "Get Report";
            this.btn_getReport.UseVisualStyleBackColor = true;
            this.btn_getReport.Click += new System.EventHandler(this.btn_getReport_Click);
            // 
            // dtg_product
            // 
            this.dtg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_product.Location = new System.Drawing.Point(27, 65);
            this.dtg_product.Name = "dtg_product";
            this.dtg_product.Size = new System.Drawing.Size(759, 234);
            this.dtg_product.TabIndex = 4;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(118, 38);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(394, 22);
            this.txt_search.TabIndex = 5;
            this.txt_search.Tag = "";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(518, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(131, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search 🔎";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(27, 35);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(85, 23);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Sync 🗘 ";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_inv_total
            // 
            this.lbl_inv_total.AutoSize = true;
            this.lbl_inv_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inv_total.Location = new System.Drawing.Point(17, 43);
            this.lbl_inv_total.Name = "lbl_inv_total";
            this.lbl_inv_total.Size = new System.Drawing.Size(127, 21);
            this.lbl_inv_total.TabIndex = 8;
            this.lbl_inv_total.Text = "Inventory Total";
            // 
            // lbl_item_quan
            // 
            this.lbl_item_quan.AutoSize = true;
            this.lbl_item_quan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_quan.Location = new System.Drawing.Point(17, 79);
            this.lbl_item_quan.Name = "lbl_item_quan";
            this.lbl_item_quan.Size = new System.Drawing.Size(158, 21);
            this.lbl_item_quan.TabIndex = 9;
            this.lbl_item_quan.Text = "Total Item Quantity";
            // 
            // gb_inveInfo
            // 
            this.gb_inveInfo.Controls.Add(this.lbl_item_quan);
            this.gb_inveInfo.Controls.Add(this.lbl_inv_total);
            this.gb_inveInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_inveInfo.Location = new System.Drawing.Point(38, 451);
            this.gb_inveInfo.Name = "gb_inveInfo";
            this.gb_inveInfo.Size = new System.Drawing.Size(823, 121);
            this.gb_inveInfo.TabIndex = 10;
            this.gb_inveInfo.TabStop = false;
            this.gb_inveInfo.Text = "Inventory Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_addProduct);
            this.groupBox1.Controls.Add(this.btn_updateProduct);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.btn_deleteProduct);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.btn_getReport);
            this.groupBox1.Controls.Add(this.dtg_product);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 395);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_inveInfo);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_product)).EndInit();
            this.gb_inveInfo.ResumeLayout(false);
            this.gb_inveInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_updateProduct;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Button btn_getReport;
        private System.Windows.Forms.DataGridView dtg_product;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_inv_total;
        private System.Windows.Forms.Label lbl_item_quan;
        private System.Windows.Forms.GroupBox gb_inveInfo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}