using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Castle.Components.DictionaryAdapter;
using Microsoft.AspNetCore.Http;

namespace AdminLTE_DB.Models
{
    public class Product
    {
        // 🆔 المفاتيح الأساسية
       public int Id { get; set; }

        // 📦 معلومات المنتج الأساسية
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // 📂 التصنيف (العلاقة)
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        // 📊 معلومات المخزون والمزامنة
        public int ReservedQty { get; set; }           // الكمية المحجوزة مؤقتاً
        public byte[]? RowVersion { get; set; }        // للمنافسة المتزامنة (Concurrency)

        // ✅ الحالة
        public bool IsActive { get; set; } = true;

        // 🕒 التواريخ
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public string uid { get; set; } = Guid.NewGuid().ToString();

        // 🖼️ معلومات الصورة
        public string? ImagePath { get; set; }         // مسار الصورة في النظام

        [NotMapped]
        public string? ImageUrl { get; set; }          // رابط عرض الصورة

        [NotMapped]
        public IFormFile? ImageFile { get; set; }      // ملف الصورة عند الرفع (لا يُخزن في DB)
    }
}