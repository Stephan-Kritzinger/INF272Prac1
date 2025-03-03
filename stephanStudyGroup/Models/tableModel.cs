using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace stephanStudyGroup.Models
{
    public class tableModel
    {
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}
