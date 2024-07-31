using Microsoft.AspNetCore.Mvc;
using SimpleCrudAdoNet.DataAccess;
using SimpleCrudAdoNet.Models;

namespace SimpleCrudAdoNet.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDataAccessLayer _dataAccessLayer;

        public StudentController()
        {
            _dataAccessLayer = new StudentDataAccessLayer();
        }

        public IActionResult Index()
        {
            var students = _dataAccessLayer.GetAllStudents();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _dataAccessLayer.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = _dataAccessLayer.GetAllStudents().FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _dataAccessLayer.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = _dataAccessLayer.GetAllStudents().FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _dataAccessLayer.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
