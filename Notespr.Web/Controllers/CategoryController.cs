using Microsoft.AspNetCore.Mvc;
using Notespr.Data.UnitOfWork.IUnitOfWorks;
using Notespr.Data.UnitOfWorks;
using Notespr.Models.Entity;

namespace Notespr.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Category> ObjCategories = _unitOfWork.Category.GetAll().ToList();
            return View(ObjCategories);
        }

        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(Category obj)
        {
            return View(obj);
        }

        public IActionResult Edit() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditPost(Category obj) 
        {
            return View(obj);
        }

        public IActionResult Delete(int? id) 
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeletePost(int? id) 
        {
            return View();
        }
    }
}
