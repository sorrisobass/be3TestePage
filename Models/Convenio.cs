using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace be3TestePage.Models
{
    [Table("Convenio")]
    public class Convenio
    {
        [Display(Name = "Id_Convenio")]
        [Column("Id_Convenio")]
        [Key]
        public int Id_Convenio { get; set; }

        [Display(Name = "Descricao")]
        [Column("Descricao")]
        public string Descricao { get; set; }        
    }
}
