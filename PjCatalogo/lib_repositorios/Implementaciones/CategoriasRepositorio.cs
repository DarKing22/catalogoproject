using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class CategoriasRepositorio : ICategoriasRepositorio
    {
        private Conexion? conexion = null;

        public CategoriasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Categorias> Listar()
        {
            return conexion!.Listar<Categorias>();
        }

        public Categorias Guardar(Categorias entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Categorias Modificar(Categorias entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Categorias Borrar(Categorias entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
