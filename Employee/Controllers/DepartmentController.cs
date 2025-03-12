using Employee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DepartmentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<department> objList = _db.departments.ToList();
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(department obj)
        {
            if (ModelState.IsValid)
            {
                _db.departments.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Department created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            department dept = _db.departments.Find(id);
            return View(dept);
        }

        [HttpPost]
        public IActionResult Edit(department obj)
        {
            if (ModelState.IsValid)
            {
                _db.departments.Update(obj);                                 
                _db.SaveChanges();
                TempData["success"] = "Department saved successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            department dept = _db.departments.Find(id);
            return View(dept);
        }

        [HttpPost]
        public IActionResult delete(department obj)
        {
            _db.departments.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Department Removed successfully";
            return RedirectToAction("Index");   
        }
    }
}
