namespace SistemaSaude.Model
{
	public class _Convenios
	{
		public int Id { get; set; }
		public string Descricao { get; set; }

		public _Convenios(int id, string nome)
		{
			Id = id;
			Descricao = nome;
		}
	}
}
