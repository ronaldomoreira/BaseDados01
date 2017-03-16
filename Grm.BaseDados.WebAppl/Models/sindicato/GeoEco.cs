using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_GEO_ECO")]
    public class GeoEco: GrmCustomEntity
    {
        public GeoEco()
        {
            Sindicatos = new HashSet<Sindicato>();
        }

        [Key]
        [Column("ID_GEO_ECO")]
        public int IdGeoEco { get; set; }

        [Column("DESCRICAO")]
        [StringLength(100)]
        public string Descricao { get; set; }

        public virtual ICollection<Sindicato> Sindicatos { get; set; }
    }
}
