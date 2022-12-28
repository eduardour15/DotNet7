using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba2.Datos;
using Prueba2.Models;
using System.Diagnostics;

namespace Prueba2.Controllers
{
    public class InicioController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        public InicioController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearUsuario(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Contacto.Add(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var contacto = _contexto.Contacto.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = _contexto.Contacto.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = _contexto.Contacto.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        [HttpPost, ActionName("Borrar")]
        public async Task<IActionResult> BorrarContacto(int? id)
        {
            var contacto = await _contexto.Contacto.FindAsync(id);
            if(contacto == null)
            {
                return View();
            }
            //Borrado 
            _contexto.Contacto.Remove(contacto);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}