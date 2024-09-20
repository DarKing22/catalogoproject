using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IImagenesRepositorio
    {
        List<Imagenes> Listar();
        Imagenes Guardar(Imagenes entidad);
        Imagenes Modificar(Imagenes entidad);
        Imagenes Borrar(Imagenes entidad);
    }
}

