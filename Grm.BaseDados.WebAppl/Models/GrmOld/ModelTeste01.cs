namespace Grm.BaseDados.WebAppl.Models.sindicatoOld
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelTeste01 : DbContext
    {
        public ModelTeste01()
            : base("name=ModelTeste01")
        {
        }

        public virtual DbSet<TB_AG_BANCO> TB_AG_BANCO { get; set; }
        public virtual DbSet<TB_BANCO> TB_BANCO { get; set; }
        public virtual DbSet<TB_MUNICIPIO> TB_MUNICIPIO { get; set; }
        public virtual DbSet<TB_PAIS> TB_PAIS { get; set; }
        public virtual DbSet<TB_UF> TB_UF { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_AG_BANCO>()
                .Property(e => e.NRO_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AG_BANCO>()
                .Property(e => e.DV_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AG_BANCO>()
                .Property(e => e.GERENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AG_BANCO>()
                .Property(e => e.GERENTE_REL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AG_BANCO>()
                .Property(e => e.STATUS_AG_BANCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.NUM_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.NOME_CURTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .Property(e => e.STATUS_BANCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_BANCO>()
                .HasMany(e => e.TB_AG_BANCO)
                .WithRequired(e => e.TB_BANCO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MUNICIPIO>()
                .Property(e => e.COD_IBGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MUNICIPIO>()
                .Property(e => e.NOME_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PAIS>()
                .Property(e => e.COD_IBGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PAIS>()
                .Property(e => e.SIGLA_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PAIS>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UF>()
                .Property(e => e.COD_IBGE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UF>()
                .Property(e => e.SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UF>()
                .Property(e => e.NOME_UF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UF>()
                .HasMany(e => e.TB_MUNICIPIO)
                .WithRequired(e => e.TB_UF)
                .WillCascadeOnDelete(false);
        }
    }
}
