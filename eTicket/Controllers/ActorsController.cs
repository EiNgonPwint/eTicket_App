using eTicket.Data;
using eTicket.Data.Services;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data); 
        }

        //Get :Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        //Post :Actors/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Actor actor)
        {
           
            /*var test = ModelState;*/
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
           
            await _service.AddAsync(actor); 
            return RedirectToAction(nameof(Index));
        }
        // Get : Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not found");
            return View(actorDetails);
                
        }

        //Get :Actors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not found");
            return View(actorDetails);

            
        }

        //Post :Actors/Update
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL,FullName,Bio")] Actor actor)
        {

            /*var test = ModelState;*/
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }

        //Get :Actors/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not found");
            return View(actorDetails);


        }

        //Post :Actors/Create
        [HttpPost, ActionName ("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not found");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
