using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SimpleCrudAdoNet.Models;
using System.Collections.Generic;

namespace SimpleCrudAdoNet.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _studentRepository;

        public StudentController(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            _studentRepository = new StudentRepository(connectionString);
        }

        public IActionResult Index()
        {
            IEnumerable<Student> students = _studentRepository.GetAllStudents();
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
                _studentRepository.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            Student student = _studentRepository.GetStudentById(id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public IActionResult Details(int id)
        {
            Student student = _studentRepository.GetStudentById(id);
            if (student == null) return NotFound();
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            Student student = _studentRepository.GetStudentById(id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentRepository.DeleteStudent(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
