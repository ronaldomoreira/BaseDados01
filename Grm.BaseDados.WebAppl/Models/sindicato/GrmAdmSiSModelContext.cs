using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Grm.BaseDados.WebAppl.Models.sindicato
{

    public class GrmAdmSiSModelContext : DbContext
    {
        public GrmAdmSiSModelContext()
            : base("name=GrmAdmSiSConnection")
        {
            //
        }
        public virtual DbSet<AcordoSindical> DbAcordoSindical { get; set; } //TB_ACORDO_SIND
        public virtual DbSet<AgenciaBanco> DbAgenciaBanco { get; set; } //TB_AG_BANCO
        public virtual DbSet<Banco> DbBanco { get; set; } //TB_BANCO
        public virtual DbSet<BaseTerritorial> DbBaseTerritorial { get; set; } //TB_BASE_TERR
        public virtual DbSet<Cargo> DbCargo { get; set; } //TB_CARGO
        public virtual DbSet<ConfigContaAcessoSistema> DbConfigContaAcessoSistema { get; set; } //TB_CFG_CTA_A_SIST
        public virtual DbSet<ConfigEmpresaSistema> DbConfigEmpresaSistema { get; set; } //TB_CFG_EMP_SIST
        public virtual DbSet<ConfigUsuario> DbConfigUsuario { get; set; } //TB_CFG_USUARIO
        public virtual DbSet<ClausulaItem> DbClausulaItem { get; set; } //TB_CLA_ITEM
        public virtual DbSet<ClassificacaoSindicato> DbClassificacaoSindicato { get; set; } //TB_CLASS_SIND
        public virtual DbSet<Clausula> DbClausula { get; set; } //TB_CLAUSULA
        public virtual DbSet<ContaAcessoSistema> DbContaAcessoSistema { get; set; } //TB_CTA_ACESSO_SIST
        public virtual DbSet<ContaCorrente> DbContaCorrente { get; set; } //TB_CTA_CORRENTE
        public virtual DbSet<EmpresaSistema> DbEmpresaSistema { get; set; } //TB_EMP_SIST
        public virtual DbSet<Endereco> DbEndereco { get; set; } //TB_ENDERECO
        public virtual DbSet<Funcao> DbFuncao { get; set; } //TB_FUNCAO
        public virtual DbSet<Funcionario> DbFuncionario { get; set; } //TB_FUNCIONARIO
        public virtual DbSet<GeoEco> DbGeoEco { get; set; } //TB_GEO_ECO
        public virtual DbSet<GrupoClausula> DbGrupoClausula { get; set; } //TB_GRUPO_CLA
        public virtual DbSet<GrupoPermissao> DbGrupoPermissao { get; set; } //TB_GRUPO_PER
        public virtual DbSet<GrupoUsuario> DbGrupoUsuario { get; set; } //TB_GRUPO_USER
        public virtual DbSet<LogErro> DbLogErro { get; set; } //TB_LOG_ERRO
        public virtual DbSet<LogEvento> DbLogEvento { get; set; } //TB_LOG_EVENTO
        public virtual DbSet<Municipio> DbMunicipio { get; set; } //TB_MUNICIPIO
        public virtual DbSet<NaturezaOperacao> DbNaturezaOperacao { get; set; } //TB_NAT_OP
        public virtual DbSet<OrientacaoClausula> DbOrientacaoClausula { get; set; } //TB_O_CLA
        public virtual DbSet<OperadoraTel> DbOperadoraTel { get; set; } //TB_OPERADORA
        public virtual DbSet<OrganizacaoSindical> DbOrganizacaoSindical { get; set; } //TB_ORG_SIND
        public virtual DbSet<Pais> DbPais { get; set; } //TB_PAIS
        public virtual DbSet<Pessoa> DbPessoa { get; set; } //TB_PESSOA
        public virtual DbSet<PessoaEndereco> DbPessoaEndereco { get; set; } //TB_PESSOA_END
        public virtual DbSet<RegistroLicenca> DbRegistroLicenca { get; set; } //TB_REG_LIC
        public virtual DbSet<Regraclausula> DbRegraclausula { get; set; } //TB_REGRA_CLA
        public virtual DbSet<Sindicato> DbSindicato { get; set; } //TB_SIND
        public virtual DbSet<StatusValor> DbStatusValor { get; set; } //TB_ST_VALOR
        public virtual DbSet<Status> DbStatus { get; set; } //TB_STATUS
        public virtual DbSet<TelefonePessoa> DbTelefonePessoa { get; set; }  //TB_TEL_PESSOA
        public virtual DbSet<TipoAcordo> DbTipoAcordo { get; set; } //TB_TIPO_ACORDO
        public virtual DbSet<TipoSindicato> DbTipoSindicato { get; set; } //TB_TIPO_SIND
        public virtual DbSet<Uf> DbUf { get; set; } //TB_UF
        public virtual DbSet<Unidade> DbUnidade { get; set; } //TB_UNIDADE
        public virtual DbSet<Usuario> DbUsuario { get; set; } //TB_USUARIO


        public static GrmAdmSiSModelContext Create()
        {
            return new GrmAdmSiSModelContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //aiterar convencao de id
            //modelBuilder.Properties()
            //    .Where(p => p.Name == "Id" + p.ReflectedType.Name)
            //    .Configure(p => p.IsKey());

            modelBuilder.Entity<AcordoSindical>()
                .ToTable("TB_ACORDO_SIND")
                .Property(p => p.IdAcondoSindial).HasColumnName("ID_ACORDO_SIND");

            modelBuilder.Entity<AgenciaBanco>()
                .ToTable("TB_AG_BANCO");

            modelBuilder.Entity<Banco>()
                .ToTable("TB_BANCO");

            modelBuilder.Entity<Cargo>()
                .ToTable("TB_CARGO");

            modelBuilder.Entity<ContaAcessoSistema>()
                .ToTable("TB_CFG_CTA_A_SIST");

            modelBuilder.Entity<ConfigContaAcessoSistema>()
                .ToTable("TB_CFG_CTA_A_SIST");

            modelBuilder.Entity<ConfigEmpresaSistema>()
                .ToTable("TB_CFG_EMP_SIST");

            modelBuilder.Entity<ConfigUsuario>()
                .ToTable("TB_CFG_USUARIO");

            modelBuilder.Entity<ClausulaItem>()
                .ToTable("TB_CLA_ITEM");

            modelBuilder.Entity<ClassificacaoSindicato>()
                .ToTable("TB_CLASS_SIND");

            modelBuilder.Entity<Clausula>()
                .ToTable("TB_CLAUSULA");

            modelBuilder.Entity<ContaAcessoSistema>()
                .ToTable("TB_CTA_ACESSO_SIST");

            modelBuilder.Entity<ContaCorrente>()
                .ToTable("TB_CTA_CORRENTE");

            modelBuilder.Entity<EmpresaSistema>()
                .ToTable("TB_EMP_SIST");

            modelBuilder.Entity<Endereco>()
                .ToTable("TB_ENDERECO");

            modelBuilder.Entity<Funcao>()
                .ToTable("TB_FUNCAO");

            modelBuilder.Entity<Funcionario>()
                .ToTable("TB_FUNCIONARIO");

            modelBuilder.Entity<GeoEco>()
                .ToTable("TB_GEO_ECO");

            modelBuilder.Entity<GrupoClausula>()
                .ToTable("TB_GRUPO_CLA");

            modelBuilder.Entity<GrupoPermissao>()
                .ToTable("TB_GRUPO_PER");

            modelBuilder.Entity<GrupoUsuario>()
                .ToTable("TB_GRUPO_USER");

            modelBuilder.Entity<LogErro>()
                .ToTable("TB_LOG_ERRO");

            modelBuilder.Entity<LogEvento>()
                .ToTable("TB_LOG_EVENTO");

            modelBuilder.Entity<Municipio>()
                .ToTable("TB_MUNICIPIO");

            modelBuilder.Entity<NaturezaOperacao>()
                .ToTable("TB_NAT_OP");

            modelBuilder.Entity<OrientacaoClausula>()
                .ToTable("TB_O_CLA");

            modelBuilder.Entity<OperadoraTel>()
                .ToTable("TB_OPERADORA");

            modelBuilder.Entity<OrganizacaoSindical>()
                .ToTable("TB_ORG_SIND");

            modelBuilder.Entity<Pais>()
                .ToTable("TB_PAIS");

            modelBuilder.Entity<Pessoa>()
                .ToTable("TB_PESSOA");

            modelBuilder.Entity<PessoaEndereco>()
                .ToTable("TB_PESSOA_END");

            modelBuilder.Entity<RegistroLicenca>()
                .ToTable("TB_REG_LIC");

            modelBuilder.Entity<Regraclausula>()
                .ToTable("TB_REGRA_CLA");

            modelBuilder.Entity<Sindicato>()
                .ToTable("TB_SIND");

            modelBuilder.Entity<Status>()
                .ToTable("TB_STATUS");

            modelBuilder.Entity<StatusValor>()
                .ToTable("TB_ST_VALOR");

            modelBuilder.Entity<TelefonePessoa>()
                .ToTable("TB_TEL_PESSOA");

            modelBuilder.Entity<TipoAcordo>()
                .ToTable("TB_TIPO_ACORDO");

            modelBuilder.Entity<TipoSindicato>()
                .ToTable("TB_TIPO_SIND");

            modelBuilder.Entity<Uf>()
                .ToTable("TB_UF");

            modelBuilder.Entity<Unidade>()
                .ToTable("TB_UNIDADE");

            modelBuilder.Entity<Usuario>()
                .ToTable("TB_USUARIO");

            base.OnModelCreating(modelBuilder);

        }
    }
}
