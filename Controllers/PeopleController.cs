using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OsobyZaginione.Models;

namespace OsobyZaginione.Controllers
{
    public class PeopleController : Controller
    {
        private PersonManager _manager;

        public PeopleController()
        {
            this._manager = new PersonManager();
        }

        [HttpGet]
        [Route("")]
        [Route("list/{id?}")]
        // GET: PeopleController
        public ActionResult Index(string id)
        {
            var people = this._manager.GetPeople();

            if (!String.IsNullOrEmpty(id))
            {
                Console.WriteLine("not empty");
            }
            else
            {
                Console.WriteLine("empty");
            }
            
            return View(people);
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            var person = this._manager.GetPerson(id);
            return View(person);
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person personModel)
        {
            try
            {   
                this._manager.AddPerson(personModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {   
            var person = this._manager.GetPerson(id);

            return View(person);
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            var person = this._manager.GetPerson(id);

            return View(person);
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Person personModel)
        {
            try
            {
                this._manager.RemovePerson(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
