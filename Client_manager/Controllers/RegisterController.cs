using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using client_register_api_asp.Models;

namespace client_register_api_asp.Controllers;

public class RegisterController : Controller
{
  private readonly ILogger<RegisterController> _logger;

  public RegisterController(ILogger<RegisterController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}