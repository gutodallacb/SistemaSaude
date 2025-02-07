using SistemaSaude.Model;

namespace SistemaSaude.Controller
{
	public class BuscarConvenios
	{
		public Task<List<_Convenios>> ObterConvenios()
		{
			// Convenios de Atendimento Médico
			List<_Convenios> listaConvenios = new List<_Convenios>()
			{
				new _Convenios(1, "Unimed Bento Gonçalves"),
				new _Convenios(2, "Hospital Tacchini"),
			};

			// Retorna a lista de Convenios:
			return Task.FromResult(listaConvenios);
		}
	}
}