using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IFabricantesRepositorio
    {
        List<Fabricantes> Listar();
        Fabricantes Guardar(Fabricantes entidad);
        Fabricantes Modificar(Fabricantes entidad);
        Fabricantes Borrar(Fabricantes entidad);
    }
}

