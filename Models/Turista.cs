using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Turista
    {
        // Atributos
        private int _idTurista;
        [Required]
        private string _nombreTurista;
        [Required]
        private string _apellidoTurista;
        [Required]
        private string _emailTurista;
        [Required]
        private int _telefonoTurista;
        [Required]
        private int _sucursalTurista;
        private int _hotelTurista;
        private int _idUsuario;
        // Propiedades
        public int IdTurista { get => _idTurista; set => _idTurista = value; }
        public string NombreTurista { get => _nombreTurista; set => _nombreTurista = value;}
        public string ApellidoTurista { get => _apellidoTurista; set => _apellidoTurista = value; }
        public string EmailTurista { get => _emailTurista; set => _emailTurista = value; }
        public int TelefonoTurista { get => _telefonoTurista; set => _telefonoTurista = value; }
        public int SucursalTurista { get => _sucursalTurista; set => _sucursalTurista = value; }
        public int HotelTurista { get => _hotelTurista; set => _hotelTurista = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        // Constructor
        public Turista() { }
        public Turista(string nombre, string apellido, string email, int telefono,
            int sucursal, int hotel, int idUsuario)
        {
            _idTurista = 0;
            _nombreTurista = nombre;
            _apellidoTurista= apellido;
            _emailTurista= email;
            _telefonoTurista= telefono;
            _sucursalTurista= sucursal;
            _hotelTurista= hotel;
            _idUsuario= idUsuario;
        }
        //Métodos
        public string NombreCompleto()
        {
            return $"{_nombreTurista} {_apellidoTurista}";
        }
    }
}
