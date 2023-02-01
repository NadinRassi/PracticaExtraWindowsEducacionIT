﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    [Table("Materia")]
    public class Materia
    {
        [Key]
        public int IDMateria { get; set; }

        public string Nombre { get; set; }
        public List<Planilla> Planillas { get; set; }

    }
}
