using Fit.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fit.Web.Controllers
{
    public class FacultyController : Controller
    {
        private DataContext context;
        
        public FacultyController(DataContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var model = context.Faculties.First();
            return View(model);
        }
    }
}