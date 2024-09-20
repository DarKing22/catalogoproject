using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPublicacionesRepositorio
    {
        List<Publicaciones> Listar();
        Publicaciones Guardar(Publicaciones entidad);
        Publicaciones Modificar(Publicaciones entidad);
        Publicaciones Borrar(Publicaciones entidad);
    }
}

