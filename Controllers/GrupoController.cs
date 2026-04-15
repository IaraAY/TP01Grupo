using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PresentacionGrupo.Models;

namespace PresentacionGrupo.Controllers;
public class GrupoController : Controller
{
    private readonly ILogger<HomeController> _logger; 
    public IActionResult Index()
    {
        return View();
    }
}