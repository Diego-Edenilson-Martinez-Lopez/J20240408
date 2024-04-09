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
        public async Task<ActionResult> Index(PersonaJ personasJ)

        {
            var clientes = await _personaJBL.Buscar(personasJ);
            return View(clientes); // Cambia personaJ por clientes
        }
 
        // GET: PersonaJController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personasJ = await _personaJBL.ObtenerPorId(new PersonaJ { Id = id });
            return View(personasJ);
        }

        // GET: PersonaJController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaJ personasJ)
        {
            try
            {
                await _personaJBL.Crear(personasJ);
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
        public async Task<ActionResult> Edit(PersonaJ personasJ)
        {
            try
            {
                await _personaJBL.Modificar(personasJ);
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
            var personasJ = await _personaJBL.ObtenerPorId(new PersonaJ { Id = id });
            return View(personasJ);
        }

        // POST: PersonaJController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaJ personasJ)
        {
            try
            {
                await _personaJBL.Eliminar(personasJ);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
