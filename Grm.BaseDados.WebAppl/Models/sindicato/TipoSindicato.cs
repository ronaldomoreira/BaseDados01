using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_TIPO_SIND")]
    public class TipoSindicato
    {
        public TipoSindicato()
        {
            //Sindicatos = new HashSet<Sindicato>();
        }

        [Key]
        public int ID_TIPO_SIND { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        //public virtual ICollection<TB_CFG_USUARIO> TB_CFG_USUARIO { get; set; }

    }
}
