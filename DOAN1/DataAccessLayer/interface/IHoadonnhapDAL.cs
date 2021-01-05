using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{


    public interface IHoadonnhapDAL
    {
        List<Hoadonnhap> GetAllHoadonnhap();
        void ThemHoadonnhap(Hoadonnhap hdn);
        void CapnhatHoadonnhap(List<Hoadonnhap> hdn);
    }
}
