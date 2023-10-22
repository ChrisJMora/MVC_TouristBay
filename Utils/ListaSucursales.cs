using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaSucursales
    {
        // Atributos
        private static ListaSucursales? _instancia;
        private List<Sucursal> _listaSucursales = new List<Sucursal>();
        // Propiedades
        public List<Sucursal> Sucursales { get => _listaSucursales; }
        // Constructor
        private ListaSucursales()
        {
            _listaSucursales = new List<Sucursal>()
            {
                new Sucursal("Av. América N33-42 y Rumipamba (frente al Colegio San Gabriel)",0999809269),
                new Sucursal("Cosme Renella Oe3-136 y Av. Brasil Frente al UPC de la Av. Brasil",0983081000),
                new Sucursal("Av. De Los Granados E14-748 Y Shuaras (Junto a la Fybeca)",0923711441)
            };
        }
        // Métodos
        public ListaSucursales Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaSucursales();
            }
            return _instancia;
        }
    }
}
