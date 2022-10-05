using Microsoft.AspNetCore.Mvc;

namespace Logm.FileUpdater.Controllers;

public class FileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<ActionResult> Index(IFormFile file)
    {
        Console.WriteLine(file.Name);

        return View();
    }
}
