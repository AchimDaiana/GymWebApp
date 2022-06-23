using GymWebApp.Data.Services;
using GymWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GymWebApp.Controllers
{
    [Authorize]
    public class TrainersController : Controller
    {
       
        private readonly ITrainersServices _service;

        public TrainersController(ITrainersServices service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allTrainers = await _service.GetAllAsync();
            return View(allTrainers);
        }

        //get:trainer/create
        public IActionResult Create()
        {
            return View();
        }

        //pentru a trimite datele in bd
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName, Biography, ProfilePicture")] Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }

            await _service.AddAsync(trainer);
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        //get:trainer/details 
        public async Task<IActionResult> Details(int id)
        {
            var trainerDetails = await _service.GetByIdAsync(id);

            if (trainerDetails == null) return View("NotFound");
            return View(trainerDetails);
        }

      

        public async Task<IActionResult> Edit(int id)
        {
            var trainerDetails = await _service.GetByIdAsync(id);
            if (trainerDetails == null) return View("NotFound");
            return View(trainerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,ProfilePicture,Biography")] Trainer trainer)
        {
            if (!ModelState.IsValid)
            {  
                return View(trainer);
            }

            await _service.UpdateAsync(id, trainer);
            return RedirectToAction(nameof(Index));
        }


        //get:stergere antrenor
        public async Task<IActionResult> Delete(int id)
        {
            var trainerDetails = await _service.GetByIdAsync(id);
            if (trainerDetails == null) return View("NotFound");
            return View(trainerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteValidation(int id)
        {
            var trainerDetails = await _service.GetByIdAsync(id);
            if (trainerDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
