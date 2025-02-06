using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSaude.Model
{
	[Table("DIAGNOSTICO_ESPECIFICACAO")]
	public class DiagnosticoEspecificacao
	{
		public int CodDiagnosticoEspecificacao { get; set; }
		public int CodDiagnostico { get; set; }
		public string DescDiagnosticoEspecificado { get; set; }
	}
}
