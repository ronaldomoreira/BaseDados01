using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_ENDERECO")]
    public class Endereco: GrmCustomEntity
    {
        public Endereco()
        {
            //PessoaEnderecos = new HashSet<PessoaEndereco>();
            //Sindicatos      = new HashSet<Sindicato>();
        }
        
        [Key]
        [Column("ID_ENDERECO")]
        [Display(Name = "C�digo")]
        public int IdEndereco { get; set; }

        [Column("ID_PAIS")]
        [Display(Name = "C�digo")]
        public int? IdPais { get; set; }

        [Column("ID_UF")]
        [Display(Name = "C�digo")]
        public int? IdUf { get; set; }

        [Column("ID_MUNICIPIO")]
        [Display(Name = "C�digo")]
        public int? IdMunicipio { get; set; }

        [Column("ID_NUVEM")]
        [Display(Name = "C�digo")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        [Display(Name = "C�digo")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        [Display(Name = "C�digo")]
        public string FlagSincronizacao { get; set; }

        [Column("TIPO_END")]
        [Required]
        [StringLength(1)]
        [Display(Name = "C�digo")]
        public string TipoEndereco { get; set; }

        [Column("TIPO_LOG")]
        [StringLength(10)]
        [Display(Name = "C�digo")]
        public string TipoLogradouro { get; set; }

        [Column("LOGRADOURO")]
        [StringLength(100)]
        [Display(Name = "C�digo")]
        public string Logradouro { get; set; }

        [Column("NUMERO")]
        [StringLength(10)]
        [Display(Name = "C�digo")]
        public string Numero { get; set; }

        [Column("COMPLEMENTO")]
        [StringLength(20)]
        [Display(Name = "C�digo")]
        public string Complemento { get; set; }

        [Column("BAIRRO")]
        [StringLength(100)]
        [Display(Name = "C�digo")]
        public string Bairro { get; set; }

        [Column("CEP")]
        [StringLength(10)]
        [Display(Name = "C�digo")]
        public string Cep { get; set; }

        [Column("COD_POSTAL_EXT")]
        [StringLength(32)]
        [Display(Name = "C�digo")]
        public string CodPostalExterior { get; set; }

        [Column("ENDERECO_EXT")]
        [StringLength(100)]
        [Display(Name = "C�digo")]
        public string EnderecoExterior { get; set; }

        [Column("COMPLEMENTO_EXT")]
        [StringLength(255)]
        [Display(Name = "C�digo")]
        public string ComplementoExterior { get; set; }

        [Column("CIDADE_EXT")]
        [StringLength(100)]
        [Display(Name = "C�digo")]
        public string CidadeExterior { get; set; }

        [Column("ESTADO_EXT")]
        [StringLength(100)]
        [Display(Name = "C�digo")]
        public string EstadoExterior { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        public string Observacao { get; set; }

        public virtual Municipio EnderecoMunicipio { get; set; }

        public virtual Pais EnderecoPais { get; set; }

        public virtual Uf EnderecoUf { get; set; }

        public virtual ICollection<PessoaEndereco> PessoaEnderecos { get; set; }

        public virtual ICollection<Sindicato> Sindicatos { get; set; }
    }
}
