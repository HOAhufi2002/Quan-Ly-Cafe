using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DAL;
using  QL_CaPhe.DAL.QL_CaPheTableAdapters;
using QL_CaPhe.DTO;
namespace QL_CaPhe.DAL
{
    class SuCoDAL
    {

        SUCOTableAdapter dssc;
        DataConnect con;
        public SuCoDAL()
        {
            con = new DataConnect();
            dssc = new SUCOTableAdapter();
        }
        public bool Insert(SuCo a)
        {
            try
            {
                int i = (int)dssc.KTraKhoa_SuCo(a.MaBienBan);
                if (i == 0)
                {
                    i = dssc.Insert(a.MaBienBan, a.TenBienBan, a.NgayLap, a.GiaiQuyet, a.ChiPhi, a.MaKH, a.MaNV);
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
    }
}
