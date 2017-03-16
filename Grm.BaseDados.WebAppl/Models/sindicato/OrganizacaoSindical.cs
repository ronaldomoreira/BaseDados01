using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_ORG_SIND")]
    public class OrganizacaoSindical: GrmCustomEntity
    {
        public OrganizacaoSindical()
        {
            //this.ConfederaaoSindicais = new HashSet<OrganizacaoSindical>();
            //this.TB_SIND  = new HashSet<TB_SIND>();
            //this.TB_SIND1 = new HashSet<TB_SIND>();
            //this.TB_SIND2 = new HashSet<TB_SIND>();
        }

        [Key]
        [Column("ID_ORG_SIND")]
        public int IdOrganizacaoSindical { get; set; }

        [Column("ID_CONF_SIND")]
        public int? ConfederacaoSindical { get; set; }
        public virtual OrganizacaoSindical OrganizacaoSindicalConfederacaoSindical { get; set; }
        
        [Column("SIGLA")]
        [StringLength(20)]
        public string Sigla { get; set; }

        [Column("NOME")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("RAZAO_SOCIAL")]
        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Column("DT_NASC")]
        public DateTime? DataNasc  { get; set; }

        [Column("CNPJ")]
        [StringLength(15)]
        public string Cnpj  { get; set; }

        [Column("STATUS_ORG")]
        [StringLength(1)]
        public string StatusOrg { get; set; }

        [Column("NOME_CONTATO")]
        [StringLength(100)]
        public string NomeContato { get; set; }

        [Column("DDD_TEL")]
        [StringLength(2)]
        public string DDDTel { get; set; }

        [Column("TELEFONE")]
        [StringLength(15)]
        public string Telefone { get; set; }

        [Column("EMAIL")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("SITE")]
        [StringLength(100)]
        public string Site { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        //public virtual ICollection<OrganizacaoSindical> ConfederaaoSindicais { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND1 { get; set; }

        //public virtual ICollection<TB_SIND> TB_SIND2 { get; set; }
    }
}
