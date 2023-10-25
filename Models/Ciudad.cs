namespace MVC_TouristBay.Models
{
    public class Ciudad
    {
        // Atributos
        private int _idCiudad;
        private string _nombreCiudad;
        private string _abreviaturaCiudad;
        // Propiedades
        public int IdCiudad { get => _idCiudad; set => _idCiudad = value; }
        public string NombreCiudad { get => _nombreCiudad; set => _nombreCiudad = value; }
        public string AbreviaturaCiudad { get => _abreviaturaCiudad; set => _abreviaturaCiudad = value; }
        //Constructor
        public Ciudad(int id, string nombre, string abreviaturaCiudad)
        {
            _idCiudad = id;
            _nombreCiudad = nombre;
            _abreviaturaCiudad = abreviaturaCiudad;
        }
    }
}
