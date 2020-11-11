using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTHUVIEN
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection (@"Data Source=DESKTOP-5SRTCNL\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");

        private void dangnhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            string DANGNHAP = "select * from taikhoan where taikhoana = '" + txttk.Text + "'AND matkhau  = '" + mk.Text + "'";
            SqlCommand cmd = new SqlCommand(DANGNHAP, conn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == true)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công");
                admin a = new admin();
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                conn.Close();
            }
            
        }


        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
