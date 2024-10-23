using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMedico.Models
{
    [Table("especialidades")]
    public class Especialidades
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
