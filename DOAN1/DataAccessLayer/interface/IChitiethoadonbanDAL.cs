using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{
    public interface IChitiethoadonbanDAL
    {
        List<Chitiethoadonban> GetAllChitiethoadonban();
        void ThemChitiethoadonban(List<Mathang> h, Chitiethoadonban mh);
        void CapnhatChitiethoadonban(List<Chitiethoadonban> MH);

    }
}
