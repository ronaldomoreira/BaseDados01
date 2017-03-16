using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    //Operadora Telefonica
    [Table("TB_OPERADORA")]
    public class OperadoraTel: GrmCustomEntity
    {
        public OperadoraTel()
        {
            //TB_TEL_PESSOA = new HashSet<TB_TEL_PESSOA>();
        }

        [Key]
        public int ID_OPERADORA { get; set; }

        [StringLength(100)]
        public string NOM_OPE { get; set; }
    }
}
