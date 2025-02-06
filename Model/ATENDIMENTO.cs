using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSaude.Model
{
	[Table("ATENDIMENTO")]
	public class Atendimento
	{
		public int num_atendimento { get; set; }
		public string tipo_atendimento { get; set; }
		public int cod_registro { get; set; }
		public int? cod_convenio { get; set; }
		public int? cod_plano { get; set; }
		public DateTime dt_inicio { get; set; }
		public DateTime? dt_fim { get; set; }
		public int? cod_conclusao { get; set; }
		public bool log_fechado { get; set; }
		public int? cod_usuario { get; set; }
		public int? cod_usuario_fechou { get; set; }
		public int? cod_usuario_assistente { get; set; }
		public int? num_pedido_internacao { get; set; }
		public int? cod_local { get; set; }
		public int? cod_instituicao_destino { get; set; }
	}
}
