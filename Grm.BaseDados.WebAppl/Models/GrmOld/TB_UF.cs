namespace Grm.BaseDados.WebAppl.Models.sindicatoOld
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_UF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_UF()
        {
            TB_MUNICIPIO = new HashSet<TB_MUNICIPIO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_UF { get; set; }

        [StringLength(5)]
        public string COD_IBGE { get; set; }

        [StringLength(2)]
        public string SIGLA { get; set; }

        [StringLength(100)]
        public string NOME_UF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MUNICIPIO> TB_MUNICIPIO { get; set; }
    }
}
