using SistemaSaude.Model;

namespace SistemaSaude.Controller
{
	public class BuscarTipos
	{
		public Task<List<_Tipos>> ObterTipos()
		{
			// Tipos de Atendimento Médico
			List<_Tipos> listaTipos = new List<_Tipos>()
			{
				new _Tipos(1, "Atendimento de Emergência"),
				new _Tipos(2, "Atendimento Ambulatorial"),
				new _Tipos(3, "Atendimento Domiciliar"),
				new _Tipos(4, "Atendimento Hospitalar"),
				new _Tipos(5, "Atendimento Cirúrgico"),
			};

			// Retorna a lista de tipos:
			return Task.FromResult(listaTipos);
		}
	}
}