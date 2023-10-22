namespace MVC_TouristBay.Models
{
    public class Ciudad
    {
        // Atributos
        private int _idCiudad;
        private string _nombreCiudad;
        // Propiedades
        public int IdCiudad { get => _idCiudad; set => _idCiudad = value; }
        public string NombreCiudad { get => _nombreCiudad; set => _nombreCiudad = value; }
        //Constructor
        public Ciudad(string nombre)
        {
            _idCiudad = 0;
            _nombreCiudad = nombre;
        }
    }
}
