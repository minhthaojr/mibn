namespace QLTHUVIEN
{
    partial class DOIMKcs
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
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtxacnhan = new System.Windows.Forms.Button();
            this.txtthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(196, 35);
            this.txtmkcu.Multiline = true;
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(340, 33);
            this.txtmkcu.TabIndex = 1;
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Location = new System.Drawing.Point(196, 111);
            this.txtmatkhaumoi.Multiline = true;
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(340, 33);
            this.txtmatkhaumoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhan.Location = new System.Drawing.Point(90, 199);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.Size = new System.Drawing.Size(103, 49);
            this.txtxacnhan.TabIndex = 2;
            this.txtxacnhan.Text = "Xác Nhận";
            this.txtxacnhan.UseVisualStyleBackColor = true;
            // 
            // txtthoat
            // 
            this.txtthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthoat.Location = new System.Drawing.Point(374, 199);
            this.txtthoat.Name = "txtthoat";
            this.txtthoat.Size = new System.Drawing.Size(103, 49);
            this.txtthoat.TabIndex = 2;
            this.txtthoat.Text = "Thoát";
            this.txtthoat.UseVisualStyleBackColor = true;
            // 
            // DOIMKcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 290);
            this.Controls.Add(this.txtthoat);
            this.Controls.Add(this.txtxacnhan);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DOIMKcs";
            this.Text = "DOIMKcs";
            this.Load += new System.EventHandler(this.DOIMKcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtxacnhan;
        private System.Windows.Forms.Button txtthoat;
    }
}