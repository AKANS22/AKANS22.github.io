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
               Skills = "C#\r\n• .NET\r\n• ASP.NET Core\r\nWEB API\r\n• Entity Framework\r\n• MySQL\r\n• Postman\r\n• Docker\r\n• JavaScript\r\n• HTML 5\r\n• CSS"


            },

            new SkillsModel
            {
               Description = "TOOLS",
               Skills      = "• Visual Studio\r\n• GitHub\r\n• Azure\r\n• VS Cod"

            },
        };
            return View(skills);
        }
    }
}
