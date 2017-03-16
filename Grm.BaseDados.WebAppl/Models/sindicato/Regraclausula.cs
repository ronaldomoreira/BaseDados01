using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_REGRA_CLA")]
    public class Regraclausula: GrmCustomEntity
    {
        public Regraclausula()
        {
            //TB_CLA_ITEM = new HashSet<TB_CLA_ITEM>();
        }

        [Key]
        public int ID_REGRA_CLA { get; set; }

        [Required]
        [StringLength(5)]
        public string SIGLA { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Vazio")]
        //[Range(0, 999999, ErrorMessage = "Valor base tem que se maoir que zero.")]
        public decimal? VALOR_BASE { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true, NullDisplayText = "Vazio")]
        [Display(Name = "valor inicial", Prompt = "", Description = "")]
        public decimal? INDICE1 { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Display(Name = "valor inicial", Prompt = "", Description = "")]
        public decimal? INDICE2 { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true, NullDisplayText = "Vazio")]
        [Display(Name = "valor inicial", Prompt = "", Description = "")]
        public decimal? VALOR_REF1 { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true, NullDisplayText = "Vazio")]
        [Display(Name = "valor inicial", Prompt = "", Description = "")]
        public decimal? VALOR_REF2 { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true, NullDisplayText = "Vazio")]
        [Display(Name = "valor inicial", Prompt = "", Description = "")]
        public decimal? VALOR_COMP { get; set; }  //valor comlementar

        [Column(TypeName = "numeric")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true, NullDisplayText = "Vazio")]
        [Display(Name = "valor inicial", Prompt = "", Description = "")]
        public decimal? VALOR_FIM { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(255)]
        public string OBS { get; set; }

        //public virtual ICollection<TB_CLA_ITEM> TB_CLA_ITEM { get; set; }
    }
}
