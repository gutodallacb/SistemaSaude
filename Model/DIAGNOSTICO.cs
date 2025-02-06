using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSaude.Model
{
	[Table("DIAGNOSTICO")]
	public class Diagnostico
	{
		public int cod_diagnostico { get; set; }
		public string desc_diagnostico { get; set; }
	}

}
