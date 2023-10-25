using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaTuristas
    {
        // Atributos
        private static ListaTuristas? _instancia;
        private List<Turista> _listaTuristas;
        //Propiedades
        public List<Turista> Turistas { get => _listaTuristas; set => _listaTuristas = value; }
        //Constructor
        private ListaTuristas()
        {
            //Turistas
            Turista t1 = new Turista(1, "Christian", "Jácome", "cj@gmail.com", 123, 0, 0, 1);
            Turista t2 = new Turista(2 ,"David", "Pérez", "dp@gmail.com", 456, 0, 0, 2);
            Turista t3 = new Turista(3 ,"Xavier", "Romo", "xr@gmail.com", 789, 0, 0, 3);
            Turista t4 = new Turista(4 ,"Sofía", "Tamayo", "st@gmail.com", 123, 0, 0, 4);
            Turista t5 = new Turista(5 ,"Pedro", "Rojas", "pr@gmail.com", 456, 0, 0, 5);
            _listaTuristas = new List<Turista> { t1, t2, t3, t4, t5 };
        }
        // Métodos
        public static ListaTuristas Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaTuristas();
            }
            return _instancia;
        }
    }
}
