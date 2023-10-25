using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TouristBay.Models;
using MVC_TouristBay.Utils;
using System.Runtime.InteropServices;

namespace MVC_TouristBay.Controllers
{
    public class VueloController : Controller
    {
        private List<Vuelo> _vuelos = ListaVuelos.Instancia().Vuelos;
        // GET: VueloController
        public IActionResult Index()
        {
            Console.WriteLine("En la vista de Vuelo");
            return View();
        }

        [HttpPost]
        public IActionResult Index(int Origen, int Destino, DateOnly FechaSalida)
        {
            Console.WriteLine("En el post de Vuelo");
            Console.WriteLine($"Origen:{Origen}, Destino:{Destino}");
            Console.WriteLine($"Fecha de Salida:{FechaSalida}");
            List<Vuelo> vuelos = _vuelos.FindAll(x => x.OrigenVuelo == Origen &&
            x.DestinoVuelo == Destino && DateOnly.FromDateTime(x.FHsalidaVuelo) == FechaSalida);
            if (vuelos.Count == 0)
            {
                Console.WriteLine("No hay vuelos disponibles");
            }
            return View(vuelos);
        }

        public IActionResult ReservarAsientos(int IdVuelo, bool ClaseVuelo)
        {
            Console.WriteLine($"IdVuelo:{IdVuelo}");
            Console.WriteLine($"ClaseVuelo:{ClaseVuelo}");
            Vuelo? vuelo = _vuelos.Find(x => x.IdVuelo == IdVuelo);
            if (vuelo != null)
            {
                vuelo.ClaseVuelo = ClaseVuelo;
                return View(vuelo);
            }
            return View();
        }

        // GET: VueloController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VueloController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VueloController/Create
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

        // GET: VueloController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VueloController/Edit/5
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

        // GET: VueloController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VueloController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
