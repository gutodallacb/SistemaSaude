using SistemaSaude.Model;

namespace SistemaSaude.Controller
{
	public class BuscarPlanos
	{
		public Task<List<_Planos>> ObterPlanos()
		{
			// Planos de Atendimento Médico
			List<_Planos> listaPlanos = new List<_Planos>()
			{
				new _Planos(1, "Plano Unimed Bento Gonçalves"),
				new _Planos(2, "Plano Tacchini - Hospital Tacchini"),
			};

			// Retorna a lista de Planos:
			return Task.FromResult(listaPlanos);
		}
	}
}