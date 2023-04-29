using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using System.Windows.Forms;
using System.Data;
namespace QL_CaPhe.DAL
{
    class MonDAL
    {
        MONTableAdapter dsmon;
        DataConnect con;
        int? i;
        public MonDAL()
        {
            con = new DataConnect();
            dsmon = new MONTableAdapter();
        }
        public List<Mon> GetList()
        {
            DataTable dt = dsmon.GetData();
            List<Mon> list_mon = con.ListTable<Mon>(dt);
            return list_mon;
        }
        public List<Mon> GetList_Maloai(string maloai)
        {
            DataTable dt = dsmon.GetDataBy_MaLoai(maloai);
            List<Mon> list_mon = con.ListTable<Mon>(dt);
            return list_mon;
        }
        bool? kq;
        public bool Insert(Mon a)
        {
            try
            {
                dsmon.FillBy_KTraTrungKhoa(a.Maloai,ref kq);
                if(kq == false)
                {
                    i = dsmon.Insert(a.MaMon, a.TenMon, a.Gia, a.TrangThai, a.Maloai);
                    if (i>=1)
                        return true;
                }
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(Mon a)
        {
            try
            {
                dsmon.FillBy_KTraTrungKhoa(a.Maloai, ref kq);
                if (kq == true)
                {
                    int i = dsmon.Delete(a.MaMon);
                    if (i >= 1)
                        return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(Mon a)
        {
            try
            {
                dsmon.FillBy_KTraTrungKhoa(a.Maloai, ref kq);
                if (kq == true)
                {
                    int i = dsmon.UpdateQuery(a.TenMon, a.Gia, a.TrangThai, a.Maloai, a.MaMon);
                    if (i >= 1)
                        return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
    
        public int? SLCon()
        {
            try
            {
                dsmon.ScalarQuery_SLCon(ref i);
                int? kq =  i;
                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int? SLHet()
        {
            try
            {
                dsmon.ScalarQuery_SLHet(ref i);
                int? kq = i;
                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int? TongMon()
        {
            try
            {
                dsmon.ScalarQuery_TongMon(ref i);
                int? kq = i;
                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

    }
}
