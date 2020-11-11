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
    public partial class Muon : Form
    {
        public Muon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5SRTCNL\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
        private void hienthi()
        {
            conn.Open();
            string hien = "select * from dmmuontra";
            SqlCommand aaa = new SqlCommand(hien, conn);
            SqlDataAdapter ad = new SqlDataAdapter(aaa);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void Muon_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mtmadg.Text != "" && mtmasach.Text != "" && mtngaymuon.Text != "" && mtsoluon.Text != "" && mtngayhen.Text != "" && mtngaytra.Text != "")
            {
                conn.Open();
                string them = "insert into  dmmuontra values ('" + mtmadg.Text + "', '" + mtmasach.Text + "','" + mtngaymuon.Text + "','" + mtsoluon.Text + "','" + mtngayhen.Text + "','" + mtngaytra.Text + "')";
                SqlCommand cmd = new SqlCommand(them, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                hienthi();
            }
            else MessageBox.Show("bạn chưa nhập đủ thông tin");
        }

        private void mtsua_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sqlupdate = "update dmmuontra  set masach = '" + mtmasach.Text + "', ngaymuon = '" + mtngaymuon.Text + "',soluong = '" + mtsoluon.Text + "',ngayhentra ='" + mtngayhen.Text + "',ngaytra = '" + mtngaytra.Text + "'where madg = '" + mtmadg.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlupdate, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            hienthi();
        }

        private void mtxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string xoa = "delete dmmuontra where madg = '" + mtmadg.Text + "'";
            SqlCommand abc = new SqlCommand(xoa, conn);
            abc.ExecuteNonQuery();
            conn.Close();
            mtngaymuon.Text = "";
            mtsoluon.Text = "";
            mtngayhen.Text = "";
            mtngaytra.Text = "";
            hienthi();
        }

        private void qltimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqltimkiem = "select * from dmmuontra where madg = '" + qltimkiem.Text + "'";
            SqlCommand bcv = new SqlCommand(sqltimkiem, conn);
            SqlDataAdapter a = new SqlDataAdapter(bcv);
            DataTable dt = new DataTable();
            a.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
