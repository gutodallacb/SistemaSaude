namespace SistemaSaude.Model
{
	public class _Tipos
	{
		public int Id { get; set; }
		public string Descricao { get; set; }

		public _Tipos(int id, string nome)
		{
			Id = id;
			Descricao = nome;
		}
	}
}
