using System.ComponentModel.DataAnnotations;

namespace CrudCore.Models

{
    public class ContactoModel
    {
        public int IdContacto { set; get; }
        [Required(ErrorMessage ="el campo Nombre es obligatorio")]
        public string Nombre { set; get; }
        [Required(ErrorMessage = "el campo Telefono es obligatorio")]
        public string Telefono { set; get; }
        [Required(ErrorMessage = "el campo Correo es obligatorio")]
        public string Correo { set; get; }




    }
}
