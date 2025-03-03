using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using stephanStudyGroup.Models;

namespace stephanStudyGroup.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
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

    public IActionResult tableView()
    {
        List<Models.tableModel> people = new List<Models.tableModel>();

        people.Add(new Models.tableModel { StudentNumber = "u24581705", FirstName = "Stephan", Surname = "Kritzinger", EmailAddress = "u24581705@tuks.co.za" });
        people.Add(new Models.tableModel { StudentNumber = "u87942389", FirstName = "Caitanya", Surname = "Singh", EmailAddress = "u87942389@tuks.co.za" });
        people.Add(new Models.tableModel { StudentNumber = "u12345209", FirstName = "Philip", Surname = "Kritzinger", EmailAddress = "u12345209@tuks.co.za" });
        people.Add(new Models.tableModel { StudentNumber = "u12345678", FirstName = "John", Surname = "Doe", EmailAddress = "u12345678@tuks.co.za" });
        people.Add(new Models.tableModel { StudentNumber = "u87654321", FirstName = "Jane", Surname = "Doe", EmailAddress = "u87654321@tuks.co.za" });

        return View(people);
    }
}
