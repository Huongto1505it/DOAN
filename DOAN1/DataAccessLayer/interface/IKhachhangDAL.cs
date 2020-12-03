using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{
    public interface IKhachhangDAL
{
        List<Khachhang> GetAllKhachhang();
        void Themkhachhang(Khachhang kh);
        void Capnhatkhachhang(List<Khachhang> kh);
    }
}
