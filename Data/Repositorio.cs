using ProyectoTalleres.Models;
using System.Collections.Generic;

namespace ProyectoTalleres.Data
{
    public class InscripcionRepository
    {
        // Lista temporal en memoria para guardar todas las inscripciones
        private static List<Inscripcion> _inscripciones = new List<Inscripcion>();

        // Método para agregar una inscripción a la lista
        public void AgregarInscripcion(Inscripcion inscripcion)
        {
            _inscripciones.Add(inscripcion);
        }

        // Método para obtener todas las inscripciones guardadas
        public List<Inscripcion> ObtenerInscripciones()
        {
            return _inscripciones;
        }
    }
}