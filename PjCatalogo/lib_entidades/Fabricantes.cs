using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Fabricantes
    {
        [Key] public int Id { get; set; }
        public string? Nombre  { get; set; }
        public string? Contacto { get; set; }
    }
}
