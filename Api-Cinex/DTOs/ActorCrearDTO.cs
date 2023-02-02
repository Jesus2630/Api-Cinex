using Api_Cinex.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Api_Cinex.DTOs
{
    public class ActorCrearDTO
    {
        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [PesoArchivoValidacion(PesoMaximoEnMB: 4)]
        [TipoArchivoValidacion(grupoTipoArchivo: GrupoTipoArchivo.Imagen)]
        public IFormFile Foto { get; set; } 
    }
}
