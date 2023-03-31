using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLenaLoginForm.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string UserName { get; set; }

		[Column(TypeName = "Varchar(20)")]
		public string Password { get; set; }

    }
}
