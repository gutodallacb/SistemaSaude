namespace SistemaSaude.Model
{
	public class _Pacientes
	{
		public int Id { get; set; }
		public string Nome { get; set; }

		public _Pacientes(int id, string nome)
		{
			Id = id;
			Nome = nome;
		}
	}
}
