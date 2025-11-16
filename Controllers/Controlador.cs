using Microsoft.AspNetCore.Mvc;
using ProyectoTalleres.Data;
using ProyectoTalleres.Models;
using System;

namespace ProyectoTalleres.Controllers
{
    public class InscripcionController : Controller
    {
        // Instancia del repositorio para guardar y obtener datos
        private readonly InscripcionRepository _repo = new InscripcionRepository();

        // Página principal: muestra la lista de inscripciones
        public IActionResult Index()
        {
            var inscripciones = _repo.ObtenerInscripciones();
            return View(inscripciones);
        }

        // Muestra el formulario de inscripción
        public IActionResult Crear()
        {
            return View();
        }

        // Recibe el formulario (POST)
        [HttpPost]
        public IActionResult Crear(Inscripcion inscripcion)
        {
            // Validación: fecha no puede ser pasada
            if (inscripcion.FechaTaller < DateTime.Today)
            {
                ModelState.AddModelError("FechaTaller", "La fecha no puede ser pasada");
            }

            // Validación: términos obligatorios
            if (!inscripcion.AceptaTerminos)
            {
                ModelState.AddModelError("AceptaTerminos", "Debe aceptar los términos y condiciones");
            }

            // Si hay errores, volver a mostrar el formulario
            if (!ModelState.IsValid)
            {
                return View(inscripcion);
            }

            // Guardar inscripción
            _repo.AgregarInscripcion(inscripcion);

            // Mensaje de éxito
            TempData["mensaje"] = "¡Inscripción realizada con éxito!";

            // Redirige al listado
            return RedirectToAction("Index");
        }
    }
}