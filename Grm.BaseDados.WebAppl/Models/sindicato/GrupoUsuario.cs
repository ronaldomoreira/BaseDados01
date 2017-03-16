using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grm.BaseDados.WebAppl.Models.sindicato.GrmEntity;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{
    [Table("TB_GRUPO_USER")]
    public class GrupoUsuario: GrmCustomEntity
    {
        public GrupoUsuario()
        {
            GrupoPermissaos = new HashSet<GrupoPermissao>();
            Usuarios        = new HashSet<Usuario>();
        }

        [Key]
        [Column("ID_GRUPO_USER")]
        public int IdGrupoUsuario { get; set; }

        [Column("ID_NUVEM")]
        public int? IdNuvem { get; set; }

        [Column("DT_ULT_SINC")]
        public DateTime? DataUltimaSincronizacao { get; set; }

        [Column("FLAG_SINC")]
        [Required]
        [StringLength(1)]
        public string FlagSincronizacao { get; set; }

        [Column("STATUS_GRUPO")]
        [Required]
        [StringLength(1)]
        public string StatusGrupo { get; set; }

        [Column("SIGLA")]
        [StringLength(5)]
        public string Sigla { get; set; }

        [Column("NOME_GRUPO")]
        [StringLength(100)]
        public string NomeGrupo { get; set; }

        [Column("OBS")]
        [StringLength(255)]
        public string Observacao { get; set; }

        public virtual ICollection<GrupoPermissao> GrupoPermissaos { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
