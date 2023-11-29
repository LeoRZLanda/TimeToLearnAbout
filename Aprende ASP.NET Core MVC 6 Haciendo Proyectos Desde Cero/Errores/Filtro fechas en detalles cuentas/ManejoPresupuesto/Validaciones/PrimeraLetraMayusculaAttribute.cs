using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Validaciones{
    public class PrimeraLetraMayusculaAttribute : ValidationAttribute{

        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            if(value == null || string.IsNullOrEmpty(value.ToString())){
                return ValidationResult.Success;
            }

            var primerLetra = value.ToString()[0].ToString();

            if(primerLetra != primerLetra.ToUpper() ){
                return new ValidationResult("La primera letra debe ser mayúsculas");
            }

            return ValidationResult.Success;
        }
    }
}