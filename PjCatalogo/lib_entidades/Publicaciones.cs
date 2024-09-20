using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Publicaciones
    {
        [Key] public int Id { get; set; }
        public int Producto { get; set; }
        [NotMapped] public Productos? _Producto { get; set; }
        public int Estado { get; set; }
        [NotMapped] public Estados? _Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string? Titulo { get; set; }
        public char Descripcion { get; set; }
        public decimal Costo { get; set; }

    }
}
