using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{
    public interface IHoadonbanDAL
    {
        List<Hoadonban> GetAllHoadonban();
        void ThemHoadonban(Hoadonban hdb);
        void CapnhatHoadonban(List<Hoadonban> hdb);
    }
}
