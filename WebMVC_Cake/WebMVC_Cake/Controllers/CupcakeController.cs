using Microsoft.AspNetCore.Mvc;
using WebMVC_Cake.Repositories;

namespace WebMVC_Cake.Controllers
{
    public class CupcakeController : Controller {
        private ICupcakeRepository _repository;
        private IWebHostEnvironment _environment;

        public CupcakeController(ICupcakeRepository repository, IWebHostEnvironment environment) {
            _repository = repository;
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
