using Microsoft.AspNetCore.Mvc;

namespace Tp05.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Bus()
    {
        Escape.InicializarJuego();
        ViewBag.Respuesta=Escape.incognitasSalas[Escape.estadoJuego];
        return View();
    }
}
