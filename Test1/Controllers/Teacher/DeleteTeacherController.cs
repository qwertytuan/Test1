using Microsoft.AspNetCore.Mvc;
using Test1.Models;

namespace Test1.Controllers.Teacher
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteTeacherController : ControllerBase
    {
        private readonly DataContext _context;

        public DeleteTeacherController(DataContext context)
        {
            _context = context;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var teacher = await _context.Set<tblTeachers>().FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            _context.Set<tblTeachers>().Remove(teacher);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}