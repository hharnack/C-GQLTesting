using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using C_GQLTesting.Models;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace C_GQLTesting.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name)
    {
        ViewData["Message"] = "Hi my name is " + name;
        return View();
    }

    public string Add(int firstNum, int secondNum) 
    {
        return JsonSerializer.Serialize(firstNum + secondNum);
    }
}
