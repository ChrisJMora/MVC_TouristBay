using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Vuelo
    {
        // Atributos
        private int _idVuelo;
        [Required]
        private DateTime _fechaHoraVuelo;
        [Required]
        private int _origenVuelo;
        [Required]
        private int _destinoVuelo;
        [Required]
        private int _plazasVuelo;
        [Required]
        private int _plazasTuristaVuelo;
        [Required]
        private bool _tipoVuelo; // True: Turista ; False: Primera Clase
        // Propiedades
        public int IdVuelo { get => _idVuelo; set => _idVuelo = value; }
        public DateTime FechaHoraVuelo { get => _fechaHoraVuelo; set => _fechaHoraVuelo = value; }
        public int OrigenVuelo { get => _origenVuelo; set => _origenVuelo = value; }
        public int DestinoVuelo { get => _destinoVuelo; set => _destinoVuelo = value; }
        public int PlazasVuelo { get => _plazasVuelo; set => _plazasVuelo = value; }
        public int PlazasTuristaVuelo { get => _plazasTuristaVuelo; set => _plazasTuristaVuelo = value; }
        public bool TipoVuelo { get => _tipoVuelo; set => _tipoVuelo = value; }
        //Constructor
        public Vuelo(DateTime fechaHora, int origen, int destino, int plazas, int plazasTurista, bool tipo)
        {
            _idVuelo = 0;
            _fechaHoraVuelo = fechaHora;
            _origenVuelo = origen;
            _destinoVuelo = destino;
            _plazasVuelo = plazas;
            _plazasTuristaVuelo = plazasTurista;
            _tipoVuelo = tipo;
        }
    }
}