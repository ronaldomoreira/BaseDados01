namespace Grm.BaseDados.WebAppl.Models.sindicatoOld
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_AG_BANCO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_AG_BANCO { get; set; }

        public int ID_BANCO { get; set; }

        public int? ID_EMP_SIST { get; set; }

        [StringLength(20)]
        public string NRO_AGENCIA { get; set; }

        [StringLength(2)]
        public string DV_AGENCIA { get; set; }

        [StringLength(100)]
        public string GERENTE { get; set; }

        [StringLength(100)]
        public string GERENTE_REL { get; set; }

        [Required]
        [StringLength(1)]
        public string STATUS_AG_BANCO { get; set; }

        public virtual TB_BANCO TB_BANCO { get; set; }
    }
}
