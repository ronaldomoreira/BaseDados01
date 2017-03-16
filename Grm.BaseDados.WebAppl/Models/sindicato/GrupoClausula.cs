using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_GRUPO_CLA")]
    public class GrupoClausula: GrmCustomEntity
    {
        public GrupoClausula()
        {
            Clausulas = new HashSet<Clausula>();
        }

        [Key]
        [Column("ID_GRUPO_CLA")]
        public int IdGrupoClausula { get; set; }
        
        [Column("DESCRICAO")]
        [StringLength(100)]
        public string Descricao { get; set; }

        public virtual ICollection<Clausula> Clausulas { get; set; }
    }
}
