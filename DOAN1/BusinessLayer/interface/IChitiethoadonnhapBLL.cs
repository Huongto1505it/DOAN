using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface IChitiethoadonnhapBLL
    {
        List<Chitiethoadonnhap> GetALLMH();
        void themChitiethoadonnhap(List<Mathang> h, Chitiethoadonnhap mh);
        void SuaChitiethoadonnhap(Chitiethoadonnhap mh);
        void XoaChitiethoadonnhap(string Mamh);
       
    }
}
