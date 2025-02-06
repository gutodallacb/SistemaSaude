using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSaude.Model
{
	[Table("PACIENTE")]
	public class Paciente
	{
		public int cod_registro { get; set; }
		public string cod_matricula { get; set; }
		public string cod_triagem { get; set; }
		public string cox_externo { get; set; }
		public string nom_paciente { get; set; }
		public DateTime? dat_nascimento { get; set; }
		public DateTime? dat_obito { get; set; }
		public int? cod_cutis { get; set; }
		public int? cod_escolaridade { get; set; }
		public string? cod_profissao { get; set; }
		public int? cod_diagnostico { get; set; }
		public int? cod_diagnostico_especificacao { get; set; }
		public string num_csn { get; set; }
		public DateTime? dt_csn { get; set; }
		public bool log_ativo { get; set; }
	}
}
