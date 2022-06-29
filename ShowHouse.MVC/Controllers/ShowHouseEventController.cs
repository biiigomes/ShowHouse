using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> Index()
        {
            var showHouses = await _showHouseEventService.GetShowHouses();
            return View(showHouses);
        }
    }
}