using Emptyp.Models;
using Microsoft.AspNetCore.Mvc;
using Emptyp.Data;

namespace PortfolioWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext db;

        public ContactController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();

                ViewBag.Message = "Message Sent Successfully";
            }

            return View();
        }
    }
}