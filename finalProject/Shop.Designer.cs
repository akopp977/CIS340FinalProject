namespace finalProject
{
    partial class Shop
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
            this.dgv_ShopProducts = new System.Windows.Forms.DataGridView();
            this.dgv_txt_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PreCheckout = new System.Windows.Forms.DataGridView();
            this.quantityToBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productToBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PreCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ShopProducts
            // 
            this.dgv_ShopProducts.AllowUserToAddRows = false;
            this.dgv_ShopProducts.AllowUserToDeleteRows = false;
            this.dgv_ShopProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShopProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_txt_Quantity});
            this.dgv_ShopProducts.Location = new System.Drawing.Point(10, 72);
            this.dgv_ShopProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ShopProducts.Name = "dgv_ShopProducts";
            this.dgv_ShopProducts.RowHeadersWidth = 51;
            this.dgv_ShopProducts.RowTemplate.Height = 29;
            this.dgv_ShopProducts.Size = new System.Drawing.Size(645, 297);
            this.dgv_ShopProducts.TabIndex = 0;
            this.dgv_ShopProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ShopProducts_CellContentClick);
            // 
            // dgv_txt_Quantity
            // 
            this.dgv_txt_Quantity.HeaderText = "Quantity";
            this.dgv_txt_Quantity.MinimumWidth = 6;
            this.dgv_txt_Quantity.Name = "dgv_txt_Quantity";
            this.dgv_txt_Quantity.Width = 125;
            // 
            // dgv_PreCheckout
            // 
            this.dgv_PreCheckout.AllowUserToAddRows = false;
            this.dgv_PreCheckout.AllowUserToDeleteRows = false;
            this.dgv_PreCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PreCheckout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantityToBuy,
            this.productToBuy});
            this.dgv_PreCheckout.Location = new System.Drawing.Point(661, 72);
            this.dgv_PreCheckout.Name = "dgv_PreCheckout";
            this.dgv_PreCheckout.ReadOnly = true;
            this.dgv_PreCheckout.RowHeadersWidth = 51;
            this.dgv_PreCheckout.RowTemplate.Height = 25;
            this.dgv_PreCheckout.Size = new System.Drawing.Size(337, 297);
            this.dgv_PreCheckout.TabIndex = 3;
            this.dgv_PreCheckout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PreCheckout_CellContentClick);
            // 
            // quantityToBuy
            // 
            this.quantityToBuy.HeaderText = "Quantity";
            this.quantityToBuy.MinimumWidth = 6;
            this.quantityToBuy.Name = "quantityToBuy";
            this.quantityToBuy.ReadOnly = true;
            this.quantityToBuy.Width = 125;
            // 
            // productToBuy
            // 
            this.productToBuy.HeaderText = "Product";
            this.productToBuy.MinimumWidth = 6;
            this.productToBuy.Name = "productToBuy";
            this.productToBuy.ReadOnly = true;
            this.productToBuy.Width = 125;
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Location = new System.Drawing.Point(886, 45);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(75, 23);
            this.btn_Purchase.TabIndex = 5;
            this.btn_Purchase.Text = "Purchase";
            this.btn_Purchase.UseVisualStyleBackColor = true;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(502, 40);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(151, 23);
            this.txt_Search.TabIndex = 6;
            this.txt_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(433, 45);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(63, 15);
            this.lbl_Search.TabIndex = 8;
            this.lbl_Search.Text = "Search for:";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 378);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Purchase);
            this.Controls.Add(this.dgv_PreCheckout);
            this.Controls.Add(this.dgv_ShopProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PreCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ShopProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_txt_Quantity;
        private System.Windows.Forms.DataGridView dgv_PreCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityToBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn productToBuy;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}