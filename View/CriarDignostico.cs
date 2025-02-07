using SistemaSaude.Model;

namespace SistemaSaude.View
{
	public partial class CriarDignostico : Form
	{
		public CriarDignostico()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string descricao = textBox2.Text;

			//Cria novo diagnóstico:
			var diagnostico = new Diagnostico
			{
				desc_diagnostico = descricao
			};

			//Salva no banco de dados:
			using (var context = new MeuDbContext_ORM())
			{
				context.Diagnosticos.Add(diagnostico);
				context.SaveChanges();
			}

			MessageBox.Show($"O diagnóstico {descricao} foi criado com sucesso! Agora você poderá usar no sistema!");
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			SistemaSaude sistemaSaude = new SistemaSaude();
			sistemaSaude.ShowDialog();

			sistemaSaude.CarregarDiagnosticos();
		}

		private void CriarDignostico_Load(object sender, EventArgs e)
		{

		}
	}
}
