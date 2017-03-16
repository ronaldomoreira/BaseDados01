using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_TEL_PESSOA")]
    public class TelefonePessoa
    {
        [Key]
        public int ID_TEL_PESSOA { get; set; }

        public int? ID_NUVEM { get; set; }

        public int ID_PESSOA { get; set; }

        public int? ID_OPERADORA { get; set; }

        public DateTime? DT_ULT_SINC { get; set; }

        [Required]
        [StringLength(1)]
        public string FLAG_SINC { get; set; }

        [Required]
        [StringLength(1)]
        public string TIPO_TEL { get; set; }

        [StringLength(5)]
        [DisplayFormat(DataFormatString = "{0:##}", ApplyFormatInEditMode = true)]
        public string DDI_TEL { get; set; }

        [DisplayFormat(DataFormatString = "{0:##}", ApplyFormatInEditMode = true)]
        [StringLength(2)]
        public string DDD_TEL { get; set; }

        [StringLength(15)]
        //[DisplayFormat(DataFormatString = "{0:(##) #####-####}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:#####-####}", ApplyFormatInEditMode = true)]
        public string TELEFONE { get; set; }

        [StringLength(10)]
        public string RAMAL_TEL { get; set; }

        [StringLength(100)]
        public string SETOR { get; set; }

        [StringLength(100)]
        public string NOM_CONT_TEL { get; set; }

        [StringLength(100)]
        public string OBS { get; set; }

        public virtual OperadoraTel TelOperadora { get; set; }

        public virtual Pessoa TelPessoa { get; set; }
    }
}
