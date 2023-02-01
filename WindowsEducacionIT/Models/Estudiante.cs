using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    [Table("Estudiante")]
    public class Estudiante
    { 
        [Key]
        public int IDEstudiante { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }


        public int IDLocalidad { get; set; }

        [ForeignKey("IDLocalidad")]
        public Localidad Localidad { get; set; }


        
        public List<Evaluacion> Evaluaciones { get; set; }


    }
}
