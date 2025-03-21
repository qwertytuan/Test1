using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Test1.Models; // Assuming you have a Student model and a data context or repository// Assuming you have a data context or repository

namespace Test1.Controllers.Student
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteStudentController : ControllerBase
    {
        private readonly DataContext _context; // Assuming you have an ApplicationDbContext

        public DeleteStudentController(DataContext context)
        {
            _context = context;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Set<tblStudents>().FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            _context.Set<tblStudents>().Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}