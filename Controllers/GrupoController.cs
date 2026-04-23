using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PresentacionGrupo.Models;

namespace PresentacionGrupo.Controllers;
public class GrupoController : Controller
{
    Curso curso = new Curso();
    public IActionResult Bauti()
    {
        Integrante bauti = curso.Integrantes[50046913];
        ViewBag.Integrante = bauti;
        return View();
    }
    public IActionResult Kyara()
    {
        Integrante iara = curso.Integrantes[46982167];
        ViewBag.Integrante = iara;
        return View();
    }
}