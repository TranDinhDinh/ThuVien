using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmSach : Form
    {
        private XuLySach xuly = new XuLySach();
        public void hienthi()
        {
            dgvSach.DataSource = xuly.LaydsSach();
        }
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.MaSach = tbMa.Text;
            s.TenSach = tbTenSach.Text;
            s.TheLoai = cmbTheLoai.Text;
            s.SoLuong = (int.Parse(tbSL.Text));
            s.SoLuongCon = (int.Parse(tbSLC.Text));
            s.TenTacGia=tbTenTG.Text;
            s.NhaXuatBan = tbNXB.Text;
            s.NgaySanXuat = dtNSX.Value;
            if(xuly.tim(s.MaSach)==null )
            {
                xuly.them(s);
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã số bị trùng!Vui lòng nhập lại ");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string ma = tbMa.Text;
            if(xuly.tim(ma)!=null)
            {
                xuly.xoa(ma);
                hienthi() ;
            }
            else
            {
                MessageBox.Show("Hết mã để xóa");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.MaSach = tbMa.Text;
            s.TenSach = tbTenSach.Text;
            s.TheLoai = cmbTheLoai.Text;
            s.SoLuong = (int.Parse(tbSL.Text));
            s.SoLuongCon = (int.Parse(tbSLC.Text));
            s.TenTacGia = tbTenTG.Text;
            s.NhaXuatBan = tbNXB.Text;
            s.NgaySanXuat = dtNSX.Value;

            if (xuly.tim(s.MaSach) != null)
            {
                xuly.sua(s);
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
            foreach(DataGridViewRow r in dgvSach.SelectedRows)
            {
                string ma = r.Cells[0].Value.ToString();
                Sach s = xuly.tim(ma);
                if(s != null)
                {
                    tbMa.Text = s.MaSach;
                    tbTenSach.Text = s.TenSach;
                    cmbTheLoai.Text = s.TheLoai;
                    tbSL.Text = s.SoLuong.ToString();
                    tbSLC.Text = s.SoLuongCon.ToString();
                    tbTenTG.Text = s.TenTacGia;
                    tbNXB.Text = s.NhaXuatBan;
                    dtNSX.Value = s.NgaySanXuat;
                    break;

                }

            }
                
        }
    }
}
