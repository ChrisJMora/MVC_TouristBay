﻿using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class Sucursal
    {
        // Atributos
        private int _idSucrusal;
        [Required]
        private string _direccionSucursal;
        [Required]
        private int _telefonoSucursal;
        // Propiedades
        public int IdSucursal { get => _idSucrusal; set => _idSucrusal = value; }
        public string DireccionSucursal { get => _direccionSucursal; set => _direccionSucursal = value; }
        public int TelefonoSucursal { get => _telefonoSucursal; set => _telefonoSucursal = value; }
        // Constructor
        public Sucursal(string direccion, int telefono)
        {
            IdSucursal = 0;
            _direccionSucursal = direccion;
            _telefonoSucursal = telefono;
        }
    }
}