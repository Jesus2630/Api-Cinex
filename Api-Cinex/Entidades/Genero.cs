using System.ComponentModel.DataAnnotations;

namespace Api_Cinex.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
