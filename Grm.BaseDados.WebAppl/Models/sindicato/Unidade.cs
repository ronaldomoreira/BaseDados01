using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_UNIDADE")]
    public class Unidade: GrmCustomEntity 
    {
        [Key]
        public int ID_UNIDADE { get; set; }

        public int ID_EMP_SIST { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [Required]
        [StringLength(5)]
        public string SIGLA { get; set; }

    }
}
