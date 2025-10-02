using AdminLTE_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE_DB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 📦 المنتجات والتصنيفات
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        // 👤 الموظفون والعملاء
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        // // 🛒 الطلبات والسلة
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }

        // 🔐 الصلاحيات والأدوار
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }

        // 📌 في حال أردت إضافة جداول مستقبلية
        // public virtual DbSet<OrderDetails> OrderDetails { get; set; }
    }
}