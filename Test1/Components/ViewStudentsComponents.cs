using Microsoft.AspNetCore.Mvc;

namespace Test1.Components
{
    [ViewComponent(Name = "ViewStudents")]
    public class ViewStudentsComponents : ViewComponent
    {
        private readonly DataContext _context;
        public ViewStudentsComponents(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofStudents = (from s in _context.TblStudents
                select s).ToList(); 
                return await Task.FromResult((IViewComponentResult) View("Default", listofStudents));
        }
    }
}