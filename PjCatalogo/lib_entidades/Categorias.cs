using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Categorias
    {
        [Key] public int Id { get; set; }
        public string? Categoria { get; set; }
    }
}
