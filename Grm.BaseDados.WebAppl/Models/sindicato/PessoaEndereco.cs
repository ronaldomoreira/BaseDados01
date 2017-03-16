using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_PESSOA_END")]
    public class PessoaEndereco: GrmCustomEntity 
    {
        [Key]
        [Column(Order = 0)]
        public int ID_PESSOA { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ID_ENDERECO { get; set; }

        [Required]
        [StringLength(1)]
        public string END_SEDE { get; set; }

        [Required]
        [StringLength(1)]
        public string END_COBRANCA { get; set; }

        [Required]
        [StringLength(1)]
        public string END_ENTREGA { get; set; }

        [Required]
        [StringLength(1)]
        public string END_CORRESP { get; set; }

        [Required]
        [StringLength(1)]
        public string END_VISITA { get; set; }

        public virtual Endereco EnderecoEnd { get; set; }

        public virtual Pessoa PessoaEnd { get; set; }
    }
}
