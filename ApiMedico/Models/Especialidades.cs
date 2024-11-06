using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMedico.Models
{
    [Table("especialidades")]
    public class Especialidades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage ="El nombre es Obligatorio")]
        public string nombre { get; set; }
        [StringLength(500,ErrorMessage ="La descripcion no puede exceder los 500 caracateres")]
        public string descripcion { get; set; }
    }
}
