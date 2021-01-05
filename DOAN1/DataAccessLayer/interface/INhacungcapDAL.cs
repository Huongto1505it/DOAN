using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{
    public interface INhacungcapDAL
    {
        List<Nhacungcap> GetAllNhacungcap();
        void ThemNhacungcap(Nhacungcap ncc);
        void CapnhatNhacungcap(List<Nhacungcap> ncc);
    }
}
