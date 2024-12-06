using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class XuLyMuonTra
    {
        private Dictionary<string, PhieuMuonTra> dsMT;
        public XuLyMuonTra()
        {
            TruyCapDuLieuSachandPhieuMuonTra data = TruyCapDuLieuSachandPhieuMuonTra.khoiTao();
            dsMT = data.getdsPhieuMuonTra();
        }
        public List<PhieuMuonTra> LaydsMT()
        {
            return dsMT.Values.ToList();
        }
        public PhieuMuonTra tim(string ma)
        {
            try
            {
                return dsMT[ma];
            }
            catch
            {
                return null;
            }
        }
        public void them(PhieuMuonTra x)
        {
            dsMT.Add(x.MaPhieu, x);
        }
   
        public void sua(PhieuMuonTra ma)
        {
            if (tim(ma.MaPhieu) != null)
            {
                dsMT[ma.MaPhieu] = ma;
            }
        }

    }
}
