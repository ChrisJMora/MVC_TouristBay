using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TouristBay.Models;
using MVC_TouristBay.Utils;

namespace MVC_TouristBay.Controllers
{
    public class TuristaController : Controller
    {
        List<Turista> turistas = ListaTuristas.Instancia().Turistas;
        List<Usuario> usuarios = ListaUsuarios.Instancia().Usuarios;
        // GET: TuristaController
        public IActionResult Index(int idUsuario)
        {
            Console.WriteLine("En la vista de Index");
            Console.WriteLine($"IdUsuario:{idUsuario}");
            Turista? turista = turistas.Find(x => x.IdUsuario == idUsuario);
            if (turista != null)
            {
                Console.WriteLine($"Turista:{turista.NombreCompleto()}");
                return View(turista);
            }
            Console.WriteLine("Turista no encontrado");
            return View(turista);
        }

        // GET: TuristaController
        public IActionResult Registro()
        {
            Console.WriteLine("En la vista de Registro");
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario nuevoUsuario)
        {
            Console.WriteLine($"Usuario:{nuevoUsuario.NombreUsuario}," + $"Contraseña:{nuevoUsuario.ContraseniaUsuario}");
            // validar creedenciales
            Usuario? usuario = usuarios.Find(x => x.NombreUsuario == nuevoUsuario.NombreUsuario);
            if (usuario != null)
            {
                Console.WriteLine("El nombre de usuario ya existe");
                return View(usuario);
            }
            return RedirectToAction("DatosPersonales", nuevoUsuario);
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
            usuario.IdUsuario = usuarios.Count() + 1;
            turista.IdUsuario = usuario.IdUsuario;
            usuarios.Add( usuario );
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
        public IActionResult InicioSesion(Usuario nuevoUsuario)
        {
            Console.WriteLine("En el post de Inicio de Sesión");
            Console.WriteLine($"Usuario:{nuevoUsuario.NombreUsuario}," + $"Contraseña:{nuevoUsuario.ContraseniaUsuario}");
            // Validar Creedenciales
                // Buscar Usuario
            Usuario? usuario = usuarios.Find(x => x.NombreUsuario == nuevoUsuario.NombreUsuario);
            if (usuario == null )
            {
                Console.WriteLine("Usuario no encontrado");
                return View(nuevoUsuario);
            }
                // Verificar Contraseña
            if (usuario.ContraseniaUsuario != nuevoUsuario.ContraseniaUsuario)
            {
                Console.WriteLine("Contraseña Incorrecta");
                return View(nuevoUsuario);
            }
            // Usuario Verificado
            Console.WriteLine("Usuario verificado");
            Console.WriteLine($"IdUsuario:{usuario.IdUsuario}");
            return RedirectToAction("Index", new { usuario.IdUsuario });
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
