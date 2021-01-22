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
    public partial class QuanLyLoai : Form
    {
        public QuanLyLoai()
        {
            InitializeComponent();
        }
        QLCafeEntities1 nt = new QLCafeEntities1();
        private void LamMoi_Click(object sender, EventArgs e)
        {
            dtgv_thongtinloai.DataSource = nt.getall_Loai();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            nt.ins_loai(txtMaLoai.Text, txtTenLoai.Text);
            dtgv_thongtinloai.DataSource = nt.getall_Loai();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            nt.upd_Loai(txtMaLoai.Text, txtTenLoai.Text);
            dtgv_thongtinloai.DataSource = nt.getall_Loai();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            nt.del_Loai(txtMaLoai.Text);
            dtgv_thongtinloai.DataSource = nt.getall_Loai();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dtgv_thongtinloai.DataSource = nt.get_Loai(txtMaLoai.Text);
        }

        private void QuanLyLoai_Load(object sender, EventArgs e)
        {
            dtgv_thongtinloai.DataSource = nt.getall_Loai();
        }

        private void dtgv_thongtinloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_thongtinloai.CurrentRow.Cells[0].Value != null)
            {
                txtMaLoai.Text = dtgv_thongtinloai.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                txtMaLoai.Text = "";
            }

            if (dtgv_thongtinloai.CurrentRow.Cells[1].Value != null)
            {
                txtTenLoai.Text = dtgv_thongtinloai.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                txtTenLoai.Text = "";
            }
        }
    }
}
