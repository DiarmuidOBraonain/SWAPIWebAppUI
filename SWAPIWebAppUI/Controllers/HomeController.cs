using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SWAPIWebAppUI.Models;
using SWAPIWebAppUI.Services;
using Newtonsoft.Json;

namespace SWAPIWebAppUI.Controllers;

public class HomeController : Controller
{
    // variables

    /// <summary>
    /// Logger instance used for logging messages in the HomeController.
    /// </summary>
    private readonly ILogger<HomeController> _logger;

    /// <summary>
    /// Service for interacting with the star wars API (SWAPI).
    /// </summary>
    private readonly SWAPIService _swapiService;


    // constructor

    /// <summary>
    /// Constructor to create instance of homecontroller with parameters
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="swApiService"></param>
    public HomeController(ILogger<HomeController> logger, SWAPIService swApiService)
    {
        _logger = logger;
        _swapiService = swApiService;
    }

    // methods
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    /// <summary>
    /// Async task to use the swApiService that will interact with the star wars API
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> GetStarWarsAPICharacters()
    {
        try
        {
            var characters = await _swapiService.GetSWAPICharacters();
            return PartialView("_SWAPICharactersPartial", characters);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return Content("An error occurred while attempting to retrieve SWAPI characters.");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
