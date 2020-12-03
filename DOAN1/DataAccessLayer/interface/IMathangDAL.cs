using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{
    public interface IMathangDAL
    {
        List<Mathang> GetAllMathang();
        void ThemMathang(Mathang mh);
        void CapnhatMathang(List<Mathang> MH);

    }
}
