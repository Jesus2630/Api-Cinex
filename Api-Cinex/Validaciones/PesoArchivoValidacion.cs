using System.ComponentModel.DataAnnotations;

namespace Api_Cinex.Validaciones
{
    public class PesoArchivoValidacion : ValidationAttribute
    {
        private readonly int pesoMaximoEnMB;

        public PesoArchivoValidacion(int PesoMaximoEnMB)
        {
            pesoMaximoEnMB = PesoMaximoEnMB;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) 
            {
                return ValidationResult.Success;
            }

            IFormFile formfile = value as IFormFile;

            if (formfile == null) 
            {
                return ValidationResult.Success;
            }

            if (formfile.Length > pesoMaximoEnMB * 1024 * 1024) 
            {
                return new ValidationResult($"El peso no puede ser mayor a {pesoMaximoEnMB} mb");
            }

            return ValidationResult.Success;
        }
    }
}
