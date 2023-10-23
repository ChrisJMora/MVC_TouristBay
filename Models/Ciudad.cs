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
        public Ciudad(int id, string nombre)
        {
            _idCiudad = id;
            _nombreCiudad = nombre;
        }
    }
}
