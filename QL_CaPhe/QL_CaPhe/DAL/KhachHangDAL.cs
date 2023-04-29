using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using QL_CaPhe.DTO;
using System.Data;
namespace QL_CaPhe.DAL
{
    class KhachHangDAL
    {
        KHACHHANGTableAdapter kh;
        DataConnect con;
        public KhachHangDAL()
        {
            kh = new KHACHHANGTableAdapter();
            con = new DataConnect();
        }
        public List<KhachHang> ThongTinKH(string sdt)
        {
            DataTable dt = kh.GetDataBy_ttKH_sdt(sdt);
            List<KhachHang> k = con.ListTable<KhachHang>(dt);
            return k;
        }
        public bool kiemtraKH(string sdt)
        {
            try
            {
                int i = (int)kh.Kiemtra_KH_Sdt(sdt);
                if (i == 0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Insert(KhachHang a)
        {
            try
            {
                int i = (int)kh.Insert(a.MaKH, a.SDT, a.TenKH, 1);
                if (i == 0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int tongKH()
        {
            try
            {
                int i = (int)kh.TongKH();
                return i;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int tongDTL()
        {
            try
            {
                int i = (int)kh.TongDTL();
                return i;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
