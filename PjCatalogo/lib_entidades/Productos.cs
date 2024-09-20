using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Productos
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Fabricante { get; set; }
        [NotMapped] public Fabricantes? _Fabricante { get; set; }
        public int Categoria { get; set; }
        [NotMapped] public Categorias? _Categoria { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

    }
}
