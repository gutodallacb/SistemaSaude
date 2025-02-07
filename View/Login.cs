using SistemaSaude.Controller;

namespace SistemaSaude.View
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			SenhaTextBox.PasswordChar = '*';
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string usuario = UsuarioTextBox.Text;
			string senha = SenhaTextBox.Text;

			bool testaLogin = UsuarioLogin.ValidarLogin(usuario, senha);

			if (testaLogin)
			{
				SistemaSaude telaPrincipal = new SistemaSaude();

				telaPrincipal.Show();
				this.Hide();
			}
			else
			{
				UsuarioTextBox.Text = "";
				SenhaTextBox.Text = "";
			}
		}

		private void CriarUsuarioButton_Click(object sender, EventArgs e)
		{
			CreateUser criarUsuario = new CreateUser();

			criarUsuario.Show();
			this.Hide();
		}

		private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
