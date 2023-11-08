using Ezeji_Udoka_Akans.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ezeji_Udoka_Akans.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {

            var projects = new List<ProjectModel>
            {
                new ProjectModel
                {
                    Description = "This is a link to my personal Github profile",
                    Tools = "• C#\r\n• .NET\r\n• ASP.NET Core\r\nWEB API\r\n• Entity Framework\r\n• MySQL\r\n• Postman\r\n• Docker\r\n• JavaScript\r\n• HTML 5\r\n• CSS•\r\n Visual Studio\r\n• GitHub\r\n• Azure\r\n• VS Cod ",
                    Name = "GitHubLink",
                    Link = "https://github.com/AKANS22",
                    Role = "Owner"


                },

                new ProjectModel
                {
                    Description = "Certifications by unify is an online learning platform that allows anyone to watch, listen and learn from our everyday STARS. Essentially a MOOC service provider. The goal is to aid people with little or no experience learn from powerfully talented individuals using brilliant storytelling and in-depth learning methods. The vision for Certifications by Certification by unify is to offer knowledge by the second; through practical, funny and engaging video modules. You can learn a trade, improve a passion, advance a career or get inspiration from industry best. These Masterclasses are to be hosted on Certification by unify, an EdTech platform with an all-in-one School Management System that manages and automates the physical operations of universities",
                    Tools = "• C#\r\n•ASP.NET Core WEB API\r\n• Entity Framework\r\n• Postgre\r\n MySQL\r\n• Postman\r\n• Docker\r\n•Visual Studio\r\n Azure",
                    Name = "Certification-By-Unify",
                    Link = "https://certifications.unifyedu.ng",
                    Role = "Back-End Engineer"


                },
            };
            return View(projects);
        }
    }
}
