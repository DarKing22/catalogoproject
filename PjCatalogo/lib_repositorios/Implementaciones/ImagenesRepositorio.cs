using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class ImagenesRepositorio : IImagenesRepositorio
    {
        private Conexion? conexion = null;

        public ImagenesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Imagenes> Listar()
        {
            return conexion!.Listar<Imagenes>();
        }

        public Imagenes Guardar(Imagenes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Imagenes Modificar(Imagenes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Imagenes Borrar(Imagenes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
