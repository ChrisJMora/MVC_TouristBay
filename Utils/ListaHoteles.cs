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
                new Hotel(1,"Hotel La Basilica","Venezuela N8-26 y Manabi, Quito 170150 Ecuador",1,87519900,100),
                new Hotel(2,"Radisson Hotel Guayaquil",
                "Ciudadela Kennedy Avenida Gral. Francisco Boloña 503A Calle Jorge Insua Hindro, Guayaquil 090510 Ecuador",
                2,87519900,200),
                new Hotel(3,"Eb Hotel by Eurobuilding Quito","Calle 24 de Septiembre S 2-389 Conector Alpachaca, Quito 170907 Ecuador",
                1,87519900,35)
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
