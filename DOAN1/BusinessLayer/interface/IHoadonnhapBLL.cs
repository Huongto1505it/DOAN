using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface IHoadonnhapBLL
    {
        List<Hoadonnhap> GetALLMH();
        void themHoadonnhap(Hoadonnhap hdn);
        void SuaHoadonnhap(Hoadonnhap hdn);
        void XoaHoadonnhap(string Mahdn);
        List<Hoadonnhap> TimkiemHoadonnhap(Hoadonnhap hdn);

    }
}
