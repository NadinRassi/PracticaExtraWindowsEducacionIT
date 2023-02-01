﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int IDProfesor { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Planilla> Planillas { get; set; }

        public int IDLocalidad { get; set; }

        [ForeignKey("IDLocalidad")]
        public Localidad Localidad { get; set; }
    }
}
