using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_UF")]
    public class Uf: GrmCustomEntity
    {
        public Uf()
        {
            //TB_ACORDO_SIND = new HashSet<TB_ACORDO_SIND>();
            //Enderecos    = new HashSet<Endereco>();
            //Municipios   = new HashSet<Municipio>();
        }

        [Key]
        [Column("ID_UF")]
        public int IdUf { get; set; }

        [Column("COD_IBGE")]
        [StringLength(5)]
        public string codigoIbge { get; set; }

        [Column("SIGLA")]
        [StringLength(2)]
        public string Sigla { get; set; }

        [Column("NOME_UF")]
        [StringLength(100)]
        public string NomeUf { get; set; }

        //public virtual ICollection<TB_ACORDO_SIND> TB_ACORDO_SIND { get; set; }

        //public virtual ICollection<Endereco> Enderecos { get; set; }

        //public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
