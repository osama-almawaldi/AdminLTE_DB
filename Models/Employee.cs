using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminLTE_DB.Models
{
    public class Employee
    {
        // 🆔 المفاتيح الأساسية
        [Key]
        public int Id { get; set; }

        // 👤 المعلومات الشخصية
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // 🔐 بيانات تسجيل الدخول
        public string Username { get; set; }
        public string Password { get; set; }

        // 📍 تفاصيل إضافية
        public string? Address { get; set; } = null;
        public decimal Salary { get; set; } = 0;

        // 🔒 حالة الحساب
        public bool IsLock { get; set; } = false;
        public bool IsDelete { get; set; } = false;

        // 🗑️ معلومات الحذف (إن وجدت)
        public int? UserDelete { get; set; }
        public DateTime? DeleteDate { get; set; }

        // 🕒 التواريخ
        public DateTime AddDate { get; set; } = DateTime.Now;

        // 🔗 العلاقات
        public int? UserRoleId { get; set; }
        public virtual UserRole? UserRole { get; set; }
        public virtual ICollection<Permission>? Permissions { get; set; }
    }
}