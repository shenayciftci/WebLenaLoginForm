using System.ComponentModel.DataAnnotations;

namespace WebLenaLoginForm.Models
{
    public class Form
    {
        [Key]
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

    }
}
