using Ezeji_Udoka_Akans.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ezeji_Udoka_Akans.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult Index()
        {
            var experiences = new List<ExperienceModel>
        {
            new ExperienceModel
            {
                Position = "Back End Developer",
                Company = "Sterling Bank",
                StartDate = new DateTime(2023, 6, 5),
                EndDate = DateTime.Now,
                Description = "• Collaborate with cross-functional teams to understand software requirements and user needs." +
                              "\r\n• Assist in the design and development of software solutions, including coding, testing, debugging, and documentation." +
                              "\r\n• Work on bug fixes and software enhancements to improve existing applications." +
                              "\r\n• Contribute to the maintenance and optimization of databases, APIs, and backend services." +
                              "\r\n• Assist in the identification and resolution of software defects." +
                              "\r\n• Stay up-to-date with emerging software development trends and technologies." +
                              "\r\n• Assist with troubleshooting and providing technical support to end-users as needed." +
                              "\r\n• Collaborate with team members to meet project deadlines and deliver high-quality software solutions."
            },

              new ExperienceModel
            {
                Position = "Full-stack Developer ",
                Company = "Decagon",
                StartDate = new DateTime(2022, 11, 22),
                EndDate = new DateTime(2023, 6, 01),
                Description = "• Build real-time applications that are efficient, scalable, maintainable, extensible, and testable." +
                              "\r\n•Improved and worked on the existing codebase and effectively managed software functionalities" +
                              "\r\n•Produced clean, error-free code to meet aggressive timelines." +
                              "\r\n• IT training of clients/customers employees on the use and maintenance of software functionalities built by our team." +
                              "\r\n• Improve, migrate and work on the existing codebase." +
                              "\r\n•Communicate with business analysts and product owners to clarify requirements in a distributed team environment."
                                                            
            },

              new ExperienceModel
            {
                Position = "Mobile Phone Engineer ",
                Company = "Kawins Global Services",
                StartDate = new DateTime(2018, 03, 22),
                EndDate = new DateTime(2022, 11, 10),
                Description = "•Testing mobile devices to ensure their configuration, operation, and capabilities work efficiently." +
                              "\r\n•Working knowledge of mobile operating systems such as iOS and Android" +
                              "\r\n•Communicate with the customers to listen to and solve their technical issues" +
                              "\r\n• Solving complex technical issues that relate to device management networking and enrollment" +
                              "\r\n• Improving the existing methods and procedures to develop possible alternative solutions from customers." 
                              
            },
        };

            return View(experiences);
        }
    }
}
