using Employee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? id)
        {
            if (id == null || id == 0)
            {
                EmployeeVM objList = new EmployeeVM()
                {
                    EmpVM = _db.Emps.ToList(),
                    departmentVM = _db.departments.ToList()
                };
                return View(objList);
            }
            else
            {
                EmployeeVM objList = new EmployeeVM()
                {
                    EmpVM = _db.Emps.Where(u => u.departmentId == id).ToList(),
                    departmentVM = _db.departments.ToList()
                };
                return View(objList);
            }
        }

        public IActionResult Create()
        {
            EmplVM objList = new EmplVM()
            {
                EmpVm = new Emp(),
                deptVM = _db.departments.ToList()
            };
            return View(objList);
        }

        [HttpPost]
        public IActionResult Create(EmplVM obj)
        {
            _db.Emps.Add(obj.EmpVm);
            _db.SaveChanges();
            TempData["success"] = "Employee added successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            EmplVM objList = new EmplVM()
            {
                EmpVm = _db.Emps.Find(id),
                deptVM = _db.departments.ToList()
            };
            return View(objList);
        }

        [HttpPost]
        public IActionResult Edit(EmplVM obj)
        {
            _db.Emps.Update(obj.EmpVm);
            _db.SaveChanges();
            TempData["success"] = "Employee details saved successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            EmplVM objList = new EmplVM()
            {
                EmpVm = _db.Emps.Find(id),
                deptVM = _db.departments.ToList()
            };
            return View(objList);
        }

        [HttpPost]
        public IActionResult Delete(EmplVM obj)
        {
            _db.Emps.Remove(obj.EmpVm);
            _db.SaveChanges();
            TempData["success"] = "Employee removed successfully";
            return RedirectToAction("Index");
        }
    }
}
