namespace Quản_Lý_Sách.Models
{
    using System;

    public partial class GiaoDich
    {
        public int MaGD { get; set; }
        public int? MaKH { get; set; }
        public int? MaSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime? NgayTraDuKien { get; set; }
        public DateTime? NgayTraThucTe { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
