using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEducacionIT.Models;

namespace WindowsEducacionIT
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int IDEstado { get; set; }
        public string Nombre { get; set; }

        public List<Detalle> Detalle { get; set; }
    }
}
