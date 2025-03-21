using Microsoft.AspNetCore.Mvc;
using Test1.Models;

namespace Test1.Controllers.Teacher
{
    [Route("api/[controller]")]
    public class EditTeacherController : Controller
    {
        private readonly DataContext _context;

        public EditTeacherController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult EditTeacher([FromForm] tblTeachers teacher)
        {
            if (ModelState.IsValid)
            {
                var existingTeacher = _context.TblTeachers.Find(teacher.TeacherId);
                if (existingTeacher != null)
                {
                    existingTeacher.Name = teacher.Name;
                    existingTeacher.Gender = teacher.Gender;
                    existingTeacher.Dob = teacher.Dob;
                    existingTeacher.Email = teacher.Email;
                    existingTeacher.Phone = teacher.Phone;
                    existingTeacher.Address = teacher.Address;
                    _context.SaveChanges();
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }
    }
}