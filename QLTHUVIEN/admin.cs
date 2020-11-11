using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void qldocgia_Click(object sender, EventArgs e)
        {
            DOCGIA a = new DOCGIA();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void qlisach_Click(object sender, EventArgs e)
        {
            book a = new book();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void muontra_Click(object sender, EventArgs e)
        {
            Muon a = new Muon();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void dOIMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOIMKcs a = new DOIMKcs();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
