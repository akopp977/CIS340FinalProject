
namespace finalProject
{
    partial class ShopEasy
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Welcome_Box = new System.Windows.Forms.Label();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.lbl_WhatYWD = new System.Windows.Forms.Label();
            this.cmbo_WhatToDo = new System.Windows.Forms.ComboBox();
            this.btn_DoAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "ShopEasy";
            // 
            // lbl_Welcome_Box
            // 
            this.lbl_Welcome_Box.AutoSize = true;
            this.lbl_Welcome_Box.Location = new System.Drawing.Point(12, 9);
            this.lbl_Welcome_Box.Name = "lbl_Welcome_Box";
            this.lbl_Welcome_Box.Size = new System.Drawing.Size(112, 15);
            this.lbl_Welcome_Box.TabIndex = 2;
            this.lbl_Welcome_Box.Text = "Welcome username";
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Location = new System.Drawing.Point(12, 27);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(75, 23);
            this.btn_SignOut.TabIndex = 3;
            this.btn_SignOut.Text = "Sign Out";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // lbl_WhatYWD
            // 
            this.lbl_WhatYWD.AutoSize = true;
            this.lbl_WhatYWD.Location = new System.Drawing.Point(9, 94);
            this.lbl_WhatYWD.Name = "lbl_WhatYWD";
            this.lbl_WhatYWD.Size = new System.Drawing.Size(151, 15);
            this.lbl_WhatYWD.TabIndex = 4;
            this.lbl_WhatYWD.Text = "What would you like to do?";
            // 
            // cmbo_WhatToDo
            // 
            this.cmbo_WhatToDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_WhatToDo.FormattingEnabled = true;
            this.cmbo_WhatToDo.Location = new System.Drawing.Point(181, 92);
            this.cmbo_WhatToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbo_WhatToDo.Name = "cmbo_WhatToDo";
            this.cmbo_WhatToDo.Size = new System.Drawing.Size(168, 23);
            this.cmbo_WhatToDo.TabIndex = 5;
            this.cmbo_WhatToDo.SelectedIndexChanged += new System.EventHandler(this.cmbo_WhatToDo_SelectedIndexChanged);
            // 
            // btn_DoAction
            // 
            this.btn_DoAction.Location = new System.Drawing.Point(354, 94);
            this.btn_DoAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoAction.Name = "btn_DoAction";
            this.btn_DoAction.Size = new System.Drawing.Size(82, 22);
            this.btn_DoAction.TabIndex = 6;
            this.btn_DoAction.Text = "Go";
            this.btn_DoAction.UseVisualStyleBackColor = true;
            this.btn_DoAction.Visible = false;
            this.btn_DoAction.Click += new System.EventHandler(this.btn_DoAction_Click);
            // 
            // ShopEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 137);
            this.Controls.Add(this.btn_DoAction);
            this.Controls.Add(this.cmbo_WhatToDo);
            this.Controls.Add(this.lbl_WhatYWD);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.lbl_Welcome_Box);
            this.Controls.Add(this.label1);
            this.Name = "ShopEasy";
            this.Text = "ShopEasy";
            this.Load += new System.EventHandler(this.ShopEasy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Welcome_Box;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Label lbl_WhatYWD;
        private System.Windows.Forms.ComboBox cmbo_WhatToDo;
        private System.Windows.Forms.Button btn_DoAction;
    }
}