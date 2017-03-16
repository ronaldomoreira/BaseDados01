using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_GRUPO_PER")]
    public partial class GrupoPermissao: GrmCustomEntity
    {
        [Key]
        [Column("ID_GRUPO_PER")]
        public int IdGrupoPermissao { get; set; }

        [Column("ID_GRUPO_USER")]
        [ForeignKey("GrupoPermissaoGrupoUsuario")]
        public int IdGrupoUsuario { get; set; }
        public virtual GrupoUsuario GrupoPermissaoGrupoUsuario { get; set; }

        [Column("ID_TELA")]
        public int IdTela { get; set; }

        [Column("ID_ACAO")]
        public int IdAcao { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("NOME_PER")]
        [StringLength(100)]
        public string NomePermissao  { get; set; }

        [Column("PERMISSAO")]
        [StringLength(1)]
        public string Permissao { get; set; }

    }
}
