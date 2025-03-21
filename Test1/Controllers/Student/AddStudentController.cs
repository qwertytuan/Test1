using Microsoft.AspNetCore.Mvc;
using Test1.Models;

namespace Test1.Controllers.Student
{
    [Route("api/[controller]")]
    public class AddStudentController : Controller
    {
        private readonly DataContext _context;

        public AddStudentController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddStudent([FromForm] tblStudents student)
        {
            if (ModelState.IsValid)
            {
                _context.TblStudents.Add(student);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}