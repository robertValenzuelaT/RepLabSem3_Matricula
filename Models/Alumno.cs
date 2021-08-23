using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepLabSem3_Matricula.Models
{

    [Table("t_alumno")]
    public class Alumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]        
        public int Id { get; set; }
        public string apellidos {get;set;}
        public string nombres {get;set;}
        public DateTime fechanac {get;set;}
        public string dni {get;set;}
        public char genero {get;set;}
        public string carrera {get;set;}
        
        
        
    }
}