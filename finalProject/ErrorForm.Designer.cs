
namespace finalProject
{
    partial class ErrorForm
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
            this.rtxt_ErrorMessage = new System.Windows.Forms.RichTextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_ErrorMessage
            // 
            this.rtxt_ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_ErrorMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxt_ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxt_ErrorMessage.Location = new System.Drawing.Point(12, 12);
            this.rtxt_ErrorMessage.Name = "rtxt_ErrorMessage";
            this.rtxt_ErrorMessage.ReadOnly = true;
            this.rtxt_ErrorMessage.Size = new System.Drawing.Size(390, 140);
            this.rtxt_ErrorMessage.TabIndex = 0;
            this.rtxt_ErrorMessage.Text = "";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(174, 158);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 24);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 192);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.rtxt_ErrorMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_ErrorMessage;
        private System.Windows.Forms.Button btn_Ok;
    }
}