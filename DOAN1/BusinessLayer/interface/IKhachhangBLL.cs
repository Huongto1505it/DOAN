using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface IKhachhangBLL
    {
        List<Khachhang> GetALLMH();
        void themkhachhang(Khachhang kh);
        void Suakhachhang(Khachhang kh);
        void Xoakhachhang(string Makh);
        List<Khachhang> Timkiemkhachhang(Khachhang kh);

    }
}
