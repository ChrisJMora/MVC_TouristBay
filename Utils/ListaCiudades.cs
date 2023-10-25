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
                new Ciudad(1,"Quito","UIO"),
                new Ciudad(2,"Guayaquil","GYE"),
                new Ciudad(3,"Esmeraldas","ESM"),
                new Ciudad(4,"Manta","MEC"),
                new Ciudad(5,"Cuenca","CUE"),
                new Ciudad(6,"Galapagos","GPS"),
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
