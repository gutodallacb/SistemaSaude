namespace SistemaSaude.Model
{
	public class _Usuarios
	{
		public int Id { get; set; }
		public string Nome { get; set; }

		public _Usuarios(int id, string nome)
		{
			Id = id;
			Nome = nome;
		}
	}
}
