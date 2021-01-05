using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface IChitiethoadonbanBLL
    {
        List<Chitiethoadonban> GetALLMH();
        void themChitiethoadonban(List<Mathang> h, Chitiethoadonban mh);
        void SuaChitiethoadonban(Chitiethoadonban mh);
        void XoaChitiethoadonban(string Mamh);

    }
}
