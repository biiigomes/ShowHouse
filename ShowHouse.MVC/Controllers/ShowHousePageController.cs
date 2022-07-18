using Microsoft.AspNetCore.Mvc;
using ShowHouse.Application.Interfaces;

namespace ShowHouse.MVC.Controllers
{
    public class ShowHousePageController : Controller
    {
        private readonly IShowHouseEventService _showHouseEvent;
        private readonly IEventService _eventService;
        private readonly IStyleService _styleService;

        public ShowHousePageController(IEventService eventService, IShowHouseEventService showHouseEvent, 
               IStyleService styleService)
        {
            _showHouseEvent = showHouseEvent;
            _eventService = eventService;
            _styleService = styleService;
        } 
        public async Task<IActionResult> Home()
        {
            var events = await _eventService.GetEvents();
            return View(events);
        }
    }
}