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
    public partial class DOIMKcs : Form
    {
        public DOIMKcs()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5SRTCNL\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
        private void DOIMKcs_Load(object sender, EventArgs e)
        {
            conn.Open();
            string TruyVan = "select * from   taikhoan where matkhau ='" + txtmkcu.Text + "'";
            SqlCommand cmd = new SqlCommand(TruyVan, conn);
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read() == true)
            {
                conn.Close();
                conn.Open();
                string Sua = " update taikhoan  set matkhau = N'" + txtmatkhaumoi.Text + "'";
                SqlCommand cmd1 = new SqlCommand(Sua, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(" Bạn Đã Đổi Mật Khẩu Thành Công");
                this.Close();
            }
            else
            {
                MessageBox.Show(" Mật Khẩu  Cũ Chưa Chính Xác ! ");
                conn.Close();
            }
        }
    }
}
