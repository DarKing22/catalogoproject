using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Imagenes
    {
        [Key] public int Id { get; set; }
        public int Producto { get; set; }
        [NotMapped] public Productos? _Producto { get; set; }
        public string? Archivo { get; set; }
        public char Informacion { get; set; } 
    }
}
