using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IEstadosRepositorio
    {
        List<Estados> Listar();
        Estados Guardar(Estados entidad);
        Estados Modificar(Estados entidad);
        Estados Borrar(Estados entidad);
    }
}

