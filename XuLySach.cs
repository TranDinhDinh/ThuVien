using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class XuLySach
    {
        private Dictionary<string, Sach> dsSach;
        public XuLySach()
        {
            TruyCapDuLieuSachandPhieuMuonTra data = TruyCapDuLieuSachandPhieuMuonTra.khoiTao(); //?
            dsSach = data.getdsSach();
        }
        public List<Sach> LaydsSach()
        {
            return dsSach.Values.ToList();
        }
        public Sach tim(string ma)
        {
            try
            {
                return dsSach[ma];
            }
            catch
            {
                return null;
            }
        }
        public void them (Sach x)
        {
            dsSach.Add(x.MaSach, x);
        }
        public void xoa(string ma)
        {
            dsSach.Remove(ma);
        }
        public void sua(Sach ma)
        {
            if (tim(ma.MaSach) != null)
            {
                dsSach[ma.MaSach] = ma;
            }
        }
    }
}
