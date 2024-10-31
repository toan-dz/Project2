namespace Quản_Lý_Sách.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Sach
    {
        public Sach()
        {
            this.GiaoDich = new HashSet<GiaoDich>();
        }

        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public Nullable<int> NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<int> MaTheLoai { get; set; }

        public virtual ICollection<GiaoDich> GiaoDich { get; set; }
        public virtual TheLoai TheLoai { get; set; }
    }
}
