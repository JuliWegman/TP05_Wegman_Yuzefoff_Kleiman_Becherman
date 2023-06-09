﻿using Microsoft.AspNetCore.Mvc;

namespace Tp05.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Escape.InicializarJuego();
        return View();
    }
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Bus()
    {
        ViewBag.Respuesta=Escape.incognitasSalas[Escape.estadoJuego];
        return View();
    }
    public IActionResult VerificarRespuesta(string respuesta){
        if(respuesta.ToLower()==Escape.incognitasSalas[Escape.estadoJuego]){
            Escape.estadoJuego++;
        }
        return RedirectToAction("Bus");
    }
    public IActionResult Bomba(int IMG){
        ViewBag.imagen=IMG;
        return View();
    }

    public IActionResult pista(){
        return View();
    }
}
