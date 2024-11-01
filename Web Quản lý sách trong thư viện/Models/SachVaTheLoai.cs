using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Web_Quản_lý_sách_trong_thư_viện.Models
{
    public class SachVaTheLoai
    {
        [Key]
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }


        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public object TheLoai { get; internal set; }
    }
}