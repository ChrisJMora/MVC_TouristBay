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
                new Ciudad(1,"Quito"),
                new Ciudad(2,"Guayaquil"),
                new Ciudad(3,"Manta"),
                new Ciudad(4,"Cuenca"),
                new Ciudad(5,"Loja"),
                new Ciudad(6,"Galapagos"),
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
