using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_MUNICIPIO")]
    public class Municipio: GrmCustomEntity 
    {
        public Municipio()
        {
            //
        }

        [Key]
        [Column("ID_MUNICIPIO")]
        public int IdMunicipio { get; set; }

        [Column("ID_UF")]
        [ForeignKey(nameof(MunicipioUf))]
        public int IdUf { get; set; }
        public virtual Uf MunicipioUf { get; set; }

        [Column("COD_IBGE")]
        [StringLength(10)]
        public string CodIbge { get; set; }

        [Column("NOME_MUN")]
        [StringLength(100)]
        public string NomeMunicipio { get; set; }

    }
}
