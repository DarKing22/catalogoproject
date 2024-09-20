using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    public class EstadosPruebaUnitara

    {
        private IEstadosRepositorio? iRepositorio = null;
        public EstadosPruebaUnitara()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_catalogo;uid=sa;pwd=123465789;TrustServerCertificate=true;";
            iRepositorio = new EstadosRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Listar();
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
    }
}
