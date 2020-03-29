using Fit.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fit.Web.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private DataContext context;

        public NavbarViewComponent(DataContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await context.Faculties.Include(f => f.Departments).OrderBy(f => f.Name).ToListAsync();
            return View(model);
        }
    }
}