using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminLTE_DB.Models
{
    public class Category
    {
        // 🆔 المفاتيح الأساسية
        [Key]
        public int Id { get; set; }

        // 🪪 معرف فريد (UUID)
        public string uid { get; set; } = Guid.NewGuid().ToString();

        // 📦 المعلومات الأساسية
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        // 🔗 العلاقة مع المنتجات
        public virtual ICollection<Product>? Products { get; set; }
    }
}