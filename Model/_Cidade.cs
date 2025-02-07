using System.Text.Json.Serialization;

namespace SistemaSaude.Model
{
	public class _Cidade
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("nome")]
		public string Nome { get; set; }
	}
}
