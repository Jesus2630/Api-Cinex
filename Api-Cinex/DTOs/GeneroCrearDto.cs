using System.ComponentModel.DataAnnotations;

namespace Api_Cinex.DTOs
{
    public class GeneroCrearDto
    {
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
