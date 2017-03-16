using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_PAIS")]
    public class Pais: GrmCustomEntity 
    {
        public Pais()
        {
            //Enderecos = new HashSet<Endereco>();
        }

        [Key]
        [Column("ID_PAIS")]
        public int IdPais { get; set; }

        [Column("COD_IBGE")]
        [StringLength(10)]
        public string CodIbge { get; set; }

        [Column("SIGLA_PAIS")]
        [StringLength(5)]
        public string SiglaPais { get; set; }

        [Column("NOME_PAIS")]
        [StringLength(100)]
        public string NomePais { get; set; }

    }
}
