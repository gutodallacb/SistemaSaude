using SistemaSaude.Model;

namespace SistemaSaude.Controller
{
	public class UsuarioLogin
	{
		public static bool ValidarLogin(string usuario, string senha)
		{
			try
			{
				using (var context = new MeuDbContext_ORM())
				{
					// Verifica se o usuário existe
					var usuarioEncontrado = context.Usuarios.FirstOrDefault(u => u.nome_usuario == usuario);

					if (usuarioEncontrado == null)
					{
						MessageBox.Show("Usuário não encontrado!");
						return false;
					}

					// Verifica se a senha está correta
					if (usuarioEncontrado.senha != senha)
					{
						MessageBox.Show("Senha incorreta!");
						return false;
					}

					// Se passou pelos testes, login bem-sucedido
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possível conectar ao banco! Erro: " + ex.Message);
				return false;
			}
		}
	}
}