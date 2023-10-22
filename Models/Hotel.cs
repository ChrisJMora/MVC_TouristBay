using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Hotel
    {
        // Atributos
        private int _idHotel;
        [Required]
        private string _nombreHotel;
        [Required]
        private string _direccionHotel;
        [Required]
        private int _idCiudadHotel;
        [Required]
        private int _telefonoHotel;
        [Required]
        private int _plazasHotel;
        // Propiedades
        public int IdHotel { get => _idHotel; set => _idHotel = value; }
        public string NombreHotel { get => _nombreHotel; set => _nombreHotel = value;}
        public string DireccionHotel { get => _direccionHotel; set => _direccionHotel = value; }
        public int IdCiudadHotel { get => _idCiudadHotel; set => _idCiudadHotel = value; }
        public int TelefonoHotel { get => _telefonoHotel; set => _telefonoHotel = value; }
        public int PlazasHotel { get => _plazasHotel; set => _plazasHotel = value; }
        // Constructor
        public Hotel(string nombre, string direccion, int idCiudad, int telefono, int plazas)
        {
            _idHotel = 0;
            _nombreHotel = nombre;
            _direccionHotel = direccion;
            _idCiudadHotel= idCiudad;
            _telefonoHotel = telefono;
            _plazasHotel = plazas;
        }
    }
}
