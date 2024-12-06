using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class TruyCapDuLieuSachandPhieuMuonTra
    {
        private static TruyCapDuLieuSachandPhieuMuonTra m_data = null;
        private Dictionary<string, Sach> m_sach;
        private Dictionary<string, PhieuMuonTra> m_muontra;
        
        private TruyCapDuLieuSachandPhieuMuonTra()
        {
           m_sach = new Dictionary<string, Sach>();
           m_muontra = new Dictionary<string, PhieuMuonTra>();
        }

        public static TruyCapDuLieuSachandPhieuMuonTra khoiTao()
        {
            if(m_data == null)
                m_data = new TruyCapDuLieuSachandPhieuMuonTra();
            return m_data;
        }
        public Dictionary<string, Sach> getdsSach()
        {
            return m_sach;
        }
        public Dictionary<string, PhieuMuonTra> getdsPhieuMuonTra()
        {
            return m_muontra;
        }
        public bool ghiDuLieu(string tenfile)
        {
            try
            {
                FileStream f = new FileStream (tenfile , FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, m_data);
                f.Close();
                return true;
            }
            catch (Exception ) 
            {
            return false;
            }
        }
        public bool docDuLieu(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile , FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_data = bf.Deserialize(f) as TruyCapDuLieuSachandPhieuMuonTra;
                f.Close ();
                return true;
            }
            catch(Exception ) 
            {
                return false;
            }
        }
    }
}
