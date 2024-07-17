using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace patcntt2CF.Models
{
    /// <summary>
    /// Tạo cấu trúc bảng dữ liệu
    /// </summary>
    public class PatCategory
    {
        [Key]
        public int PatCategoryId { get; set; }
        public String PatCategoryName { get; set; }

        // Thuộc tính quan hệ
        public virtual ICollection<PatBook> Books { get; set; }
    }
}