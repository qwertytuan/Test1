using Microsoft.AspNetCore.Mvc;

namespace Test1.Components
{
    [ViewComponent(Name = "ViewTeachers")]
    public class ViewTeachersComponents : ViewComponent
    {
        private readonly DataContext _context;
        public ViewTeachersComponents(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofTeachers = (from t in _context.TblTeachers
                select t).ToList(); 
                return await Task.FromResult((IViewComponentResult) View("Default", listofTeachers));
        }
    }
    
}