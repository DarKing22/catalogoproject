using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class FabricantesRepositorio : IFabricantesRepositorio
    {
        private Conexion? conexion = null;

        public FabricantesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Fabricantes> Listar()
        {
            return conexion!.Listar<Fabricantes>();
        }

        public Fabricantes Guardar(Fabricantes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Fabricantes Modificar(Fabricantes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Fabricantes Borrar(Fabricantes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
