using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    internal class PhieuMuonTra
    {
        private string m_maPhieu;
        private DateTime m_ngayMuon;
        private DateTime m_ngayTra;
        private DateTime m_NgayTraDuKien;
        private List<PhieuMuonTra> m_ctPMT;
        public string MaPhieu
        {
            get { return m_maPhieu; }
            set { m_maPhieu = value; }
        }
        public DateTime NgayMuon
        {
            get { return m_ngayMuon; }
            set { m_ngayMuon = value; }
        }
        public DateTime NgayTra
        {
            get { return m_ngayTra;}
            set { m_ngayTra = value;}
        }
        public DateTime NgayTraDuKien
        {
            get { return m_NgayTraDuKien; }
            set
            {
       
                m_NgayTraDuKien = value;
            }
        }
        public List<PhieuMuonTra> ctMuonTra
        {
            get { return m_ctPMT; }
        }
        public double TienPhat
        {
            get
            {
                if(m_ngayTra > m_NgayTraDuKien)
                {
                    double tienPhat = (m_ngayTra - m_NgayTraDuKien).Days;
                    return tienPhat * 50000;
                }
                return 0;
            }
        }
     
        public PhieuMuonTra()
        {
            m_maPhieu = "";
            m_ngayMuon = DateTime.Now;
            m_ngayTra = DateTime.Now;
            m_NgayTraDuKien = DateTime.Now;
            m_ctPMT = new List<PhieuMuonTra>();
        }
        public PhieuMuonTra(string ma , DateTime muon , DateTime tra , DateTime dk)
        {
            m_maPhieu = ma;
            m_ngayMuon = muon;
            m_ngayTra = tra;
            m_NgayTraDuKien=dk;
        }

    }
}
