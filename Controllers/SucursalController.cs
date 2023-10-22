using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TouristBay.Models;
using MVC_TouristBay.Utils;

namespace MVC_TouristBay.Controllers
{
    public class SucursalController : Controller
    {
        private List<Sucursal> sucursales = ListaSucursales.Instancia().Sucursales;
        // GET: SucursalController
        public ActionResult Index()
        {
            return View(sucursales);
        }

        // GET: SucursalController/Details/5
        public ActionResult Details(int IdSucursal)
        {
            Sucursal? sucursal = sucursales.Find(x => x.IdSucursal == IdSucursal);
            if (sucursal != null)
            {
                return View(sucursal);
            }
            return RedirectToAction("Index");
        }

        // GET: SucursalController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Sucursal sucursal)
        {
            if (sucursal != null)
            {
                sucursal.IdSucursal = sucursales.Count() + 1;
                ListaSucursales.Instancia().Sucursales.Add(sucursal);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: SucursalController/Edit/5
        public ActionResult Edit(int IdSucursal)
        {
            Sucursal? sucursal = sucursales.Find(x => x.IdSucursal == IdSucursal);
            if (sucursal != null)
            {
                return View(sucursal);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Sucursal nuevaSucursal)
        {
            Sucursal? antiguaSucursal = sucursales.Find(x => 
                x.IdSucursal == nuevaSucursal.IdSucursal);
            if (antiguaSucursal != null)
            {
                antiguaSucursal.DireccionSucursal = nuevaSucursal.DireccionSucursal;
                antiguaSucursal.TelefonoSucursal = nuevaSucursal.TelefonoSucursal;
                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: SucursalController/Delete/5
        public ActionResult Delete(int IdSucursal)
        {
            Sucursal? sucursal = sucursales.Find(x => x.IdSucursal == IdSucursal);
            if (sucursal != null)
            {
                ListaSucursales.Instancia().Sucursales.Remove(sucursal);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
