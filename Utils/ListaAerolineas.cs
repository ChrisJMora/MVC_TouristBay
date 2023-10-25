using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaAerolineas
    {
        // Atributos
        private static ListaAerolineas? _instancia;
        private List<Aerolinea> _listaAerolineas = new List<Aerolinea>();
        // Propiedades
        public List<Aerolinea> Aerolineas { get => _listaAerolineas; }
        // Constructor
        private ListaAerolineas()
        {
            _listaAerolineas = new List<Aerolinea>()
            {
                new Aerolinea(1,"Latam Airlines"),
                new Aerolinea(2,"Avianca Airlines"),
                new Aerolinea(3,"Tame Airlines"),
                new Aerolinea(4,"Copa Airlines"),
                new Aerolinea(5,"Equair Airlines"),
            };
        }
        // Métodos
        public static ListaAerolineas Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaAerolineas();
            }
            return _instancia;
        }
        
    }
}
