using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{

    [Table("TB_FUNCAO")]
    public class Funcao: GrmCustomEntity 
    {
        
        public Funcao()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

        [Key]
        [Column("ID_FUNCAO")]
        public int IdFuncao { get; set; }

        [Column("ID_EMP_SIST")]
        public int? IdEmpresaSistema { get; set; }

        [Column("NOME_FUNCAO")]
        [StringLength(100)]
        public string NomeFuncao { get; set; }


        public virtual ICollection<Funcionario> Funcionarios { get; set; }

    }
}
