using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface IHoadonbanBLL
    {
        List<Hoadonban> GetALLMH();
        void themHoadonban(Hoadonban hdb);
        void SuaHoadonban(Hoadonban hdb);
        void XoaHoadonban(string Mahdb);
        List<Hoadonban> TimkiemHoadonban(Hoadonban hdb);

    }
}
