using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace patcntt2CF.Models
{
    public class PatBookStore:DbContext
    {
        public PatBookStore() : base("PatBookStoreConnectionString")
        {

        }

        // Tạo các bảng
        public DbSet<PatCategory> PatCategories { get; set; }
        public DbSet<PatBook> PatBooks { get; set; }

    }
}