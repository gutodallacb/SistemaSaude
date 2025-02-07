using Microsoft.EntityFrameworkCore;
using ProjetoSQLserver.Model;
using SistemaSaude.Model;

namespace SistemaSaude.Model
{
	public class MeuDbContext_ORM : DbContext
	{
		//Cria variaveis para usar em outras classes:
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Paciente> Pacientes {  get; set; }
		public DbSet<Atendimento> Atendimentos { get; set; }
		public DbSet<Diagnostico> Diagnosticos { get; set; }
		public DbSet<DiagnosticoEspecificacao> DiagnosticosEspecificacao { get; set; }

		// Configura a string de conexão para o banco de dados
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string server = @"GUSTAVO\SQLEXPRESS";        // Nome do servidor
			string dataBase = "SistemaSaude";  // Nome do banco de dados

			//String de conexão com banco:
			optionsBuilder.UseSqlServer($"Data Source={server};Initial Catalog={dataBase};Integrated Security=True;TrustServerCertificate=True");
		}

		//Configurar mapeamento das classes criadas para o banco de dados
		//e definindo regras como as chaves primárias, relacionamentos e restrinções
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Define que a propriedade CodRegistro é a chave primária da tabela PACIENTE no banco de dados:
			modelBuilder.Entity<Usuario>()
				.HasKey(p => p.cod_usuario);

			//Define que a propriedade CodRegistro é a chave primária da tabela PACIENTE no banco de dados:
			modelBuilder.Entity<Paciente>()
				.HasKey(p => p.cod_registro);

			//Define que a propriedade CodDiagnostico é a chave primária da tabela DIAGNOSTICO no banco de dados:
			modelBuilder.Entity<Diagnostico>()
				.HasKey(d => d.cod_diagnostico);

			//Define que a propriedade CodDiagnosticoEspecificacao é a chave primária da tabela DIAGNOSTICO_ESPECIFICACAO no banco de dados:
			modelBuilder.Entity<DiagnosticoEspecificacao>()
				.HasKey(de => de.CodDiagnosticoEspecificacao);

			modelBuilder.Entity<DiagnosticoEspecificacao>()
				.HasOne<Diagnostico>()                      //->Diz que cada DIAGNOSTICO_ESPECIFICACAO está relacionado a um único Diagnostico.
				.WithMany()									//->Indica que um DIAGNOSTICO pode estar relacionado com muitos.
				.HasForeignKey(de => de.CodDiagnostico);    //->Define que a chave estrangeira na tabela DIAGNOSTICO_ESPECIFICACAO é CodDiagnostico.

			modelBuilder.Entity<Atendimento>()
				.HasKey(a => a.num_atendimento);

			modelBuilder.Entity<Atendimento>()
				.HasOne<Paciente>()                         //->Cada Atendimento está associado a um único Paciente.
				.WithMany()                                 //->Um Paciente pode ter muitos Atendimentos.
				.HasForeignKey(a => a.cod_registro);         //->Define CodRegistro como a chave estrangeira que conecta o ATENDIMENTO ao PACIENTE.
		}
	}
}

//Comando usados para criar as tabelas no SQLEXPRESS:
//--Tabela PACIENTE
//CREATE TABLE PACIENTE (
//    cod_registro INT PRIMARY KEY IDENTITY(1,1),
//	cod_matricula VARCHAR(20),
//	cod_triagem VARCHAR(20),
//	cox_externo VARCHAR(20),
//	nom_paciente VARCHAR(100) NOT NULL,
//	dat_nascimento DATE,
//	dat_obito DATE NULL,
//	cod_cutis INT,
//	cod_escolaridade INT,
//	cod_profissao INT,
//	cod_diagnostico INT,
//	cod_diagnostico_especificacao INT,
//	num_csn VARCHAR(20),
//	dt_csn DATE,
//	log_ativo BIT DEFAULT 1
//);
//
//--Tabela DIAGNOSTICO
//CREATE TABLE DIAGNOSTICO (
//  cod_diagnostico INT PRIMARY KEY IDENTITY(1,1),
//	desc_diagnostico VARCHAR(255) NOT NULL
//);
//
//--Tabela DIAGNOSTICO_ESPECIFICACAO
//CREATE TABLE DIAGNOSTICO_ESPECIFICACAO (
//    cod_diagnostico_especificacao INT PRIMARY KEY IDENTITY(1,1),
//	cod_diagnostico INT,
//	desc_diagnostico_especificado VARCHAR(255),
//	FOREIGN KEY (cod_diagnostico) REFERENCES DIAGNOSTICO(cod_diagnostico)
//);
//
//--Tabela ATENDIMENTO
//CREATE TABLE ATENDIMENTO (
//  num_atendimento INT PRIMARY KEY IDENTITY(1,1),
//	tipo_atendimento VARCHAR(50),
//	cod_registro INT,
//	cod_convenio INT,
//	cod_plano INT,
//	dt_inicio DATETIME,
//	dt_fim DATETIME,
//	cod_conclusao INT,
//	log_fechado BIT DEFAULT 0,
//	cod_usuario INT,
//	cod_usuario_fechou INT,
//	cod_usuario_assistente INT,
//	num_pedido_internacao INT,
//	cod_local INT,
//	cod_instituicao_destino INT,
//	FOREIGN KEY (cod_registro) REFERENCES PACIENTE(cod_registro)
//);

//07-02-2025:
//CREATE TABLE USUARIO (
//   cod_usuario INT PRIMARY KEY IDENTITY(1,1),
//   nome_usuario VARCHAR(100),
//   senha VARCHAR(100),
//   nivel_usuario INT
//)