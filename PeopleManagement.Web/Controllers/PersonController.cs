using Microsoft.AspNetCore.Mvc;
using PeopleManagement.Data.Interfaces;

namespace PeopleManagement.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}