namespace QLTHUVIEN
{
    partial class Muon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.madg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timkiem = new System.Windows.Forms.Button();
            this.qltimkiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtngaytra = new System.Windows.Forms.DateTimePicker();
            this.mtngayhen = new System.Windows.Forms.DateTimePicker();
            this.mtngaymuon = new System.Windows.Forms.DateTimePicker();
            this.mtxoa = new System.Windows.Forms.Button();
            this.mtsua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtsoluon = new System.Windows.Forms.TextBox();
            this.mtmasach = new System.Windows.Forms.TextBox();
            this.mtmadg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madg,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(373, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 379);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // madg
            // 
            this.madg.DataPropertyName = "madg";
            this.madg.HeaderText = "madg";
            this.madg.MinimumWidth = 6;
            this.madg.Name = "madg";
            this.madg.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "masach";
            this.Column2.HeaderText = "Mã Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngaymuon";
            this.Column3.HeaderText = "Ngày Mượn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soluong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngayhentra";
            this.Column5.HeaderText = "Ngày Hẹn Trả";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngaytra";
            this.Column6.HeaderText = "Ngày Trả";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.timkiem);
            this.panel2.Controls.Add(this.qltimkiem);
            this.panel2.Location = new System.Drawing.Point(373, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 95);
            this.panel2.TabIndex = 4;
            // 
            // timkiem
            // 
            this.timkiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(20, 21);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(113, 42);
            this.timkiem.TabIndex = 2;
            this.timkiem.Text = "Tìm Kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // qltimkiem
            // 
            this.qltimkiem.Location = new System.Drawing.Point(180, 26);
            this.qltimkiem.Name = "qltimkiem";
            this.qltimkiem.Size = new System.Drawing.Size(695, 22);
            this.qltimkiem.TabIndex = 1;
            this.qltimkiem.TextChanged += new System.EventHandler(this.qltimkiem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.mtngaytra);
            this.panel1.Controls.Add(this.mtngayhen);
            this.panel1.Controls.Add(this.mtngaymuon);
            this.panel1.Controls.Add(this.mtxoa);
            this.panel1.Controls.Add(this.mtsua);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mtsoluon);
            this.panel1.Controls.Add(this.mtmasach);
            this.panel1.Controls.Add(this.mtmadg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 484);
            this.panel1.TabIndex = 3;
            // 
            // mtngaytra
            // 
            this.mtngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mtngaytra.Location = new System.Drawing.Point(140, 343);
            this.mtngaytra.Name = "mtngaytra";
            this.mtngaytra.Size = new System.Drawing.Size(200, 22);
            this.mtngaytra.TabIndex = 6;
            // 
            // mtngayhen
            // 
            this.mtngayhen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mtngayhen.Location = new System.Drawing.Point(131, 263);
            this.mtngayhen.Name = "mtngayhen";
            this.mtngayhen.Size = new System.Drawing.Size(200, 22);
            this.mtngayhen.TabIndex = 5;
            // 
            // mtngaymuon
            // 
            this.mtngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mtngaymuon.Location = new System.Drawing.Point(131, 135);
            this.mtngaymuon.Name = "mtngaymuon";
            this.mtngaymuon.Size = new System.Drawing.Size(200, 22);
            this.mtngaymuon.TabIndex = 4;
            // 
            // mtxoa
            // 
            this.mtxoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxoa.Location = new System.Drawing.Point(245, 420);
            this.mtxoa.Name = "mtxoa";
            this.mtxoa.Size = new System.Drawing.Size(75, 32);
            this.mtxoa.TabIndex = 2;
            this.mtxoa.Text = "Xóa";
            this.mtxoa.UseVisualStyleBackColor = true;
            this.mtxoa.Click += new System.EventHandler(this.mtxoa_Click);
            // 
            // mtsua
            // 
            this.mtsua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtsua.Location = new System.Drawing.Point(131, 420);
            this.mtsua.Name = "mtsua";
            this.mtsua.Size = new System.Drawing.Size(75, 32);
            this.mtsua.TabIndex = 2;
            this.mtsua.Text = "Sửa";
            this.mtsua.UseVisualStyleBackColor = true;
            this.mtsua.Click += new System.EventHandler(this.mtsua_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtsoluon
            // 
            this.mtsoluon.Location = new System.Drawing.Point(122, 197);
            this.mtsoluon.Name = "mtsoluon";
            this.mtsoluon.Size = new System.Drawing.Size(225, 22);
            this.mtsoluon.TabIndex = 1;
            // 
            // mtmasach
            // 
            this.mtmasach.Location = new System.Drawing.Point(122, 78);
            this.mtmasach.Name = "mtmasach";
            this.mtmasach.Size = new System.Drawing.Size(225, 22);
            this.mtmasach.TabIndex = 1;
            // 
            // mtmadg
            // 
            this.mtmadg.Location = new System.Drawing.Point(122, 27);
            this.mtmadg.Name = "mtmadg";
            this.mtmadg.Size = new System.Drawing.Size(225, 22);
            this.mtmadg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Độc Gỉa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Hẹn Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // Muon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Muon";
            this.Text = "MượnTrả";
            this.Load += new System.EventHandler(this.Muon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn madg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.TextBox qltimkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker mtngaytra;
        private System.Windows.Forms.DateTimePicker mtngayhen;
        private System.Windows.Forms.DateTimePicker mtngaymuon;
        private System.Windows.Forms.Button mtxoa;
        private System.Windows.Forms.Button mtsua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mtsoluon;
        private System.Windows.Forms.TextBox mtmasach;
        private System.Windows.Forms.TextBox mtmadg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}