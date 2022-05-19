namespace finalProject
{
    partial class Checkout
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
            this.dgv_CheckoutItems = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_YourItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Taxes = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Break = new System.Windows.Forms.Label();
            this.btn_KeepShopping = new System.Windows.Forms.Button();
            this.btn_FinalCheckout = new System.Windows.Forms.Button();
            this.lbl_Discounts = new System.Windows.Forms.Label();
            this.lbl_SubtotalAmount = new System.Windows.Forms.Label();
            this.lbl_DiscountAmount = new System.Windows.Forms.Label();
            this.lbl_TaxAmount = new System.Windows.Forms.Label();
            this.lbl_TotalAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CheckoutItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CheckoutItems
            // 
            this.dgv_CheckoutItems.AllowUserToAddRows = false;
            this.dgv_CheckoutItems.AllowUserToDeleteRows = false;
            this.dgv_CheckoutItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CheckoutItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Price});
            this.dgv_CheckoutItems.Location = new System.Drawing.Point(2, 59);
            this.dgv_CheckoutItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_CheckoutItems.Name = "dgv_CheckoutItems";
            this.dgv_CheckoutItems.ReadOnly = true;
            this.dgv_CheckoutItems.RowHeadersWidth = 51;
            this.dgv_CheckoutItems.RowTemplate.Height = 29;
            this.dgv_CheckoutItems.Size = new System.Drawing.Size(484, 269);
            this.dgv_CheckoutItems.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // lbl_YourItems
            // 
            this.lbl_YourItems.AutoSize = true;
            this.lbl_YourItems.Location = new System.Drawing.Point(25, 34);
            this.lbl_YourItems.Name = "lbl_YourItems";
            this.lbl_YourItems.Size = new System.Drawing.Size(63, 15);
            this.lbl_YourItems.TabIndex = 1;
            this.lbl_YourItems.Text = "Your Items";
            this.lbl_YourItems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subtotal";
            // 
            // lbl_Taxes
            // 
            this.lbl_Taxes.AutoSize = true;
            this.lbl_Taxes.Location = new System.Drawing.Point(511, 105);
            this.lbl_Taxes.Name = "lbl_Taxes";
            this.lbl_Taxes.Size = new System.Drawing.Size(35, 15);
            this.lbl_Taxes.TabIndex = 3;
            this.lbl_Taxes.Text = "Taxes";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(509, 135);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(32, 15);
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Break
            // 
            this.lbl_Break.AutoSize = true;
            this.lbl_Break.Location = new System.Drawing.Point(509, 120);
            this.lbl_Break.Name = "lbl_Break";
            this.lbl_Break.Size = new System.Drawing.Size(197, 15);
            this.lbl_Break.TabIndex = 5;
            this.lbl_Break.Text = "--------------------------------------";
            // 
            // btn_KeepShopping
            // 
            this.btn_KeepShopping.Location = new System.Drawing.Point(511, 169);
            this.btn_KeepShopping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_KeepShopping.Name = "btn_KeepShopping";
            this.btn_KeepShopping.Size = new System.Drawing.Size(108, 22);
            this.btn_KeepShopping.TabIndex = 6;
            this.btn_KeepShopping.Text = "Keep Shopping";
            this.btn_KeepShopping.UseVisualStyleBackColor = true;
            this.btn_KeepShopping.Click += new System.EventHandler(this.btn_KeepShopping_Click);
            // 
            // btn_FinalCheckout
            // 
            this.btn_FinalCheckout.Location = new System.Drawing.Point(652, 169);
            this.btn_FinalCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FinalCheckout.Name = "btn_FinalCheckout";
            this.btn_FinalCheckout.Size = new System.Drawing.Size(82, 22);
            this.btn_FinalCheckout.TabIndex = 7;
            this.btn_FinalCheckout.Text = "Checkout";
            this.btn_FinalCheckout.UseVisualStyleBackColor = true;
            this.btn_FinalCheckout.Click += new System.EventHandler(this.btn_FinalCheckout_Click);
            // 
            // lbl_Discounts
            // 
            this.lbl_Discounts.AutoSize = true;
            this.lbl_Discounts.Location = new System.Drawing.Point(511, 82);
            this.lbl_Discounts.Name = "lbl_Discounts";
            this.lbl_Discounts.Size = new System.Drawing.Size(59, 15);
            this.lbl_Discounts.TabIndex = 8;
            this.lbl_Discounts.Text = "Discounts";
            // 
            // lbl_SubtotalAmount
            // 
            this.lbl_SubtotalAmount.AutoSize = true;
            this.lbl_SubtotalAmount.Location = new System.Drawing.Point(584, 59);
            this.lbl_SubtotalAmount.Name = "lbl_SubtotalAmount";
            this.lbl_SubtotalAmount.Size = new System.Drawing.Size(0, 15);
            this.lbl_SubtotalAmount.TabIndex = 9;
            // 
            // lbl_DiscountAmount
            // 
            this.lbl_DiscountAmount.AutoSize = true;
            this.lbl_DiscountAmount.Location = new System.Drawing.Point(584, 82);
            this.lbl_DiscountAmount.Name = "lbl_DiscountAmount";
            this.lbl_DiscountAmount.Size = new System.Drawing.Size(0, 15);
            this.lbl_DiscountAmount.TabIndex = 10;
            // 
            // lbl_TaxAmount
            // 
            this.lbl_TaxAmount.AutoSize = true;
            this.lbl_TaxAmount.Location = new System.Drawing.Point(584, 105);
            this.lbl_TaxAmount.Name = "lbl_TaxAmount";
            this.lbl_TaxAmount.Size = new System.Drawing.Size(0, 15);
            this.lbl_TaxAmount.TabIndex = 11;
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.Location = new System.Drawing.Point(584, 135);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalAmount.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TotalAmount);
            this.Controls.Add(this.lbl_TaxAmount);
            this.Controls.Add(this.lbl_DiscountAmount);
            this.Controls.Add(this.lbl_SubtotalAmount);
            this.Controls.Add(this.lbl_Discounts);
            this.Controls.Add(this.btn_FinalCheckout);
            this.Controls.Add(this.btn_KeepShopping);
            this.Controls.Add(this.lbl_Break);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Taxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_YourItems);
            this.Controls.Add(this.dgv_CheckoutItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CheckoutItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CheckoutItems;
        private System.Windows.Forms.Label lbl_YourItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Taxes;
        private System.Windows.Forms.Label lbl_Total;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label lbl_Break;
        private System.Windows.Forms.Button btn_KeepShopping;
        private System.Windows.Forms.Button btn_FinalCheckout;
        private System.Windows.Forms.Label lbl_Discounts;
        private System.Windows.Forms.Label lbl_SubtotalAmount;
        private System.Windows.Forms.Label lbl_DiscountAmount;
        private System.Windows.Forms.Label lbl_TaxAmount;
        private System.Windows.Forms.Label lbl_TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label2;
    }
}