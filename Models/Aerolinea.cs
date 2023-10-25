namespace MVC_TouristBay.Models
{
    public class Aerolinea
    {
        // Atributos
        private int _idAerolinea;
        private string _nombreAerolinea;
        // Propiedades
        public int IdAerolinea { get => _idAerolinea; set => _idAerolinea = value; }
        public string NombreAerolinea { get => _nombreAerolinea; set => _nombreAerolinea = value; }
        //Constructor
        public Aerolinea(int id, string nombre)
        {
            _idAerolinea = id;
            _nombreAerolinea = nombre;
        }
    }
}
