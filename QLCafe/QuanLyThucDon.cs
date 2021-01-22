using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCafe
{
    public partial class QuanLyThucDon : Form
    {
        public QuanLyThucDon()
        {
            InitializeComponent();
        }
        QLCafeEntities1 nt = new QLCafeEntities1();
        private void QuanLyThucDon_Load(object sender, EventArgs e)
        {
            dtgv_thongtinmon.DataSource = nt.getall_ThucDon();
            comboBox1.DataSource = nt.getall_Loai();
            comboBox1.DisplayMember = "MaLoai";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            nt.upd_ThucDon(txtMaMon.Text, 
            txtTenMon.Text, 
            comboBox1.Text, 
            txtDVT.Text, 
            decimal.Parse(txtDonGia.Text));
            dtgv_thongtinmon.DataSource = nt.getall_ThucDon();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            nt.ins_ThucDon(txtMaMon.Text,
            txtTenMon.Text,
            comboBox1.Text.ToString(),
            txtDVT.Text,
            decimal.Parse(txtDonGia.Text));
            dtgv_thongtinmon.DataSource = nt.getall_ThucDon();
        }

        

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dtgv_thongtinmon.DataSource = nt.get_ThucDon(txtMaMon.Text);
        }

        private void LamMoi_Click(object sender, EventArgs e)
        {
            dtgv_thongtinmon.DataSource = nt.getall_ThucDon();
        }

        private void dtgv_thongtinmon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_thongtinmon.CurrentRow.Cells[0].Value != null)
            {
                txtMaMon.Text = dtgv_thongtinmon.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                txtMaMon.Text = "";
            }

            if (dtgv_thongtinmon.CurrentRow.Cells[1].Value != null)
            {
                txtTenMon.Text = dtgv_thongtinmon.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                txtTenMon.Text = "";
            }

            if (dtgv_thongtinmon.CurrentRow.Cells[2].Value != null)
            {
                comboBox1.Text = dtgv_thongtinmon.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                comboBox1.Text = "";
            }

            if (dtgv_thongtinmon.CurrentRow.Cells[3].Value != null)
            {
                txtDVT.Text = dtgv_thongtinmon.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                txtDVT.Text = "";
            }
            if (dtgv_thongtinmon.CurrentRow.Cells[4].Value != null)
            {
                txtDonGia.Text = dtgv_thongtinmon.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                txtDonGia.Text = "";
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            nt.del_ThucDon(txtMaMon.Text);
            dtgv_thongtinmon.DataSource = nt.getall_ThucDon();
        }
    }
}
