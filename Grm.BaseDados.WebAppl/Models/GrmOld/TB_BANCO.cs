namespace Grm.BaseDados.WebAppl.Models.sindicatoOld
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_BANCO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_BANCO()
        {
            TB_AG_BANCO = new HashSet<TB_AG_BANCO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_BANCO { get; set; }

        public int ID_EMP_SIST { get; set; }

        [StringLength(10)]
        public string NUM_BANCO { get; set; }

        [StringLength(50)]
        public string NOME_CURTO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(1)]
        public string STATUS_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_AG_BANCO> TB_AG_BANCO { get; set; }
    }
}
