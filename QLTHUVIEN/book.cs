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
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5SRTCNL\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
        private void hienthi()
        {
            conn.Open();
            string sqlbang = " select * from dmsach ";
            SqlCommand aaa = new SqlCommand(sqlbang, conn);
            SqlDataAdapter da = new SqlDataAdapter(aaa);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            asfsaf
        }

        private void book_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dmsachthem_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text != "" && txttensach.Text != "" && txttacgia.Text != "" && txttheloai.Text != "" && txtnamxuatban.Text != "" && txtnhaxuatban.Text != "")
            {
                conn.Open();
                string them = "insert into dmsach values ('" + txtmasach.Text + "','" + txttensach.Text + "','" + txttacgia.Text + "','" + txttheloai.Text + "','" + txtnamxuatban.Text + "','" + txtnhaxuatban.Text + "')";
                SqlCommand bbb = new SqlCommand(them, conn);
                bbb.ExecuteNonQuery();
                conn.Close();
                hienthi();
            }
            else MessageBox.Show("ban nhap thieu thong tin");
        }

        private void dmsachsua_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sua = "update  dmsach set tensach = '" + txttensach.Text + "', tacgia = '" + txttacgia.Text + "',theloai ='" + txttheloai.Text + "',namxuatban = '" + txtnamxuatban.Text + "',nhaxuatban = '" + txtnhaxuatban.Text + "' where masach = '" + txtmasach.Text + "' ";
            SqlCommand ccc = new SqlCommand(sua, conn);
            ccc.ExecuteNonQuery();
            conn.Close();
            hienthi();
        }

        private void dmsachxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string xoa = "delete dmsach where masach = '" + txtmasach.Text + "'";
            SqlCommand ddd = new SqlCommand(xoa, conn);
            ddd.ExecuteNonQuery();
            conn.Close();
            txttensach.Text = "";
            txttacgia.Text = "";
            txttheloai.Text = "";
            txtnamxuatban.Text = "";
            txtnhaxuatban.Text = "";
            hienthi();
        }

        private void dmsachtimkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string timkiem = "select * from dmsach where masach = '" + txttimkiem.Text + "'";
            SqlCommand eee = new SqlCommand(timkiem, conn);
            SqlDataAdapter dc = new SqlDataAdapter(eee);
            DataTable dt = new DataTable();
            dc.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
