using Microsoft.AspNetCore.Mvc;
using Test1.Models;

namespace Test1.Controllers.Teacher
{
    [Route("api/[controller]")]
    public class AddTeacherController : Controller
    {
        private readonly DataContext _context;

        public AddTeacherController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddTeacher([FromForm] tblTeachers teacher)
        {
            if (ModelState.IsValid)
            {
                _context.TblTeachers.Add(teacher);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}