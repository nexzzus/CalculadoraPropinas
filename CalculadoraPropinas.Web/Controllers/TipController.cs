using CalculadoraPropinas.Web.Models;
using CalculadoraPropinas.Web.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraPropinas.Web.Controllers;

public class TipController : Controller
{
    private readonly ITipService _tipService;

    public TipController(ITipService tipService)
    {
        _tipService = tipService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(TipModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var result = _tipService.CalculateTip(model);
        return View(result);
    }
}