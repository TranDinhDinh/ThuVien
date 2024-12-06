using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class Sach
    {
        private string m_maSach;
        private string m_tenSach;
        private string m_theLoai;
        private int m_soLuong;
        private int m_soLuongCon;
        private string m_tenTacGia;
        private string m_nhaXuatBan;
        private DateTime m_ngaySX;

        public string MaSach
        {
            get { return m_maSach;}
            set { m_maSach = value;}
        }
        public string TenSach
        {
            get { return m_tenSach;}
            set { m_tenSach = value;}
        }
        public string TheLoai
        {
            get { return m_theLoai;}
            set { m_theLoai = value;}
        }
        public int SoLuong
        {
            get { return m_soLuong;}
            set { m_soLuong = value;}
        }
        public string TenTacGia
        {
            get { return m_tenTacGia; }
            set { m_tenTacGia = value; }
        }
        public int SoLuongCon
        {
            get { return m_soLuongCon; }
            set { m_soLuongCon = value;}
        }
        public string NhaXuatBan
        {
            get { return m_nhaXuatBan; }
            set { m_nhaXuatBan = value; }
        }
        public DateTime NgaySanXuat
        {
            get { return m_ngaySX; }
            set { m_ngaySX = value;}
        }
        public Sach()
        {
            m_maSach = "";
            m_tenSach = "";
            m_theLoai = "";
            m_soLuong = 0;
            m_tenTacGia = "";
            m_soLuongCon = 0;
            m_nhaXuatBan = "";
            m_ngaySX = DateTime.Now;
        }
        public Sach(string ma, string tenS , string loai , int sl , string tenTG , int slCon , string nhasx , DateTime ngaysx )
        {
            m_maSach = ma;
            m_tenSach = tenS;
            m_theLoai = loai;
            m_soLuong = sl;
            m_tenTacGia = tenTG;
            m_soLuongCon = slCon;
            m_nhaXuatBan = nhasx;
            m_ngaySX = ngaysx;
        }


    }
}
