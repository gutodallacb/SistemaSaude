namespace SistemaSaude.Model
{
	public class _Planos
	{
		public int Id { get; set; }
		public string Descricao { get; set; }

		public _Planos(int id, string nome)
		{
			Id = id;
			Descricao = nome;
		}
	}
}
