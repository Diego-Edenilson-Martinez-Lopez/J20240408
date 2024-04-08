using J20240408.LogicaDeNegocio;
using J20240408.EntidadesDeNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace J20240408.UI.AppWebMVC.Controllers
{

    public class PersonaJController : Controller
    {
        readonly PersonaJBL _personaJBL;
        public PersonaJController(PersonaJBL clienteBL)
        {
            _personaJBL = clienteBL;
        }
        // GET: PersonaJController
        public async Task<ActionResult> Index(PersonaJ personaJ)

        {


            var clientes = await _personaJBL.Buscar(personaJ);
            return View(personaJ);
        }
            
      

        // GET: PersonaJController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personaJ = await _personaJBL.ObtenerPorId(new PersonaJ { Id = id });
            return View(personaJ);
        }

        // GET: PersonaJController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaJ personaJ)
        {
            try
            {
                await _personaJBL.Crear(personaJ);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // POST: PersonaJController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PersonaJController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var personaJ = await _personaJBL.ObtenerPorId(new PersonaJ { Id = id });
            return View(personaJ);
        }

        // POST: PersonaJController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaJ personaJ)
        {
            try
            {
                await _personaJBL.Modificar(personaJ);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaJController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var personaJ = await _personaJBL.ObtenerPorId(new PersonaJ { Id = id });
            return View(personaJ);
        }

        // POST: PersonaJController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaJ personaJ)
        {
            try
            {
                await _personaJBL.Eliminar(personaJ);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
