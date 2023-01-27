using ASPAPP.Data;
using ASPAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        //for get
        public IActionResult Create()
        {
            
            return View();
        }
        //post
        [HttpPost]//want to add for post 
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            _db.categoryTab1.Add(obj);//to add the obj to db
            _db.SaveChanges();//to save the changes in db
            return RedirectToAction("Index");
        }

        //for get
        public IActionResult Edit(int ?id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            var catfromdb= _db.categoryTab1.Find(id);
            if(catfromdb==null)
            {
                return NotFound();
            }
            return View(catfromdb);
        }
        //post
        [HttpPost]//want to add for post 
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            _db.categoryTab1.Update(obj);//to add the obj to db
            _db.SaveChanges();//to save the changes in db
            return RedirectToAction("Index");
        }

        //for get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var catfromdb1 = _db.categoryTab1.Find(id);
            if (catfromdb1 == null)
            {
                return NotFound();
            }
            return View(catfromdb1);
        }
        //post
        [HttpPost]//want to add for post 
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category obj)
        {
            _db.categoryTab1.Remove(obj);//to add the obj to db
            _db.SaveChanges();//to save the changes in db
            return RedirectToAction("Index");
        }
    }
}
