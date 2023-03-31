using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebLenaLoginForm.Models;

namespace WebLenaLoginForm.Controllers
{
    public class FormController : Controller
    {

        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {

            var degerler = c.Forms.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniForm(Form f)
        {
            c.Forms.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
