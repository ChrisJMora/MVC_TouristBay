using System.ComponentModel.DataAnnotations;

namespace MVC_TouristBay.Models
{
    public class VueloTurista
    {
        // Atributos
        private int _idVueloTurista;
        [Required]
        private int _vuelo;
        [Required]
        private int _turista;
        // Propiedades
        public int IdVueloTurista { get => _idVueloTurista; set => _idVueloTurista = value; }
        public int Vuelo { get => _vuelo; set => _vuelo = value; }
        public int Turista { get => _turista; set => _turista = value; }
        //Constructor
        public VueloTurista(int vuelo, int turista)
        {
            _idVueloTurista = 0;
            _vuelo = vuelo;
            _turista = turista;
        }
    }
}
