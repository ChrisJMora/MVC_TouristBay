using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Usuario
    {
        // Atributos
        private int _idUsuario;
        private string _nombreUsuario;
        private string _contraseniaUsuario;
        // Propiedades
        [Required]
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        [Required]
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        [Required]
        public string ContraseniaUsuario { get => _contraseniaUsuario; set => _contraseniaUsuario = value; }
        // Constructor
        public Usuario() { }
        public Usuario(int id, string nombre, string contrasenia)
        {
            _idUsuario = id;
            _nombreUsuario=nombre;
            _contraseniaUsuario=contrasenia;
        }
    }
}
