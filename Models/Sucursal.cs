using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Sucursal
    {
        // Atributos
        private int _idSucrusal;
        //[Required]
        private string? _direccionSucursal;
        //[Required]
        private int _telefonoSucursal;
        // Propiedades
        public int IdSucursal { get => _idSucrusal; set => _idSucrusal = value; }
        [Required]
        public string? DireccionSucursal { get => _direccionSucursal; set => _direccionSucursal = value; }
        [Required]
        public int TelefonoSucursal { get => _telefonoSucursal; set => _telefonoSucursal = value; }
        // Constructor
        public Sucursal() { }
        public Sucursal(int id, string direccion, int telefono)
        {
            IdSucursal = id;
            _direccionSucursal = direccion;
            _telefonoSucursal = telefono;
        }
    }
}
