namespace finalProject
{
    partial class Invoices
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
            this.dgv_Transations = new System.Windows.Forms.DataGridView();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTransaction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tranID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_TransactionItems = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbo_amountOfMonths = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransactionItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Transations
            // 
            this.dgv_Transations.AllowUserToAddRows = false;
            this.dgv_Transations.AllowUserToDeleteRows = false;
            this.dgv_Transations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.Total,
            this.viewTransaction,
            this.tranID,
            this.Username});
            this.dgv_Transations.Location = new System.Drawing.Point(15, 61);
            this.dgv_Transations.Name = "dgv_Transations";
            this.dgv_Transations.ReadOnly = true;
            this.dgv_Transations.RowTemplate.Height = 25;
            this.dgv_Transations.Size = new System.Drawing.Size(369, 292);
            this.dgv_Transations.TabIndex = 0;
            this.dgv_Transations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Transations_CellContentClick);
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Date/Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total $";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // viewTransaction
            // 
            this.viewTransaction.HeaderText = "";
            this.viewTransaction.Name = "viewTransaction";
            this.viewTransaction.ReadOnly = true;
            this.viewTransaction.Text = "View";
            this.viewTransaction.UseColumnTextForButtonValue = true;
            // 
            // tranID
            // 
            this.tranID.HeaderText = "tranID";
            this.tranID.Name = "tranID";
            this.tranID.ReadOnly = true;
            this.tranID.Visible = false;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Visible = false;
            // 
            // dgv_TransactionItems
            // 
            this.dgv_TransactionItems.AllowUserToAddRows = false;
            this.dgv_TransactionItems.AllowUserToDeleteRows = false;
            this.dgv_TransactionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransactionItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.Price,
            this.Quantity});
            this.dgv_TransactionItems.Location = new System.Drawing.Point(407, 61);
            this.dgv_TransactionItems.Name = "dgv_TransactionItems";
            this.dgv_TransactionItems.ReadOnly = true;
            this.dgv_TransactionItems.RowTemplate.Height = 25;
            this.dgv_TransactionItems.Size = new System.Drawing.Size(355, 292);
            this.dgv_TransactionItems.TabIndex = 1;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "View invoices from last";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select a invoice to view its items";
            // 
            // cmbo_amountOfMonths
            // 
            this.cmbo_amountOfMonths.FormattingEnabled = true;
            this.cmbo_amountOfMonths.Location = new System.Drawing.Point(146, 15);
            this.cmbo_amountOfMonths.Name = "cmbo_amountOfMonths";
            this.cmbo_amountOfMonths.Size = new System.Drawing.Size(167, 23);
            this.cmbo_amountOfMonths.TabIndex = 7;
            this.cmbo_amountOfMonths.SelectedIndexChanged += new System.EventHandler(this.cmbo_amountOfMonths_SelectedIndexChanged);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 531);
            this.Controls.Add(this.cmbo_amountOfMonths);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_TransactionItems);
            this.Controls.Add(this.dgv_Transations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Invoices";
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransactionItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Transations;
        private System.Windows.Forms.DataGridView dgv_TransactionItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn viewTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbo_amountOfMonths;
    }
}