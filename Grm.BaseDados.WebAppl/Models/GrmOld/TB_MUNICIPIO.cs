namespace Grm.BaseDados.WebAppl.Models.sindicatoOld
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MUNICIPIO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MUNICIPIO { get; set; }

        public int ID_UF { get; set; }

        [StringLength(10)]
        public string COD_IBGE { get; set; }

        [StringLength(100)]
        public string NOME_MUN { get; set; }

        public virtual TB_UF TB_UF { get; set; }
    }
}
