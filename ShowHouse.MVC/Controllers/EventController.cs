using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShowHouse.Application.DTO;
using ShowHouse.Application.Interfaces;

namespace ShowHouse.MVC.Controllers
{
    public class EventController : Controller
    {
        private readonly IShowHouseEventService _showHouseEvent;
        private readonly IEventService _eventService;
        private readonly IStyleService _styleService;

        public EventController(IEventService eventService, IShowHouseEventService showHouseEvent, 
               IStyleService styleService)
        {
            _showHouseEvent = showHouseEvent;
            _eventService = eventService;
            _styleService = styleService;
        } 

        public async Task<IActionResult> Index()
        {
            var events = await _eventService.GetEvents();
            return View(events);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.ShowHouseId = new SelectList(await _showHouseEvent.GetShowHouses(), "Id", "Name");
            ViewBag.StyleId = new SelectList(await _styleService.GetStyles(), "Id", "MusicalStyle");
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(EventDTO eventDTO)
        {
            if(ModelState.IsValid)
            {
                await _eventService.Add(eventDTO);
                return RedirectToAction(nameof(Index));
            }
 
            return View(eventDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null) return NotFound();
            
            var showHouseVM = await _eventService.GetById(id);

            if(showHouseVM == null) return NotFound();

            return View(showHouseVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EventDTO eventDTO)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    await _eventService.Update(eventDTO);
                }
                catch(Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(eventDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null) return NotFound();

            var eventDTO = await _eventService.GetById(id);

            if(eventDTO == null) return NotFound();

            return View(eventDTO);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _eventService.Remove(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null) return NotFound();

            var eventDTO = await _eventService.GetById(id);

            if(eventDTO == null) return NotFound();

            return View(eventDTO);
        }
    }
}