using Microsoft.AspNetCore.Mvc;
using MVCTask.Context;

namespace MVCTask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _db;

        public DashboardController(AppDbContext appDbContext )
        {
            _db = appDbContext;
        }
        public IActionResult Index()
        {
            var categories = _db.Categories.toList();
            return View();
        }
    }
}
