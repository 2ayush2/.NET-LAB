using Microsoft.AspNetCore.Mvc;
using SimpleCrudAdoNet.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCrudAdoNet.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", Age = 20 },
            new Student { Id = 2, Name = "Jane Smith", Age = 22 }
        };

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = students.Max(s => s.Id) + 1; // Generate a new ID
                students.Add(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                var existingStudent = students.FirstOrDefault(s => s.Id == id);
                if (existingStudent == null)
                    return NotFound();

                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;

                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            students.Remove(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
