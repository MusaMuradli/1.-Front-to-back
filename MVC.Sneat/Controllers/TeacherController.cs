using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Sneat.DAL;

namespace MVC.Sneat.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TeacherController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var teacher = _dbContext.Teachers.Include(x=>x.TeacherGroups).ToList();
            return View(teacher);
        }
    }
}
