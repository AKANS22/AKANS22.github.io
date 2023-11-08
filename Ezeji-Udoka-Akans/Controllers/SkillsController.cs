using Ezeji_Udoka_Akans.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ezeji_Udoka_Akans.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            var skills = new List<SkillsModel>
        {
            new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills = "C#",
               RateLevel = "1-10",
               Rate = 7


            },
            new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = " ASP.NET Core WEB API",
               RateLevel = "1-10",
               Rate = 7

            },
             new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = " ASP.NET Core MVC",
               RateLevel = "1-10",
               Rate = 5

            },
              new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = " Entity Framework",
               RateLevel = "1-10",
               Rate = 7

            },
               new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = " MySQL",
               RateLevel = "1-10",
               Rate = 7

            },

                new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = "  Postman",
               RateLevel = "1-10",
               Rate = 7

            },
                 new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = " Dorker",
               RateLevel = "1-10",
               Rate = 7

            },


                 new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = "JavaScript",
               RateLevel = "1-10",
               Rate = 6

            },

                 new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = "CSS",
               RateLevel = "1-10",
               Rate = 6

            },

                 new SkillsModel
            {
               Description = "TECHNOLOGIES",
               Skills      = "HTML",
               RateLevel = "1-10",
               Rate = 6

            },
            new SkillsModel
            {
               Description = "Tools",
               Skills      = "• Visual Studio\r\n• GitHub\r\n• Azure\r\n• VS Code"

            },
        };
            return View(skills);
        }
    }
}
