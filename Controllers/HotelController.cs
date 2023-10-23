using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TouristBay.Models;
using MVC_TouristBay.Utils;

namespace MVC_TouristBay.Controllers
{
    public class HotelController : Controller
    {
        private List<Hotel> _hoteles = ListaHoteles.Instancia().Hoteles;

        // GET: SucursalController
        public ActionResult Index()
        {
            return View(_hoteles);
        }

        // GET: SucursalController/Details/5
        public ActionResult Details(int IdHotel)
        {
            Hotel? hotel = _hoteles.Find(x => x.IdHotel == IdHotel);
            if (hotel != null)
            {
                return View(hotel);
            }
            return RedirectToAction("Index");
        }

        // GET: SucursalController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Hotel hotel)
        {
            if (hotel != null)
            {
                hotel.IdHotel = _hoteles.Count() + 1;
                _hoteles.Add(hotel);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: SucursalController/Edit/5
        public ActionResult Edit(int IdHotel)
        {
            Hotel? hotel = _hoteles.Find(x => x.IdHotel == IdHotel);
            if (hotel != null)
            {
                return View(hotel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Hotel nuevoHotel)
        {
            Hotel? antiguoHotel = _hoteles.Find(x => 
                x.IdHotel == nuevoHotel.IdHotel);
            if (antiguoHotel != null)
            {
                antiguoHotel.NombreHotel = nuevoHotel.NombreHotel;
                antiguoHotel.DireccionHotel = nuevoHotel.DireccionHotel;
                antiguoHotel.CiudadHotel = nuevoHotel.CiudadHotel;
                antiguoHotel.TelefonoHotel = nuevoHotel.TelefonoHotel;
                antiguoHotel.PlazasHotel = nuevoHotel.PlazasHotel;

                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: SucursalController/Delete/5
        public ActionResult Delete(int IdHotel)
        {
            Hotel? hotel = _hoteles.Find(x => x.IdHotel == IdHotel);
            if (hotel != null)
            {
                _hoteles.Remove(hotel);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
