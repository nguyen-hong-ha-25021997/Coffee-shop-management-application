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
    public partial class QuanLyBanHang : Form
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }

        QLCafeEntities1 nt = new QLCafeEntities1();
        private void dtgv_thongtinloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgv_thongtinmon.DataSource = nt.getThucDon_Loai(dtgv_thongtinloai.CurrentRow.Cells[0].Value.ToString());
        }

        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {
            dtgv_thongtinloai.DataSource = nt.getall_Loai();
            dtgv_thongtinmon.DataSource = nt.getall_ThucDon();
            dtgv_Phieu.DataSource = nt.getPhieu_Main();
        }

        private void Ban1_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B01";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban2_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B02";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban3_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B03";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban4_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B04";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban5_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B05";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban6_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B06";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban7_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B07";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban8_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B08";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban9_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B09";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void Ban10_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "B10";
            txtMaPhieu.Text = "";
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
        }

        private void dtgv_chitietphieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_chitietphieu.CurrentRow.Cells[0].Value != null)
            {
                txtMaPhieu.Text = dtgv_chitietphieu.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                txtMaPhieu.Text = "";
            }

            if (dtgv_chitietphieu.CurrentRow.Cells[1].Value != null)
            {
                txtMaMon.Text = dtgv_chitietphieu.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                txtMaMon.Text = "";
            }

            if (dtgv_chitietphieu.CurrentRow.Cells[2].Value != null)
            {
                txtTenMon.Text = dtgv_chitietphieu.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                txtTenMon.Text = "";
            }

            if (dtgv_chitietphieu.CurrentRow.Cells[3].Value != null)
            {
                txtSoLuong.Text = dtgv_chitietphieu.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                txtSoLuong.Text = "";
            }
        }

        private void LapHoaDon_Click(object sender, EventArgs e)
        {
            nt.ins_Phieu(txtMaPhieu.Text, txtMaBan.Text);
            dtgv_Phieu.DataSource = nt.getPhieu_Main();
            if(txtMaBan.Text == "B01")
            {
                May1.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B02")
            {
                May2.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B03")
            {
                May3.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B04")
            {
                May4.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B05")
            {
                May5.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B06")
            {
                May6.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B07")
            {
                May7.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B08")
            {
                May8.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B09")
            {
                May9.BackColor = Color.Red;
            }
            if (txtMaBan.Text == "B0110")
            {
                May10.BackColor = Color.Red;
            }
        }

        private void dtgv_Phieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text = dtgv_Phieu.CurrentRow.Cells[0].Value.ToString();
            txtMaBan.Text = dtgv_Phieu.CurrentRow.Cells[1].Value.ToString();
            if (dtgv_Phieu.CurrentRow.Cells[2].Value != null)
            {
                txtTongTien.Text = dtgv_Phieu.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                txtTongTien.Text = "";
            }
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(dtgv_Phieu.CurrentRow.Cells[0].Value.ToString());
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
        }

        private void GoiMon_Click(object sender, EventArgs e)
        {
            nt.ins_CTP(txtMaPhieu.Text, txtMaMon.Text, txtTenMon.Text, int.Parse(txtSoLuong.Text.ToString()));
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaPhieu.Text);
            dtgv_Phieu.DataSource = nt.getPhieu_Main();
        }

        private void HuyMon_Click(object sender, EventArgs e)
        {
            nt.del_ChiTietPhieu(txtMaPhieu.Text, txtMaMon.Text);
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaPhieu.Text);
            dtgv_Phieu.DataSource = nt.getPhieu_Main();
        }

        private void HuyHoaDon_Click(object sender, EventArgs e)
        {
            nt.delPhieu_Main(txtMaPhieu.Text, txtMaBan.Text);
            dtgv_Phieu.DataSource = nt.getPhieu_Main();
            dtgv_chitietphieu.DataSource = nt.getCTP_Main(txtMaBan.Text);
            if (txtMaBan.Text == "B01")
            {
                May1.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B02")
            {
                May2.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B03")
            {
                May3.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B04")
            {
                May4.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B05")
            {
                May5.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B06")
            {
                May6.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B07")
            {
                May7.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B08")
            {
                May8.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B09")
            {
                May9.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B0110")
            {
                May10.BackColor = Color.LimeGreen;
            }
        }

        private void TinhTien_Click(object sender, EventArgs e)
        {
            nt.upd_Phieu(txtMaPhieu.Text, txtMaBan.Text);
            dtgv_Phieu.DataSource = nt.getPhieu_Main();
            if (txtMaBan.Text == "B01")
            {
                May1.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B02")
            {
                May2.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B03")
            {
                May3.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B04")
            {
                May4.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B05")
            {
                May5.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B06")
            {
                May6.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B07")
            {
                May7.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B08")
            {
                May8.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B09")
            {
                May9.BackColor = Color.LimeGreen;
            }
            if (txtMaBan.Text == "B0110")
            {
                May10.BackColor = Color.LimeGreen;
            }
        }
    }
}
