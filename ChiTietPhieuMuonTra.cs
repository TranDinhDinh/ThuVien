using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class ChiTietPhieuMuonTra
    {
        private int m_soLuong;
        private Sach m_sach;
        public int soLuong
        {
            get { return m_soLuong; }
            set { m_soLuong = value;}
        }
        public Sach Sach
        {
            get { return m_sach; }
            set { m_sach = value; }
        }
        public ChiTietPhieuMuonTra()
        {
            m_soLuong = 0;
            m_sach = null;
        }
        public ChiTietPhieuMuonTra(int sl , Sach s)
        {
            soLuong = sl;
            m_sach = s;
        }

    }
}
