using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_BASE_TERR_MUN")]
    public partial class BaseTerritorialMun: GrmCustomEntity
    {
        [Key]
        [Column("ID_BASE_TERR")]
        public int IdBaseTerritorial { get; set; }

        [Key]
        [Column("ID_MUNICIPIO")]
        public int IdMunicipio { get; set; }
    }
}
