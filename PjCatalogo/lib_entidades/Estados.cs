using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Estados
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
    }
}
