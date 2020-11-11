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
    public partial class DOCGIA : Form
    {
        public DOCGIA()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5SRTCNL\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
        private void hienthi()
        {
            conn.Open();
            string hien = "select * from dmdocgia";
            SqlCommand aaa = new SqlCommand(hien, conn);
            SqlDataAdapter da = new SqlDataAdapter(aaa);
            DataTable dc = new DataTable();
            da.Fill(dc);
            conn.Close();
            dataGridView1.DataSource = dc;
        }
        private void DOCGIA_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void themql_Click(object sender, EventArgs e)
        {
            if (qlmadg.Text != "" && qltendg.Text != "" && qlsodt.Text != "" && qldiachi.Text != "" && qlemail.Text != "")
            {
                conn.Open();
                string them = "insert into dmdocgia values ('" + qlmadg.Text + "', '" + qltendg.Text + "','" + qlsodt.Text + "','" + qldiachi.Text + "','" + qlemail.Text + "')";
                SqlCommand dc = new SqlCommand(them, conn);
                dc.ExecuteNonQuery();
                conn.Close();
                hienthi();
            }
            else MessageBox.Show("chưa nhập đủ thông tin");
        }

        private void suaql_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sua = "update dmdocgia set tendg = '" + qltendg.Text + "',sdt = '" + qlsodt.Text + "',diachi='" + qldiachi.Text + "',email ='" + qlemail.Text + "' where madg = '" + qlmadg.Text + "'";
            SqlCommand smd = new SqlCommand(sua, conn);
            smd.ExecuteNonQuery();
            conn.Close();
            hienthi();
        }

        private void xoaql_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlxoa = "delete dmdocgia where madg = '" + qlmadg.Text + "'";
            SqlCommand ddd = new SqlCommand(sqlxoa, conn);
            ddd.ExecuteNonQuery();
            conn.Close();
            qltendg.Text = "";
            qlsodt.Text = "";
            qldiachi.Text = "";
            qlemail.Text = "";
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqltimkiem = "select * from dmdocgia where madg = '" + quanlitimkiem.Text + "'";
            SqlCommand cmd = new SqlCommand(sqltimkiem, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable cd = new DataTable();
            da.Fill(cd);
            conn.Close();
            dataGridView1.DataSource = cd;
        }
    }
}
