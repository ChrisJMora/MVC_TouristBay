using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaCiudades
    {
        // Atributos
        private static ListaCiudades? _instancia;
        private List<Ciudad> _listaCiudades = new List<Ciudad>();
        // Propiedades
        public List<Ciudad> Ciudades { get => _listaCiudades; }
        // Constructor
        private ListaCiudades()
        {
            _listaCiudades = new List<Ciudad>()
            {
                new Ciudad("Quito"),
                new Ciudad("Guayaquil"),
                new Ciudad("Manta"),
                new Ciudad("Cuenca"),
                new Ciudad("Loja"),
                new Ciudad("Galapagos"),
            };
        }
        // Métodos
        public static ListaCiudades Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaCiudades();
            }
            return _instancia;
        }
    }
}
