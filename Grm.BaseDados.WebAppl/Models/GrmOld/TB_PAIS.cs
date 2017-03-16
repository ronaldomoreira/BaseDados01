namespace Grm.BaseDados.WebAppl.Models.sindicatoOld
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PAIS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PAIS { get; set; }

        [StringLength(10)]
        public string COD_IBGE { get; set; }

        [StringLength(5)]
        public string SIGLA_PAIS { get; set; }

        [StringLength(100)]
        public string NOME_PAIS { get; set; }
    }
}
