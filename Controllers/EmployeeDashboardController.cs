using AdminLTE_DB.Models;
using AdminLTE_DB.Repository.Base;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_DB.Controllers
{
    public class EmployeeDashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeDashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // فقط الموظف العادي
        private bool IsEmployee()
        {
            return (HttpContext.Session.GetInt32("UserRoleId") ?? 0) != 1;
        }

        public IActionResult Dashboard()
        {
            if (!IsEmployee()) return RedirectToAction("Index", "Home");
            return View();
        }

        public IActionResult Profile()
        {
            if (!IsEmployee()) return RedirectToAction("Index", "Home");
            int empId = HttpContext.Session.GetInt32("EmployeeId") ?? 0;
            var employee = _unitOfWork.Employees.FindById(empId);
            return View(employee);
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            if (!IsEmployee()) return RedirectToAction("Index", "Home");
            int empId = HttpContext.Session.GetInt32("EmployeeId") ?? 0;
            var employee = _unitOfWork.Employees.FindById(empId);
            return View(employee);
        }

        [HttpPost]
        public IActionResult EditProfile(Employee emp)
        {
            if (!IsEmployee()) return RedirectToAction("Index", "Home");
            var employee = _unitOfWork.Employees.FindById(emp.Id);
            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;
            employee.Email = emp.Email;
            // employee.Phone = emp.Phone;

            _unitOfWork.Employees.Update(employee);
            _unitOfWork.Save();
            TempData["Update"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Profile");
        }
    }
}