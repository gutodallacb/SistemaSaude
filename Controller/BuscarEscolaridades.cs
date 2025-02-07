using SistemaSaude.Model;

namespace SistemaSaude.Controller
{
    public class BuscarEscolaridades
	{
		public Task<List<_Escolaridade>> ObterEscolaridades()
		{
			//Escolaridade:
			List<_Escolaridade> listaEscolaridade = new List<_Escolaridade>()
				{
					new _Escolaridade(1, "Ensino Fundamental Incompleto"),
					new _Escolaridade(2, "Ensino Fundamental Completo"),
					new _Escolaridade(3, "Ensino Médio Incompleto"),
					new _Escolaridade(4, "Ensino Médio Completo"),
					new _Escolaridade(5, "Ensino Superior Incompleto"),
					new _Escolaridade(6, "Ensino Superior Completo"),
					new _Escolaridade(7, "Pós-graduação"),
					new _Escolaridade(8, "Mestrado"),
					new _Escolaridade(9, "Doutorado")
				};

			//Retorna a lista de Task da classe _Escolaridade:
			return Task.FromResult(listaEscolaridade);
		}
	}
}

