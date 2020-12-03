using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface IMathangBLL
    {
        List<Mathang> GetALLMH();
        void themmathang(Mathang mh);
        void SuaMathang(Mathang mh);
        void XoaMathang(string Mamh);
        List<Mathang> Timkiemmathang(Mathang mh);

    }
}
