using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShowHouse.Application.DTO;
using ShowHouse.Application.Interfaces;

namespace ShowHouse.MVC.Controllers
{ 
    public class ShowHouseEventController : Controller
    {
        private readonly IShowHouseEventService _showHouseEventService;
        public ShowHouseEventController(IShowHouseEventService showHouseEventService)
        {
            _showHouseEventService = showHouseEventService;
        }

        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            var showHouses = await _showHouseEventService.GetShowHouses();
            return View(showHouses);
        }

        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShowHouseEventDTO showHouse)
        {
            if(ModelState.IsValid)
            {
                await _showHouseEventService.Add(showHouse);
                return RedirectToAction(nameof(Index));
            }
            return View(showHouse);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null) return NotFound();

            var showHouseVM = await _showHouseEventService.GetById(id);

            if(showHouseVM == null) return NotFound();

            return View(showHouseVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ShowHouseEventDTO showHouse)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    await _showHouseEventService.Update(showHouse);
                }
                catch(Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(showHouse);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null) return NotFound();
            
            var showHouseDTO = await _showHouseEventService.GetById(id);

            if(showHouseDTO == null) return NotFound();

            return View(showHouseDTO);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _showHouseEventService.Remove(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null) return NotFound();

            var showHouseDTO = await _showHouseEventService.GetById(id);

            if(showHouseDTO == null) return NotFound();

            return View(showHouseDTO);
        }
    }
}