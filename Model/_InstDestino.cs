namespace SistemaSaude.Model
{
	public class _InstDestinos
	{
		public int Id { get; set; }
		public string Descricao { get; set; }

		public _InstDestinos(int id, string nome)
		{
			Id = id;
			Descricao = nome;
		}
	}
}
