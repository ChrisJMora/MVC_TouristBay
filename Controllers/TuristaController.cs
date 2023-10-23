using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TouristBay.Models;
using MVC_TouristBay.Utils;

namespace MVC_TouristBay.Controllers
{
    public class TuristaController : Controller
    {
        List<Turista> turistas = ListaTuristas.Instancia().Turistas;
        // GET: TuristaController
        public IActionResult Index(Turista turista)
        {
            Console.WriteLine("En la vista de Index");
            return View(turista);
        }

        // GET: TuristaController
        public IActionResult Registro()
        {
            Console.WriteLine("En la vista de Registro");
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario usuario)
        {
            Console.WriteLine($"Usuario:{usuario.NombreUsuario}," + $"Contraseña:{usuario.ContraseniaUsuario}");
            return RedirectToAction("DatosPersonales", usuario);
        }

        // GET: TuristaController
        public IActionResult DatosPersonales()
        {
            Console.WriteLine("En la vista de Datos Personales");
            return View();
        }

        [HttpPost]
        public IActionResult DatosPersonales(Usuario usuario, Turista turista)
        {
            Console.WriteLine("En el post de Datos Personales");
            Console.WriteLine($"Usuario:{usuario.NombreUsuario}," + $"Contraseña:{usuario.ContraseniaUsuario}");
            Console.WriteLine($"Turista:{turista.NombreTurista} {turista.ApellidoTurista}");
            turista.UsuarioTurista = usuario;
            turistas.Add( turista );
            return RedirectToAction("InicioSesion");
        }

        // GET: TuristaController
        public IActionResult InicioSesion()
        {
            Console.WriteLine("En la vista de Inicio de Sesión");
            return View();
        }

        [HttpPost]
        public IActionResult InicioSesion(Usuario usuario)
        {
            Console.WriteLine("En el post de Inicio de Sesión");
            Console.WriteLine($"Usuario:{usuario.NombreUsuario}," + $"Contraseña:{usuario.ContraseniaUsuario}");
            // validar creedenciales
            Turista? turista = turistas.Find(x => 
            x.UsuarioTurista.NombreUsuario == usuario.NombreUsuario &&
            x.UsuarioTurista.ContraseniaUsuario == usuario.ContraseniaUsuario);
            if (turista == null )
            {
                Console.WriteLine("Turista no encontrado");
                return View(usuario);
            }
            Console.WriteLine("Turista encontrado");
            return RedirectToAction("Index", turista);
        }

        // GET: TuristaController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: TuristaController/Create
        public IActionResult Create()
        {
            Console.WriteLine("En Create => Turista");
            return View();
        }

        // GET: TuristaController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // GET: TuristaController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
