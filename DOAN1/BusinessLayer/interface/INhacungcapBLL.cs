using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface INhacungcapBLL
    {
        List<Nhacungcap> GetALLMH();
        void themNhacungcap(Nhacungcap ncc);
        void SuaNhacungcap(Nhacungcap ncc);
        void XoaNhacungcap(string Mancc);
        List<Nhacungcap> TimkiemNhacungcap(Nhacungcap ncc);

    }
}
