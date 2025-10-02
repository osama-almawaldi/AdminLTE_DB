using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminLTE_DB.Models
{
    public class Permission
    {
        // 🆔 المفتاح الأساسي
        [Key]
        public int Id { get; set; }

        // ✅ صلاحيات الموظف
        public bool IsCategory { get; set; } = false;
        public bool IsProduct { get; set; } = false;
        public bool IsEmployee { get; set; } = false;

        // 🔗 العلاقة مع الموظف
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}