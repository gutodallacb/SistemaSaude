﻿using ProjetoSQLserver.Model;
using SistemaSaude;
using SistemaSaude.Model;

namespace SistemaSaude.Controller
{
	public class UserCreation
	{
		public bool CreateUser(string usuario, string senha)
		{
			try
			{
				using (var context = new MeuDbContext_ORM())
				{
					// Verificar se o usuário já existe no banco
					var usuarioExistente = context.Usuarios.FirstOrDefault(u => u.nome_usuario == usuario);

					if (usuarioExistente != null)
					{
						MessageBox.Show($"O usuário {usuario} já existe no banco de dados!");
						return false;
					}
					else
					{

						// Criar um novo usuário
						var novoUsuario = new Usuario
						{
							nome_usuario = usuario,
							senha = senha,
							nivel_usuario = 1
						};

						// Adicionar o novo usuário ao contexto e salvar no banco
						context.Usuarios.Add(novoUsuario);
						int result = context.SaveChanges();

						if (result > 0)
						{
							MessageBox.Show($"O usuário {usuario} foi criado com sucesso!");
							return true;
						}
						else
						{
							MessageBox.Show($"Falha ao criar o usuário: {usuario}!");
							return false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}");
				return false;
			}
		}
	}
}