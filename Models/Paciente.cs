using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace be3TestePage.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Display(Name = "Prontuario")]
        [Column("Prontuario")]
        [Key]
        public int Prontuario { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "SobreNome")]
        [Column("Sobrenome")]
        public string SobreNome { get; set; }

        [Display(Name = "DtNasc")]
        [Column("DtNasc")]
        public DateTime DtNasc { get; set; }

        [Display(Name = "Genero")]
        [Column("Genero")]
        public int Genero { get; set; }

        [Display(Name = "Cpf")]
        [Column("Cpf")]
        public string Cpf { get; set; }

        [Display(Name = "Rg")]
        [Column("Rg")]
        public string Rg { get; set; }

        [Display(Name = "UfRg")]
        [Column("UfRg")]
        public string UfRg { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Display(Name = "Celular")]
        [Column("Celular")]
        public string Celular { get; set; }

        [Display(Name = "Id_Convenio")]
        [Column("Id_Convenio")]
        public int Id_Convenio { get; set; }

        public List<Convenio> ListaConvenio()
        {
            return new List<Convenio>
            {
                new Convenio { Id_Convenio = 1, Descricao = "Bradesco"},
                new Convenio { Id_Convenio = 1, Descricao = "Sulamerica" },
                new Convenio { Id_Convenio = 1, Descricao = "Mortadela" }
            };
        }
    }
}
