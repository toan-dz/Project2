using System;

namespace Web_Quản_lý_sách_trong_thư_viện.Controllers
{
    internal class LibraryContext
    {
        public object SACH { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}