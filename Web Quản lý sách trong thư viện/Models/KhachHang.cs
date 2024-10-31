namespace Quản_Lý_Sách.Models
{
    using System;
    using System.Collections.Generic;

    public partial class KhachHang
    {
        public KhachHang()
        {
            this.GiaoDich = new HashSet<GiaoDich>();
        }

        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public virtual ICollection<GiaoDich> GiaoDich { get; set; }
    }
}
