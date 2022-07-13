using ECommerceApp.Data;
using ECommerceApp.Data.Services;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommerceApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IActorsService _actorService;

        public ActorsController(AppDbContext context, IActorsService service)
        {
            _context = context;
            _actorService = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actorService.GetAllAsync();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            await _actorService.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var result = await _actorService.GetByIdAsync(id);
            if(result == null)
            {
                return View("NotFound");
            }
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _actorService.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _actorService.GetByIdAsync(id);
            if (result == null)
            {
                return View("NotFound");
            }
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _actorService.GetByIdAsync(id);
            if (result == null)
            {
                return View("NotFound");
            }

            await _actorService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var details = await _actorService.GetByIdAsync(id);

            if(details == null)
            {
                return View("NotFound");
            }

            return View(details);
        }
    }
}
