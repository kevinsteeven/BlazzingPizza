using System.ComponentModel.DataAnnotations;
namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio"), MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres"), MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria"), MinLength(5, ErrorMessage = "La direccion debe tener al menos 5 caracteres"), MaxLength(100, ErrorMessage = "La direccion no puede tener más de 100 caracteres")]
        public string Line1 { get; set; }

        [MaxLength(100, ErrorMessage = "La linea 2 no puede tener más de 100 caracteres")]
        public string Line2 { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria"), MinLength(3, ErrorMessage = "La ciudad debe tener al menos 3 caracteres"), MaxLength(50, ErrorMessage = "La ciudad no puede tener más de 50 caracteres")]
        public string City { get; set; }
    
        [Required(ErrorMessage = "La region es obligatoria"), MinLength(3, ErrorMessage = "La region debe tener al menos 3 caracteres"), MaxLength(50, ErrorMessage = "La region no puede tener más de 50 caracteres")]
        public string Region { get; set; }

        [Required(ErrorMessage = "El código postal es obligatorio"), RegularExpression(@"^([0-9]{5})$",ErrorMessage = "El código postal debe tener 5 dígitos")] 
        public string PostalCode { get; set; }
    }
}
