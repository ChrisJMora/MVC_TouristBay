using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaTuristas
    {
        // Atributos
        private static ListaTuristas? _instancia;
        private List<Turista> _listaTuristas = new List<Turista>();
        //Propiedades
        public List<Turista> Turistas { get => _listaTuristas; set => _listaTuristas = value; }
        //Constructor
        private ListaTuristas()
        {
            //Turistas
            Turista t1 = new Turista("Christian", "Jácome", "cj@gmail.com",
                "Monteserrin", 123, 0, 0, new Usuario("cj2003","123"));
            Turista t2 = new Turista("David", "Pérez", "dp@gmail.com",
                "Calderón", 456, 0, 0, new Usuario("dp2003", "123"));
            Turista t3 = new Turista("Xavier", "Romo", "xr@gmail.com",
                "Quiche", 789, 0, 0, new Usuario("xr2003", "123"));
            Turista t4 = new Turista("Sofía", "Tamayo", "st@gmail.com",
                "Checa", 123, 0, 0, new Usuario("st2003", "123"));
            Turista t5 = new Turista("Pedro", "Rojas", "pr@gmail.com",
                "Nayón", 456, 0, 0, new Usuario("pr2003", "123"));
            _listaTuristas = new List<Turista>
            {
                t1, t2, t3, t4, t5
            };
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
