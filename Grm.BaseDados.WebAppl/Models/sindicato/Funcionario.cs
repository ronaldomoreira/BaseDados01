using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_FUNCIONARIO")]
    public class Funcionario: Pessoa
    {
        [Key]
        [Column("ID_FUNCIONARIO")]
        public int IdFuncionario { get; set; }
        
        [Column("ID_EMP_SIST")]
        public int? IdEmpresaSistema { get; set; }

        [Column("ID_CTA_CORRENTE")]
        public int? IdContaCorrente { get; set; }

        [Column("ID_CARGO")]
        public int? IdCargo { get; set; }

        [Column("ID_FUNCAO")]
        public int? Idfuncao { get; set; }

        [Column("CTPS")]
        [StringLength(20)]
        public string Ctps { get; set; }

        [Column("PIS_PASEP")]
        [StringLength(20)]
        public string PisPasep { get; set; }

        [Column("NUN_CRACHA")]
        [StringLength(10)]
        public string NumCracha { get; set; }

        [Column("DT_ADMISSAO")]
        public DateTime? DataAdmissao { get; set; }

        [Column("DT_DEMISSAO")]
        public DateTime? DataDemissao { get; set; }

        [Column("STATUS_FUNC")]
        [Required]
        [StringLength(1)]
        public string StatusFunc { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        public string Observacao { get; set; }

        public virtual Cargo FuncionarioCargo { get; set; }

        public virtual ContaCorrente FuncionarioContaCorrente { get; set; }

        public virtual EmpresaSistema FuncionarioEmpresaSistema { get; set; }

        public virtual Funcao FuncionarioFuncao { get; set; }
    }
}
 