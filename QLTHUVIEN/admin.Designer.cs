namespace QLTHUVIEN
{
    partial class admin
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
            this.qldocgia = new System.Windows.Forms.Button();
            this.qlisach = new System.Windows.Forms.Button();
            this.muontra = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qldocgia
            // 
            this.qldocgia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qldocgia.Location = new System.Drawing.Point(66, 110);
            this.qldocgia.Name = "qldocgia";
            this.qldocgia.Size = new System.Drawing.Size(151, 102);
            this.qldocgia.TabIndex = 0;
            this.qldocgia.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.qldocgia.UseVisualStyleBackColor = true;
            this.qldocgia.Click += new System.EventHandler(this.qldocgia_Click);
            // 
            // qlisach
            // 
            this.qlisach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlisach.Location = new System.Drawing.Point(309, 110);
            this.qlisach.Name = "qlisach";
            this.qlisach.Size = new System.Drawing.Size(151, 102);
            this.qlisach.TabIndex = 0;
            this.qlisach.Text = "QUẢN LÝ SÁCH";
            this.qlisach.UseVisualStyleBackColor = true;
            this.qlisach.Click += new System.EventHandler(this.qlisach_Click);
            // 
            // muontra
            // 
            this.muontra.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muontra.Location = new System.Drawing.Point(561, 110);
            this.muontra.Name = "muontra";
            this.muontra.Size = new System.Drawing.Size(151, 102);
            this.muontra.TabIndex = 0;
            this.muontra.Text = "QUẢN LÝ MƯỢN TRẢ";
            this.muontra.UseVisualStyleBackColor = true;
            this.muontra.Click += new System.EventHandler(this.muontra_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "GIAO DIỆN CHÍNH";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTHUVIEN.Properties.Resources._4abaf352645fd2142ed6555f789e0a2e;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muontra);
            this.Controls.Add(this.qlisach);
            this.Controls.Add(this.qldocgia);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qldocgia;
        private System.Windows.Forms.Button qlisach;
        private System.Windows.Forms.Button muontra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
    }
}