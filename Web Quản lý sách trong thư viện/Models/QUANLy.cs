using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Quản_lý_sách_trong_thư_viện.Models
{
    public class QUANTRI
    {
        [Key]
        public int MaQuanTri { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống.")]
        [StringLength(50, ErrorMessage = "Tên đăng nhập không được vượt quá 50 ký tự.")]
        public string TenDangNhap { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        public string MatKhau { get; set; }

        [Required(ErrorMessage = "Quyền hạn không được để trống.")]
        [StringLength(20, ErrorMessage = "Quyền hạn không được vượt quá 20 ký tự.")]
        public string QuyenHan { get; set; }
    }
}