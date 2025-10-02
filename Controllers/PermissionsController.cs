using System.Collections.Generic;
using AdminLTE_DB.Models;
using AdminLTE_DB.Repository.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdminLTE_DB.Controllers
{
    public class PermissionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermissionsController(IUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork; 
        }

        // 🔽 دالة مساعدة لإنشاء قائمة الموظفين في DropDown
        private void CreateEmployeeSelectList()
        {
            IEnumerable<Employee> emps = _unitOfWork.Employees.FindAll();

            // عرض FirstName فقط، يمكن دمج LastName لاحقًا إذا أحببت
            SelectList selectListItems = new SelectList(emps, "Id", "FirstName", 0);
            ViewBag.Employees = selectListItems;
        }

        // 📜 عرض كل الصلاحيات
        public IActionResult Index()
        {
            var permissions = _unitOfWork.Permissions.FindAll();
            return View(permissions);
        }

        // ➕ إنشاء صلاحية جديدة (GET)
        [HttpGet]
        public IActionResult Create()
        {
            CreateEmployeeSelectList();
            return View();
        }

        // ➕ إنشاء صلاحية جديدة (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Permission permission)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Permissions.Add(permission);
                _unitOfWork.Save();
                TempData["Success"] = "Permission created successfully ✅";
                return RedirectToAction("Index");
            }

            // إعادة تعبئة قائمة الموظفين في حال وجود خطأ
            CreateEmployeeSelectList();
            return View(permission);
        }

        // ✏️ تعديل صلاحية (GET)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var permission = _unitOfWork.Permissions.FindById(id);
            if (permission == null)
                return NotFound();

            CreateEmployeeSelectList();
            return View(permission);
        }

        // ✏️ تعديل صلاحية (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Permission permission)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Permissions.Update(permission);
                _unitOfWork.Save();
                TempData["Success"] = "Permission updated successfully ✅";
                return RedirectToAction("Index");
            }

            CreateEmployeeSelectList();
            return View(permission);
        }
    }
}