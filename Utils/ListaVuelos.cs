using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaVuelos
    {
        // Atributos
        private static ListaVuelos? _instancia;
        private List<Vuelo> _listaVuelos;

        // Propiedades
        public List<Vuelo> Vuelos { get => _listaVuelos; set => _listaVuelos = value; }
        // Constructor
        private ListaVuelos()
        {
            _listaVuelos = new List<Vuelo> { };
            for (int i = 0; i < 5000; i++)
            {
                int aerolinea = new Random().Next(1,6);
                // HORA Y FECHA
                int diaSalida = new Random().Next(1,30);
                int diaLlegada = new Random().Next(diaSalida + 1,31);
                int hora = new Random().Next(1,23);
                int minuto = new Random().Next(1,58);
                DateTime hfSalida = new DateTime(2023, 10, diaSalida, hora, minuto, 0);
                hora = new Random().Next(hora + 1, 24);
                minuto = new Random().Next(minuto + 1, 59);
                DateTime hfLlegada = new DateTime(2023, 10, diaLlegada, hora, minuto, 0);
                //
                int origen;
                int destino;
                do
                {
                    origen = new Random().Next(1, 7);
                    destino = new Random().Next(1, 7);
                } while (origen - destino == 0);
                // PLAZAS
                int plazas = new Random().Next(1,50);
                int plazasTurista = new Random().Next(30,40);
                // PRECIOS
                double precioEconomico = new Random().Next(100, 200);
                double precioPreferencial = new Random().Next(200, 500);
                // VUELO
                Vuelo vuelo = new Vuelo(i, aerolinea, hfSalida, hfLlegada, origen, destino,
                    plazas, plazasTurista, precioEconomico, precioPreferencial);
                _listaVuelos.Add(vuelo);
            }
        }
        // Métodos
        public static ListaVuelos Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaVuelos();
            }
            return _instancia;
        }
    }
}
