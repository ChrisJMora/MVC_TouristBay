using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Usuario
    {
        // Atributos
        private string _nombreUsuario;
        private string _contraseniaUsuario;
        // Propiedades
        [Required]
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        [Required]
        public string ContraseniaUsuario { get => _contraseniaUsuario; set => _contraseniaUsuario = value; }
        //Constructor
        public Usuario() { }
        public Usuario(string nombre, string contrasenia)
        {
            _nombreUsuario=nombre;
            _contraseniaUsuario=contrasenia;
        }
        //Métodos
        public void registrarNombreUsuario(string nombreUsuario)
        {
            _nombreUsuario = nombreUsuario;
        }
        public void registrarContraseniaUsuario(string contraseniaUsuario)
        {
            _contraseniaUsuario = contraseniaUsuario;
        }
    }
}
