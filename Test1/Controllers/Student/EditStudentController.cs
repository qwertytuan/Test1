using Microsoft.AspNetCore.Mvc;
using Test1.Models;

namespace Test1.Controllers.Student
{
    [Route("api/[controller]")]
    public class EditStudentController : Controller
    {
        private readonly DataContext _context;

        public EditStudentController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult EditStudent([FromForm] tblStudents student)
        {
            if (ModelState.IsValid)
            {
                var existingStudent = _context.TblStudents.Find(student.StudentId);
                if (existingStudent != null)
                {
                    existingStudent.Name = student.Name;
                    existingStudent.Gender = student.Gender;
                    existingStudent.Dob = student.Dob;
                    existingStudent.Email = student.Email;
                    existingStudent.Phone = student.Phone;
                    existingStudent.Address = student.Address;
                    _context.SaveChanges();
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }
    }
}