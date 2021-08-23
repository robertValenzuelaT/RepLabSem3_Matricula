using Microsoft.AspNetCore.Mvc;
using RepLabSem3_Matricula.Models;
using RepLabSem3_Matricula.Data;

namespace RepLabSem3_Matricula.Controllers
{
    public class AlumnoController:Controller
    {
         private readonly ApplicationDbContext _context;

        public AlumnoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Alumno objAlumno)
        {
            _context.Add(objAlumno);
            _context.SaveChanges();
            ViewData["Message"] = "El Alumno ya esta matriculado";
            return View("Index");
        }
    }
}