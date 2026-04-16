using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PresentacionGrupo.Models;

namespace PresentacionGrupo.Controllers;
public class GrupoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ListaIntegrantes()
    {
        return View();
    }
    public IActionResult InfoEstudiantes()
    {
        return View();
    }
}