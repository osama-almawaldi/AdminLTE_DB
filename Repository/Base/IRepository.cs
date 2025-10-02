using AdminLTE_DB.Models;


namespace AdminLTE_DB.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        // 📜 جلب كل العناصر
        IEnumerable<T> FindAll();

        // 🔍 البحث عن عنصر حسب الـ Id
        T FindById(int id);

        // ➕ إضافة عنصر جديد (الحفظ يتم عبر UnitOfWork)
        void Add(T entity);

        // ✏️ تحديث عنصر موجود (الحفظ يتم عبر UnitOfWork)
        void Update(T entity);

        // 🗑️ حذف عنصر (الحفظ يتم عبر UnitOfWork)
        void Delete(T entity);
    }
}