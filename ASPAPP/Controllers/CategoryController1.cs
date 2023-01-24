using ASPAPP.Data;
using ASPAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPAPP.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly AppDBContext _db;
        public CategoryController1(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
IEnumerable<Category> ObjCatList=_db.categoryTab1;
            return View(ObjCatList);
        }
    }
}
