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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private bool CheckExitForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {

                    frm.Activate();
                    break;
                }
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("QuanLyBanHang"))
            {
                QuanLyBanHang f = new QuanLyBanHang();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("QuanLyBanHang");
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("QuanLyThucDon"))
            {
                QuanLyThucDon f = new QuanLyThucDon();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("QuanLyThucDon");
        }

        private void loaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("QuanLyLoai"))
            {
                QuanLyLoai f = new QuanLyLoai();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("QuanLyLoai");
        }

        private void phiếuChiTiếtPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("Phieu"))
            {
                Phieu f = new Phieu();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("Phieu");
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }   
}
