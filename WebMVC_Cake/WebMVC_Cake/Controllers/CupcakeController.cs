using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC_Cake.Models;
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
        public IActionResult Index() {
            var cupcakes = _repository.GetCupcakes();
            return View(cupcakes);
        }

        [HttpGet]
        public IActionResult Create() {
            PopulateBakieriesDropDownList();
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost(Cupcake cupcake) {
            if (ModelState.IsValid) {
                _repository.CreateCupcake(cupcake);
                return RedirectToAction("Index");
            }
            return View(cupcake);
        }
        private void PopulateBakieriesDropDownList(int? selectedBakery = null) {
            var bakieries = _repository.PopulateBakeriesDropDownList();
            ViewBag.BakieryId = new SelectList(bakieries.AsNoTracking(), "BakeryId",
                "BakeryName", selectedBakery);
        }
        public IActionResult GetImage(int id) {
            Cupcake reqCupcake = _repository.GetCupcake(id);
            if (reqCupcake != null) {
                string webRootPath = _environment.WebRootPath;
                string folderPath = "\\images\\";
                string fullPath = webRootPath + folderPath + reqCupcake.ImageName;
                if (System.IO.File.Exists(fullPath)) {
                    FileStream fileStream = new FileStream(fullPath, FileMode.Open);
                    byte[] fileBytes;
                    using (BinaryReader br = new BinaryReader(fileStream)) {
                        fileBytes = br.ReadBytes((int)fileStream.Length);
                    }

                    return File(fileBytes, reqCupcake.ImageMimeType);
                }
                else {
                    if (reqCupcake.PhotoFile?.Length > 0) {
                        return File(reqCupcake.PhotoFile, reqCupcake.ImageMimeType);
                    }

                    return NotFound();
                }
            }
            else {
                return NotFound();
            }
        }
    }
}
