using Microsoft.AspNetCore.Mvc;
using PeopleManagement.Data.Interfaces;

namespace PeopleManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPersonRepository personRepository;

        public HomeController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
