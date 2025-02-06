using SistemaSaude.Model;
using SistemaSaude.View;

namespace SistemaSaude
{
	public partial class SistemaSaude : Form
	{
		public SistemaSaude()
		{
			InitializeComponent();
			CarregaEscolaridade();
			CarregarDiagnosticos();

			//Limpar campos para os ComboBox não iniciarem com informaçoes:
			LimparCampos();
		}

		public void CarregaEscolaridade()
		{
			//Escolaridade:
			List<_Escolaridade> listaEscolaridade = new List<_Escolaridade>()
			{
				new _Escolaridade(1, "Ensino Fundamental Incompleto"),
				new _Escolaridade(2, "Ensino Fundamental Completo"),
				new _Escolaridade(3, "Ensino Médio Incompleto"),
				new _Escolaridade(4, "Ensino Médio Completo"),
				new _Escolaridade(5, "Ensino Superior Incompleto"),
				new _Escolaridade(6, "Ensino Superior Completo"),
				new _Escolaridade(7, "Pós-graduação"),
				new _Escolaridade(8, "Mestrado"),
				new _Escolaridade(9, "Doutorado")
			};

			comboBoxEscolaridade.DataSource = listaEscolaridade;
			comboBoxEscolaridade.DisplayMember = "Nome";  //-> Exibe o nome da escolaridade
			comboBoxEscolaridade.ValueMember = "Id";      //-> Guarda o ID correspondente
		}

		public void CarregarDiagnosticos()
		{
			using (var context = new MeuDbContext_ORM())
			{
				// Obtém os dados do banco
				var listaDiagnosticosDB = context.Diagnosticos.ToList();

				// Converte para a lista de _Diagnostico
				List<_Diagnostico> listaDiagnosticos = listaDiagnosticosDB
					.Select(d => new _Diagnostico(d.cod_diagnostico, d.desc_diagnostico))
					.ToList();

				// Configura o ComboBox
				comboBoxDiagnostico.DataSource = listaDiagnosticos;
				comboBoxDiagnostico.DisplayMember = "Nome";   // Nome do diagnóstico
				comboBoxDiagnostico.ValueMember = "Id";       // Código do diagnóstico
			}
		}

		private void LimparCampos()
		{
			//Famoso ClearAll:
			textBoxMatricula.Clear();
			textBoxTriagem.Clear();
			textBoxCodExterno.Clear();
			textBoxNome.Clear();
			textBoxProfissao.Clear();
			textBoxCSN.Clear();

			dateTimePickerNascimento.Value = DateTime.Today;
			dateTimePickerCSN.Value = DateTime.Today;

			comboBoxEscolaridade.SelectedIndex = -1;
			comboBoxDiagnostico.SelectedIndex = -1;

			checkBoxAtivo.Checked = false;
		}

		private void buttonCadastrar_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}

		private void textBoxMatricula_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxTriagem_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxNome_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxAtivo_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string matricula = textBoxMatricula.Text;
			string triagem = textBoxTriagem.Text;
			string codExterno = textBoxCodExterno.Text;
			string nome = textBoxNome.Text;
			DateTime dataNascimento = dateTimePickerNascimento.Value;
			int codEscolaridade = (int)comboBoxEscolaridade.SelectedValue;
			string profissao = textBoxProfissao.Text;
			int diagnostico = (int)comboBoxDiagnostico.SelectedValue;
			int espDiagnostico = (int)comboBoxEspDiagnostico.SelectedValue;
			string csn = textBoxCSN.Text;
			DateTime dataCsn = dateTimePickerNascimento.Value;
			bool ativo = checkBoxAtivo.Checked;

			//Cria o objeto Paciente:
			var paciente = new Paciente
			{
				cod_matricula = matricula,
				cod_triagem = triagem,
				cox_externo = codExterno,
				nom_paciente = nome,
				dat_nascimento = dataNascimento,
				cod_escolaridade = codEscolaridade,
				cod_profissao = profissao,
				cod_diagnostico = diagnostico,
				cod_diagnostico_especificacao = espDiagnostico,
				num_csn = csn,
				dt_csn = dataCsn,
				log_ativo = ativo
			};

			//Salva no banco de dados:
			using (var context = new MeuDbContext_ORM())
			{
				context.Pacientes.Add(paciente);
				context.SaveChanges();
			}

			MessageBox.Show($"Paciente {nome} cadastrado com sucesso!");
			LimparCampos();
		}

		private void comboBoxEscolaridade_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void comboBoxEscolaridade_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			CriarDignostico criarDignostico = new CriarDignostico();
			criarDignostico.ShowDialog();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBoxCodExterno_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
	}
}
