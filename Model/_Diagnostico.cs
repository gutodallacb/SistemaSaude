﻿namespace SistemaSaude.Model
{
	public class _Diagnostico
	{
		public int Id { get; set; }
		public string Nome { get; set; }

		public _Diagnostico(int id, string nome)
		{
			Id = id;
			Nome = nome;
		}
	}
}
