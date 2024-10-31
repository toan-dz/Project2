namespace Quản_Lý_Sách.Models
{
    using System;
    using System.Collections.Generic;

    public partial class TheLoai
    {
        public TheLoai()
        {
            this.Saches = new HashSet<Sach>();
        }

        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
