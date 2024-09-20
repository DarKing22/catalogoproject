using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class EstadosRepositorio : IEstadosRepositorio
    {
        private Conexion? conexion = null;

        public EstadosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Estados> Listar()
        {
            return conexion!.Listar<Estados>();
        }

        public Estados Guardar(Estados entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Estados Modificar(Estados entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Estados Borrar(Estados entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
