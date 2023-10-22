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
                new Sucursal(1,"Av. América N33-42 y Rumipamba (frente al Colegio San Gabriel)",99809269),
                new Sucursal(2,"Cosme Renella Oe3-136 y Av. Brasil Frente al UPC de la Av. Brasil",83081000),
                new Sucursal(3,"Av. De Los Granados E14-748 Y Shuaras (Junto a la Fybeca)",23711441)
            };
        }
        // Métodos
        public static ListaSucursales Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaSucursales();
            }
            return _instancia;
        }
    }
}
