namespace finalProject
{
    partial class EditDBForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbo_TableToEdit = new System.Windows.Forms.ComboBox();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_EditTable = new System.Windows.Forms.Button();
            this.cmbo_ChooseCRUD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_column1 = new System.Windows.Forms.TextBox();
            this.lbl_Column1 = new System.Windows.Forms.Label();
            this.lbl_Column2 = new System.Windows.Forms.Label();
            this.txt_column2 = new System.Windows.Forms.TextBox();
            this.lbl_Column4 = new System.Windows.Forms.Label();
            this.txt_column4 = new System.Windows.Forms.TextBox();
            this.lbl_Column3 = new System.Windows.Forms.Label();
            this.txt_column3 = new System.Windows.Forms.TextBox();
            this.lbl_Column6 = new System.Windows.Forms.Label();
            this.txt_column6 = new System.Windows.Forms.TextBox();
            this.lbl_Column5 = new System.Windows.Forms.Label();
            this.txt_column5 = new System.Windows.Forms.TextBox();
            this.lbl_Column7 = new System.Windows.Forms.Label();
            this.txt_column7 = new System.Windows.Forms.TextBox();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.btn_Find = new System.Windows.Forms.Button();
            this.lbl_FindNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would you like to do?";
            // 
            // cmbo_TableToEdit
            // 
            this.cmbo_TableToEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_TableToEdit.FormattingEnabled = true;
            this.cmbo_TableToEdit.Items.AddRange(new object[] {
            "Customers",
            "Customer Types",
            "Logins",
            "Products",
            "Product Types"});
            this.cmbo_TableToEdit.Location = new System.Drawing.Point(178, 35);
            this.cmbo_TableToEdit.Name = "cmbo_TableToEdit";
            this.cmbo_TableToEdit.Size = new System.Drawing.Size(162, 23);
            this.cmbo_TableToEdit.TabIndex = 1;
            this.cmbo_TableToEdit.SelectedIndexChanged += new System.EventHandler(this.cmbo_TableToEdit_SelectedIndexChanged);
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataSource = typeof(finalProject.Models.DataLayer.Logins);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(finalProject.Models.DataLayer.Products);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(finalProject.Models.DataLayer.Customers);
            // 
            // btn_EditTable
            // 
            this.btn_EditTable.Location = new System.Drawing.Point(862, 116);
            this.btn_EditTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditTable.Name = "btn_EditTable";
            this.btn_EditTable.Size = new System.Drawing.Size(82, 22);
            this.btn_EditTable.TabIndex = 5;
            this.btn_EditTable.Text = "Go";
            this.btn_EditTable.UseVisualStyleBackColor = true;
            this.btn_EditTable.Visible = false;
            this.btn_EditTable.Click += new System.EventHandler(this.btn_EditTable_Click);
            // 
            // cmbo_ChooseCRUD
            // 
            this.cmbo_ChooseCRUD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_ChooseCRUD.FormattingEnabled = true;
            this.cmbo_ChooseCRUD.Items.AddRange(new object[] {
            "View",
            "Create new",
            "Edit existing",
            "Delete existing"});
            this.cmbo_ChooseCRUD.Location = new System.Drawing.Point(178, 6);
            this.cmbo_ChooseCRUD.Name = "cmbo_ChooseCRUD";
            this.cmbo_ChooseCRUD.Size = new System.Drawing.Size(162, 23);
            this.cmbo_ChooseCRUD.TabIndex = 6;
            this.cmbo_ChooseCRUD.SelectedIndexChanged += new System.EventHandler(this.cmbo_ChooseCRUD_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "On what table?";
            // 
            // txt_column1
            // 
            this.txt_column1.Location = new System.Drawing.Point(112, 82);
            this.txt_column1.Name = "txt_column1";
            this.txt_column1.Size = new System.Drawing.Size(127, 23);
            this.txt_column1.TabIndex = 8;
            this.txt_column1.Visible = false;
            // 
            // lbl_Column1
            // 
            this.lbl_Column1.AutoSize = true;
            this.lbl_Column1.Location = new System.Drawing.Point(2, 85);
            this.lbl_Column1.Name = "lbl_Column1";
            this.lbl_Column1.Size = new System.Drawing.Size(38, 15);
            this.lbl_Column1.TabIndex = 9;
            this.lbl_Column1.Text = "label3";
            this.lbl_Column1.Visible = false;
            // 
            // lbl_Column2
            // 
            this.lbl_Column2.AutoSize = true;
            this.lbl_Column2.Location = new System.Drawing.Point(2, 114);
            this.lbl_Column2.Name = "lbl_Column2";
            this.lbl_Column2.Size = new System.Drawing.Size(38, 15);
            this.lbl_Column2.TabIndex = 11;
            this.lbl_Column2.Text = "label4";
            this.lbl_Column2.Visible = false;
            // 
            // txt_column2
            // 
            this.txt_column2.Location = new System.Drawing.Point(112, 111);
            this.txt_column2.Name = "txt_column2";
            this.txt_column2.Size = new System.Drawing.Size(127, 23);
            this.txt_column2.TabIndex = 10;
            this.txt_column2.Visible = false;
            // 
            // lbl_Column4
            // 
            this.lbl_Column4.AutoSize = true;
            this.lbl_Column4.Location = new System.Drawing.Point(241, 114);
            this.lbl_Column4.Name = "lbl_Column4";
            this.lbl_Column4.Size = new System.Drawing.Size(38, 15);
            this.lbl_Column4.TabIndex = 15;
            this.lbl_Column4.Text = "label5";
            this.lbl_Column4.Visible = false;
            // 
            // txt_column4
            // 
            this.txt_column4.Location = new System.Drawing.Point(345, 109);
            this.txt_column4.Name = "txt_column4";
            this.txt_column4.Size = new System.Drawing.Size(127, 23);
            this.txt_column4.TabIndex = 14;
            this.txt_column4.Visible = false;
            // 
            // lbl_Column3
            // 
            this.lbl_Column3.AutoSize = true;
            this.lbl_Column3.Location = new System.Drawing.Point(241, 85);
            this.lbl_Column3.Name = "lbl_Column3";
            this.lbl_Column3.Size = new System.Drawing.Size(38, 15);
            this.lbl_Column3.TabIndex = 13;
            this.lbl_Column3.Text = "label6";
            this.lbl_Column3.Visible = false;
            // 
            // txt_column3
            // 
            this.txt_column3.Location = new System.Drawing.Point(345, 80);
            this.txt_column3.Name = "txt_column3";
            this.txt_column3.Size = new System.Drawing.Size(127, 23);
            this.txt_column3.TabIndex = 12;
            this.txt_column3.Visible = false;
            // 
            // lbl_Column6
            // 
            this.lbl_Column6.AutoSize = true;
            this.lbl_Column6.Location = new System.Drawing.Point(478, 112);
            this.lbl_Column6.Name = "lbl_Column6";
            this.lbl_Column6.Size = new System.Drawing.Size(38, 15);
            this.lbl_Column6.TabIndex = 19;
            this.lbl_Column6.Text = "label7";
            this.lbl_Column6.Visible = false;
            // 
            // txt_column6
            // 
            this.txt_column6.Location = new System.Drawing.Point(573, 109);
            this.txt_column6.Name = "txt_column6";
            this.txt_column6.Size = new System.Drawing.Size(127, 23);
            this.txt_column6.TabIndex = 18;
            this.txt_column6.Visible = false;
            // 
            // lbl_Column5
            // 
            this.lbl_Column5.AutoSize = true;
            this.lbl_Column5.Location = new System.Drawing.Point(478, 82);
            this.lbl_Column5.Name = "lbl_Column5";
            this.lbl_Column5.Size = new System.Drawing.Size(38, 15);
            this.lbl_Column5.TabIndex = 17;
            this.lbl_Column5.Text = "label8";
            this.lbl_Column5.Visible = false;
            // 
            // txt_column5
            // 
            this.txt_column5.Location = new System.Drawing.Point(573, 80);
            this.txt_column5.Name = "txt_column5";
            this.txt_column5.Size = new System.Drawing.Size(127, 23);
            this.txt_column5.TabIndex = 16;
            this.txt_column5.Visible = false;
            // 
            // lbl_Column7
            // 
            this.lbl_Column7.AutoSize = true;
            this.lbl_Column7.Location = new System.Drawing.Point(706, 82);
            this.lbl_Column7.Name = "lbl_Column7";
            this.lbl_Column7.Size = new System.Drawing.Size(38, 15);
            this.lbl_Column7.TabIndex = 21;
            this.lbl_Column7.Text = "label9";
            this.lbl_Column7.Visible = false;
            // 
            // txt_column7
            // 
            this.txt_column7.Location = new System.Drawing.Point(817, 80);
            this.txt_column7.Name = "txt_column7";
            this.txt_column7.Size = new System.Drawing.Size(127, 23);
            this.txt_column7.TabIndex = 20;
            this.txt_column7.Visible = false;
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(12, 140);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.RowTemplate.Height = 25;
            this.dgv_Data.Size = new System.Drawing.Size(932, 378);
            this.dgv_Data.TabIndex = 22;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(760, 116);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 24;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Visible = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // lbl_FindNotice
            // 
            this.lbl_FindNotice.AutoSize = true;
            this.lbl_FindNotice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FindNotice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_FindNotice.Location = new System.Drawing.Point(407, 9);
            this.lbl_FindNotice.Name = "lbl_FindNotice";
            this.lbl_FindNotice.Size = new System.Drawing.Size(0, 21);
            this.lbl_FindNotice.TabIndex = 25;
            this.lbl_FindNotice.Visible = false;
            // 
            // EditDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 530);
            this.Controls.Add(this.lbl_FindNotice);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.lbl_Column7);
            this.Controls.Add(this.txt_column7);
            this.Controls.Add(this.lbl_Column6);
            this.Controls.Add(this.txt_column6);
            this.Controls.Add(this.lbl_Column5);
            this.Controls.Add(this.txt_column5);
            this.Controls.Add(this.lbl_Column4);
            this.Controls.Add(this.txt_column4);
            this.Controls.Add(this.lbl_Column3);
            this.Controls.Add(this.txt_column3);
            this.Controls.Add(this.lbl_Column2);
            this.Controls.Add(this.txt_column2);
            this.Controls.Add(this.lbl_Column1);
            this.Controls.Add(this.txt_column1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_ChooseCRUD);
            this.Controls.Add(this.btn_EditTable);
            this.Controls.Add(this.cmbo_TableToEdit);
            this.Controls.Add(this.label1);
            this.Name = "EditDBForm";
            this.Text = "EditDBForm";
            this.Load += new System.EventHandler(this.EditDBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbo_TableToEdit;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Button btn_EditTable;
        private System.Windows.Forms.ComboBox cmbo_ChooseCRUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_column1;
        private System.Windows.Forms.Label lbl_Column1;
        private System.Windows.Forms.Label lbl_Column2;
        private System.Windows.Forms.TextBox txt_column2;
        private System.Windows.Forms.Label lbl_Column4;
        private System.Windows.Forms.TextBox txt_column4;
        private System.Windows.Forms.Label lbl_Column3;
        private System.Windows.Forms.TextBox txt_column3;
        private System.Windows.Forms.Label lbl_Column6;
        private System.Windows.Forms.TextBox txt_column6;
        private System.Windows.Forms.Label lbl_Column5;
        private System.Windows.Forms.TextBox txt_column5;
        private System.Windows.Forms.Label lbl_Column7;
        private System.Windows.Forms.TextBox txt_column7;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label lbl_FindNotice;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}