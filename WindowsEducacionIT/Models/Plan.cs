using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int IDPlan { get; set; }
        public string Nombre { get; set; }

        public int IDCarrera { get; set; }

        [ForeignKey("IDCarrera")]
        public Carrera Carrera { get; set; }
    }
}
