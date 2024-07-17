using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace patcntt2CF.Models
{
    /// <summary>
    /// Tạo ra cấu trúc bảng Book
    /// </summary>
    public class PatBook
    {
        [Key]
        public int PatBookId { get; set; }
        public string PatTitle { get; set; }
        public string PatAuthor { get; set; }
        public int PatYear { get; set; }
        public string PatPublisher { get; set; }
        public string PatPicture { get; set; }
        public int PatCategoryId { get; set; }

        // thuộc tính quan hệ
        public virtual PatCategory PatCategory { get; set; }
    }
}