using Microsoft.AspNetCore.Mvc;
using ShowHouse.Application.Interfaces;

namespace ShowHouse.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventService _eventService;
        public HomeController(IEventService eventService)
        {
            _eventService = eventService;
        }
        public async Task<IActionResult> Index()
        {
           var events = await _eventService.GetEvents();
            return View(events);
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }
    }
}