﻿using MVC_TouristBay.Utils;
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
        private int _ciudadHotel;
        [Required]
        private int _telefonoHotel;
        [Required]
        private int _plazasHotel;
        private string _imagenHotel;
        // Propiedades
        public int IdHotel { get => _idHotel; set => _idHotel = value; }
        public string NombreHotel { get => _nombreHotel; set => _nombreHotel = value;}
        public string DireccionHotel { get => _direccionHotel; set => _direccionHotel = value; }
        public int CiudadHotel { get => _ciudadHotel; set => _ciudadHotel = value; }
        public int TelefonoHotel { get => _telefonoHotel; set => _telefonoHotel = value; }
        public int PlazasHotel { get => _plazasHotel; set => _plazasHotel = value; }
        public string ImagenHotel { get => _imagenHotel; set => _imagenHotel = value; }
        // Constructor
        public Hotel() {}
        public Hotel(int id, string nombre, string direccion, int idCiudad,
            int telefono, int plazas, string imagen)
        {
            _idHotel = id;
            _nombreHotel = nombre;
            _direccionHotel = direccion;
            _ciudadHotel= idCiudad;
            _telefonoHotel = telefono;
            _plazasHotel = plazas;
            _imagenHotel = imagen;
        }
        // Métodos
        public string obtenerCiudad()
        {
            List<Ciudad> ciudades = ListaCiudades.Instancia().Ciudades;
            Ciudad? ciudad = ciudades.Find(x => x.IdCiudad == _ciudadHotel);
            if (ciudad != null)
            {
                return ciudad.NombreCiudad;
            }
            return "";
        }
    }
}
