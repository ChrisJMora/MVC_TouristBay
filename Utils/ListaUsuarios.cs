using MVC_TouristBay.Models;

namespace MVC_TouristBay.Utils
{
    public class ListaUsuarios
    {
        // Atributos
        private static ListaUsuarios? _instancia;
        private List<Usuario> _listaUsuarios;
        // Propiedades
        public List<Usuario> Usuarios { get => _listaUsuarios; set => _listaUsuarios = value; }
        // Constructor
        private ListaUsuarios()
        {
            // Usuarios
            Usuario u1 = new Usuario(1,"cj2003","123");
            Usuario u2 = new Usuario(2,"dp2003","123");
            Usuario u3 = new Usuario(3,"xr2003","123");
            Usuario u4 = new Usuario(4,"st2003","123");
            Usuario u5 = new Usuario(5,"pr2003","123");
            _listaUsuarios = new List<Usuario> { u1, u2, u3, u4, u5 };
        }
        // Métodos
        public static ListaUsuarios Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ListaUsuarios();
            }
            return _instancia;
        }
    }
}
