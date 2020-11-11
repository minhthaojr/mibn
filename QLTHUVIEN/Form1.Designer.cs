namespace QLTHUVIEN
{
    partial class login
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
            this.label2 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.mk = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(213, 92);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(371, 23);
            this.txttk.TabIndex = 1;
            // 
            // mk
            // 
            this.mk.Location = new System.Drawing.Point(213, 160);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(371, 23);
            this.mk.TabIndex = 1;
            this.mk.UseSystemPasswordChar = true;
            // 
            // dangnhap
            // 
            this.dangnhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.Location = new System.Drawing.Point(158, 243);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(142, 39);
            this.dangnhap.TabIndex = 2;
            this.dangnhap.Text = "Đăng Nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(431, 243);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(118, 39);
            this.thoat.TabIndex = 2;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "login";
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label3;
    }
}

