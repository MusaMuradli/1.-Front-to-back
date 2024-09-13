using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Sneat.DAL;

namespace MVC.Sneat.Controllers
{
    public class StudentController:Controller
    {
        private readonly AppDbContext _dbContext;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var students = _dbContext.Students.Include(x => x.Group).ToList();
            return View(students);
        }
    }
}
