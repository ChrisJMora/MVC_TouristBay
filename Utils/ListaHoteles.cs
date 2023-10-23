using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaHoteles
    {
        // Atributos
        private static ListaHoteles? _instancia;
        private List<Hotel> _listaHoteles = new List<Hotel>();
        // Propiedades
        public List<Hotel> Hoteles { get => _listaHoteles; }
        // Constructor
        private ListaHoteles()
        {
            _listaHoteles = new List<Hotel>()
            {
                new Hotel(1,"Hotel La Basilica","Venezuela N8-26 y Manabi, Quito 170150 Ecuador",
                1,87519900,100,"https://media-cdn.tripadvisor.com/media/photo-s/18/14/b4/73/views-from-the-roof-deck.jpg"),
                new Hotel(2,"Radisson Hotel Guayaquil",
                "Ciudadela Kennedy Avenida Gral. Francisco Boloña 503A Calle Jorge Insua Hindro, Guayaquil 090510 Ecuador",
                2,87519900,200,"https://cf.bstatic.com/xdata/images/hotel/max1024x768/104805398.jpg?k=aee4fa727d3f1a89bbeba1440b7273614aaef51e0fb8c181d80b2708d602021d&o=&hp=1"),
                new Hotel(3,"Eb Hotel by Eurobuilding Quito","Calle 24 de Septiembre S 2-389 Conector Alpachaca, Quito 170907 Ecuador",
                1,87519900,35,"https://static11.com-hotel.com/uploads/hotel/128161/photo/eb-airport-quito-hotel-eurobuilding_154079175920.jpg"),
            };
        }
        // Métodos
        public static ListaHoteles Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaHoteles();
            }
            return _instancia;
        }
    }
}
