using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSQLserver.Model
{
	[Table("USUARIO")]
	public class Usuario
	{
		public int cod_usuario { get; set; }
		public string nome_usuario { get; set; }
		public string senha { get; set; }
		public int nivel_usuario { get; set; }
	}
}
