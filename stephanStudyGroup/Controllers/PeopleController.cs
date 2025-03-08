using Microsoft.AspNetCore.Mvc;

namespace stephanStudyGroup.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult tableView()
        {
            List<Models.tableModel> people = new List<Models.tableModel>();

            people.Add(new Models.tableModel { StudentNumber = "u24581705", FirstName = "Stephan", Surname = "Kritzinger", EmailAddress = "u24581705@tuks.co.za", myLink = "~/HTML/Person1.html" });
            people.Add(new Models.tableModel { StudentNumber = "u87942389", FirstName = "Caitanya", Surname = "Singh", EmailAddress = "u87942389@tuks.co.za", myLink = "~/HTML/Person2.html" });
            people.Add(new Models.tableModel { StudentNumber = "u12345209", FirstName = "Philip", Surname = "Kritzinger", EmailAddress = "u12345209@tuks.co.za", myLink = "~/HTML/Person3.html" });
            people.Add(new Models.tableModel { StudentNumber = "u12345678", FirstName = "John", Surname = "Doe", EmailAddress = "u12345678@tuks.co.za", myLink = "~/HTML/Person4.html" });
            people.Add(new Models.tableModel { StudentNumber = "u87654321", FirstName = "Jane", Surname = "Doe", EmailAddress = "u87654321@tuks.co.za", myLink = "~/HTML/Person5.html" });

            return View(people);
        }

        public IActionResult renderStatic(string filePath)
        {
            string resolvedPath = Url.Content(filePath);
            return Redirect(resolvedPath);
        }
        public IActionResult Dropdown(string person)
        {
            if (person.StartsWith("tableView"))
            {
                return RedirectToAction("tableView");
            }
            else
            {
                return RedirectToAction("renderStatic", new { filepath = person });
            }
        }

    }
}
