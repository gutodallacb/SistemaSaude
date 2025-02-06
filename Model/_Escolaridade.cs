namespace SistemaSaude.Model
{
	public class _Escolaridade
	{
		public int Id { get; set; }
		public string Nome { get; set; }

		public _Escolaridade(int id, string nome)
		{
			Id = id;
			Nome = nome;
		}
	}
}
