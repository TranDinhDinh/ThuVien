using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMuonTra : Form
    {
        private XuLyMuonTra xuly = new XuLyMuonTra();
        public void hienthi()
        {
            dgvMuonTra.DataSource = xuly.LaydsMT();
        }
        public frmMuonTra()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            PhieuMuonTra p = new PhieuMuonTra();
            p.MaPhieu= tbMa.Text; ;
            p.NgayMuon = dtMuon.Value;
            p.NgayTra = dtTra.Value;
            p.NgayTraDuKien = dtDK.Value;
            if(xuly.tim(p.MaPhieu)==null)
            {
                xuly.them(p);
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã phiếu bị trùng!Vui lòng nhập lại ");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            PhieuMuonTra p = new PhieuMuonTra();
            p.MaPhieu = tbMa.Text; ;
            p.NgayMuon = dtMuon.Value;
            p.NgayTra = dtTra.Value;
            p.NgayTraDuKien = dtDK.Value;
            if (xuly.tim(p.MaPhieu) != null)
            {
                xuly.sua(p);
                hienthi();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thoat!");
            Application.Exit();
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvMuonTra.SelectedRows)
            {
                string ma = r.Cells[0].Value.ToString();
                PhieuMuonTra s = xuly.tim(ma);
                if (s != null)
                {
                    tbMa.Text = s.MaPhieu;
                    dtMuon.Value = s.NgayMuon;
                    dtTra.Value = s.NgayTra;
                    dtDK.Value = s.NgayTraDuKien;
                    break;

                }
            }
        }
    }
}
