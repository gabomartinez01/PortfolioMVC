using System.Linq;
using PortfolioMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioMVC.ViewComponents
{
    public class Skills : ViewComponent
    {
        private readonly ApplicationDbContext db;

        public Skills(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var skills = db.Skills.ToArray();
            return View(skills);
        }
    }
}