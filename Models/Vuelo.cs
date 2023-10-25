using MVC_TouristBay.Utils;
using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Vuelo
    {
        // Atributos
        [Required]
        private int _idVuelo;
        [Required]
        private int _aerolineaVuelo;
        [Required]
        private DateTime _fhSalidaVuelo;
        [Required]
        private DateTime _fhllegadaVuelo;
        [Required]
        private int _origenVuelo;
        [Required]
        private int _destinoVuelo;
        [Required]
        private int _plazasEconomicoVuelo;
        [Required]
        private int _plazasPreferencialVuelo;
        [Required]
        private double _precioEconomicoVuelo;
        [Required]
        private double _precioPreferencialVuelo;
        private bool _claseVuelo;
        // Propiedades
        public int IdVuelo { get => _idVuelo; set => _idVuelo = value; }
        public int AerolineaVuelo { get => _aerolineaVuelo; set => _aerolineaVuelo = value; }
        public DateTime FHsalidaVuelo { get => _fhSalidaVuelo; set => _fhSalidaVuelo = value; }
        public DateTime FHllegadaVuelo { get => _fhllegadaVuelo; set => _fhllegadaVuelo = value; }
        public int OrigenVuelo { get => _origenVuelo; set => _origenVuelo = value; }
        public int DestinoVuelo { get => _destinoVuelo; set => _destinoVuelo = value; }
        public int PlazasEconomicoVuelo { get => _plazasEconomicoVuelo; set => _plazasEconomicoVuelo = value; }
        public int PlazasPreferencialVuelo { get => _plazasPreferencialVuelo; set => _plazasPreferencialVuelo = value; }
        public double PrecioEconomicoVuelo { get => _precioEconomicoVuelo; set => _precioEconomicoVuelo = value; }
        public double PrecioPreferencialVuelo { get => _precioPreferencialVuelo; set => _precioPreferencialVuelo = value; }
        public bool ClaseVuelo { get => _claseVuelo; set => _claseVuelo = value; }
        // Constructor
        public Vuelo(int id, int aerolinea, DateTime fhsalida, DateTime fhllegada,
            int origen, int destino, int plazasEconomico, int plazasPreferencial,
            double precioEconomico, double precioPreferencial)
        {
            _idVuelo = id;
            _aerolineaVuelo = aerolinea;
            _fhSalidaVuelo = fhsalida;
            _fhllegadaVuelo = fhllegada;
            _origenVuelo = origen;
            _destinoVuelo = destino;
            _plazasEconomicoVuelo = plazasEconomico;
            _plazasPreferencialVuelo = plazasPreferencial;
            _precioEconomicoVuelo = precioEconomico;
            _precioPreferencialVuelo = precioPreferencial;
        }
        // Metodos
        public string ObtenerCiudad(int IdCiudad)
        {
            List<Ciudad> ciudades = ListaCiudades.Instancia().Ciudades;
            Ciudad? ciudad = ciudades.Find(x => x.IdCiudad == IdCiudad);
            if (ciudad != null)
            {
                return $"{ciudad.NombreCiudad} ({ciudad.AbreviaturaCiudad})";
            }
            return "";
        }
        public string ObtenerFecha(DateTime fecha)
        {
            return fecha.ToString("dddd, dd MMMM yyyy");
        }
        public string ObtenerHora(DateTime hora)
        {
            return hora.ToString("h:mm tt");
        }
        public string ObtenerAerolinea()
        {
            List<Aerolinea> aerolineas = ListaAerolineas.Instancia().Aerolineas;
            Aerolinea? aerolinea = aerolineas.Find(x => x.IdAerolinea == _aerolineaVuelo);
            if (aerolinea != null)
            {
                return aerolinea.NombreAerolinea;
            }
            return "";
        }
        public string ObtenerTiempoVuelo()
        {
            return (_fhllegadaVuelo - _fhSalidaVuelo).ToString(@"dd\d\ hh\h\ mm\m\ ");
        }
        public double ObtenerPrecio()
        {
            if (_claseVuelo)
            {
                return _precioEconomicoVuelo;
            }
            return _precioPreferencialVuelo;
        }
        public int ObtenerPlazas()
        {
            if (_claseVuelo)
            {
                return _plazasEconomicoVuelo;
            }
            return _plazasPreferencialVuelo;
        }
        public string ObtenerClase()
        {
            if (_claseVuelo)
            {
                return "Económico";
            }
            return "Preferencial";
        }
    }
}