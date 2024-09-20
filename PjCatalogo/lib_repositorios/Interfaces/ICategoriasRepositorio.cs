using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface ICategoriasRepositorio
    {
        List<Categorias> Listar();
        Categorias Guardar(Categorias entidad);
        Categorias Modificar(Categorias entidad);
        Categorias Borrar(Categorias entidad);
    }
}

