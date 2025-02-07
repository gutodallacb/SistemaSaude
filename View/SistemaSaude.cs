using SistemaSaude.Controller;
using SistemaSaude.Model;
using SistemaSaude.View;
using Microsoft.EntityFrameworkCore;

namespace SistemaSaude
{
	public partial class SistemaSaude : Form
	{
		public SistemaSaude()
		{
			InitializeComponent();
			CarregaEscolaridade();
			CarregarDiagnosticos();
			CarregarCidades();
			CarregarPacientes();
			CarregaTipos();
			CarregaConvenios();
			CarregaPlanos();
			CarregaUsuarios();
			CarregaUsuarios2();
			CarregaUsuarios3();

			this.StartPosition = FormStartPosition.CenterScreen;

			//Limpar campos para os ComboBox não iniciarem com informaçoes:
			LimparCampos();
		}

		public async void CarregaEscolaridade()
		{
			try
			{
				var buscarEscolaridades = new BuscarEscolaridades();
				List<_Escolaridade> escolaridades = await buscarEscolaridades.ObterEscolaridades();

				comboBoxEscolaridade.DataSource = escolaridades;
				comboBoxEscolaridade.DisplayMember = "Nome";
				comboBoxEscolaridade.ValueMember = "Id";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}");
				throw;
			}
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
				comboBoxDiagnostico.DisplayMember = "Nome";
				comboBoxDiagnostico.ValueMember = "Id";
			}
		}

		public async void CarregarCidades()
		{
			//API que carrega todas cidade do RS:
			try
			{
				var buscarLocais = new BuscarLocais();
				List<_Cidade> cidades = await buscarLocais.ObterCidadesRS();

				comboBoxLocais.DataSource = cidades;
				comboBoxLocais.DisplayMember = "Nome";
				comboBoxLocais.ValueMember = "Id";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}");
				throw;
			}
		}
		private void CarregarPacientes()
		{
			using (var context = new MeuDbContext_ORM())
			{
				// Obtém os dados do banco
				var listaPacientesDb = context.Pacientes.ToList();

				// Converte para a lista de _Diagnostico
				List<_Pacientes> listaPacientes = listaPacientesDb
					.Select(p => new _Pacientes(p.cod_registro, p.nom_paciente))
					.ToList();

				// Configura o ComboBox
				comboBoxPaciente.DataSource = listaPacientes;
				comboBoxPaciente.DisplayMember = "Nome";
				comboBoxPaciente.ValueMember = "Id";
			}
		}

		public async void CarregaTipos()
		{
			try
			{
				var buscarTipos = new BuscarTipos();
				List<_Tipos> tipos = await buscarTipos.ObterTipos();

				comboBoxTipo.DataSource = tipos;
				comboBoxTipo.DisplayMember = "Descricao";
				comboBoxTipo.ValueMember = "Id";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}");
				throw;
			}
		}

		public async void CarregaConvenios()
		{
			try
			{
				var buscarConvenios = new BuscarConvenios();
				List<_Convenios> convenios = await buscarConvenios.ObterConvenios();

				comboBoxConvenio.DataSource = convenios;
				comboBoxConvenio.DisplayMember = "Descricao";
				comboBoxConvenio.ValueMember = "Id";

				comboBoxInstDestino.DataSource = convenios;
				comboBoxInstDestino.DisplayMember = "Descricao";
				comboBoxInstDestino.ValueMember = "Id";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}");
				throw;
			}
		}

		public async void CarregaPlanos()
		{
			try
			{
				var buscarPlanos = new BuscarPlanos();
				List<_Planos> planos = await buscarPlanos.ObterPlanos();

				comboBoxPlano.DataSource = planos;
				comboBoxPlano.DisplayMember = "Descricao";
				comboBoxPlano.ValueMember = "Id";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}");
				throw;
			}
		}

		public async void CarregaUsuarios()
		{
			using (var context = new MeuDbContext_ORM())
			{
				var listaUsuariosDb = context.Usuarios.ToList();

				List<_Usuarios> listaUsuarios = listaUsuariosDb
					.Select(u => new _Usuarios(u.cod_usuario, u.nome_usuario))
					.ToList();

				comboBoxFechou.DataSource = listaUsuarios;
				comboBoxFechou.DisplayMember = "Nome";
				comboBoxFechou.ValueMember = "Id";
			}
		}

		public async void CarregaUsuarios2()
		{
			using (var context = new MeuDbContext_ORM())
			{
				var listaUsuariosDb = context.Usuarios.ToList();

				List<_Usuarios> listaUsuarios = listaUsuariosDb
					.Select(u => new _Usuarios(u.cod_usuario, u.nome_usuario))
					.ToList();

				//Aqui carrega os 3 comboboxs:
				comboBoxUsuResp.DataSource = listaUsuarios;
				comboBoxUsuResp.DisplayMember = "Nome";
				comboBoxUsuResp.ValueMember = "Id";
			}
		}

		public async void CarregaUsuarios3()
		{
			using (var context = new MeuDbContext_ORM())
			{
				var listaUsuariosDb = context.Usuarios.ToList();

				List<_Usuarios> listaUsuarios = listaUsuariosDb
					.Select(u => new _Usuarios(u.cod_usuario, u.nome_usuario))
					.ToList();

				comboBoxAssistente.DataSource = listaUsuarios;
				comboBoxAssistente.DisplayMember = "Nome";
				comboBoxAssistente.ValueMember = "Id";
			}
		}

		private void LimparCampos()
		{
			//Famoso ClearAll:

			//Tab1:
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

			//Tab2:
			textBoxPedidoInt.Clear();

			comboBoxPaciente.SelectedIndex = -1;
			comboBoxTipo.SelectedIndex = -1;
			comboBoxConvenio.SelectedIndex = -1;
			comboBoxPlano.SelectedIndex = -1;
			comboBoxLocais.SelectedIndex = -1;
			comboBoxInstDestino.SelectedIndex = -1;
			comboBoxUsuResp.SelectedIndex = -1;
			comboBoxFechou.SelectedIndex = -1;
			comboBoxAssistente.SelectedIndex = -1;

			dateTimePickerDtIni.Value = DateTime.Today;
			dateTimePickerDtFin.Value = DateTime.Today;
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
				cod_diagnostico_especificacao = 0,
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
			CarregarPacientes();
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

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int paciente = (int)comboBoxPaciente.SelectedValue;
			int tipo = (int)comboBoxTipo.SelectedValue;
			int convenio = (int)comboBoxConvenio.SelectedValue;
			DateTime dtIni = dateTimePickerDtIni.Value;
			DateTime dtFin = dateTimePickerDtFin.Value;
			int pedido = int.Parse(textBoxPedidoInt.Text);
			int local = (int)comboBoxLocais.SelectedValue;
			int instituicao = (int)comboBoxInstDestino.SelectedValue;
			int usuarioResponsavel = (int)comboBoxUsuResp.SelectedValue;
			int usuarioFechou = (int)comboBoxFechou.SelectedValue;
			int usuarioAssistente = (int)comboBoxAssistente.SelectedValue;

			string tipoString = tipo.ToString();

			//Cria o objeto Paciente:
			var atendimento = new Atendimento
			{
				cod_registro = paciente,
				tipo_atendimento = tipoString,
				cod_convenio = convenio,
				dt_inicio = dtIni,
				dt_fim = dtFin,
				num_pedido_internacao = pedido,
				cod_local = local,
				cod_instituicao_destino = instituicao,
				cod_usuario = usuarioResponsavel,
				cod_usuario_fechou = usuarioFechou,
				cod_usuario_assistente = usuarioAssistente
			};

			//Salva no banco de dados:
			using (var context = new MeuDbContext_ORM())
			{
				context.Atendimentos.Add(atendimento);
				context.SaveChanges();
			}

			MessageBox.Show($"Atendimento salvo com sucesso!");
			CarregarPacientes();
			LimparCampos();
		}

		private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxInstDestino_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}

		private void TabAtendimento_Click(object sender, EventArgs e)
		{

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			LoadPacientes();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			LoadAtendimentos();
		}

		private void LoadPacientes()
		{
			dataGridViewPacientes.Font = new Font("Arial", 8.25f);

			using (var context = new MeuDbContext_ORM())
			{
				var pacientes = context.Pacientes
									.Select(p => new
									{
										p.cod_registro,
										p.cod_matricula,
										p.nom_paciente,
										p.dat_nascimento,
										p.log_ativo
									})
									.ToList();

				dataGridViewPacientes.DataSource = pacientes;

				dataGridViewPacientes.Columns["cod_registro"].HeaderText = "Cód. Registro";
				dataGridViewPacientes.Columns["cod_matricula"].HeaderText = "Matrícula";
				dataGridViewPacientes.Columns["nom_paciente"].HeaderText = "Paciente";
				dataGridViewPacientes.Columns["dat_nascimento"].HeaderText = "Dt Nascimento";
				dataGridViewPacientes.Columns["log_ativo"].HeaderText = "Ativo";
			}
		}

		// Carregar os Atendimentos na DataGridView
		private void LoadAtendimentos()
		{
			dataGridViewAtendimentos.Font = new Font("Arial", 8.25f);

			using (var context = new MeuDbContext_ORM())
			{
				var atendimentos = context.Atendimentos
										.Join(context.Pacientes, a => a.cod_registro, p => p.cod_registro,
												(a, p) => new
												{
													a.num_atendimento,
													a.tipo_atendimento,
													a.dt_inicio,
													a.dt_fim,
													a.cod_convenio,
													a.cod_plano,
													a.log_fechado,
													PacienteNome = p.nom_paciente
												})
										.ToList();

				dataGridViewAtendimentos.DataSource = atendimentos;

				dataGridViewAtendimentos.Columns["num_atendimento"].HeaderText = "Número Atendimento";
				dataGridViewAtendimentos.Columns["tipo_atendimento"].HeaderText = "Tipo de Atendimento";
				dataGridViewAtendimentos.Columns["dt_inicio"].HeaderText = "Dt Início";
				dataGridViewAtendimentos.Columns["dt_fim"].HeaderText = "Dt Fim";
				dataGridViewAtendimentos.Columns["cod_convenio"].HeaderText = "Convênio";
				dataGridViewAtendimentos.Columns["cod_plano"].HeaderText = "Plano";
				dataGridViewAtendimentos.Columns["log_fechado"].HeaderText = "Fechado";
				dataGridViewAtendimentos.Columns["PacienteNome"].HeaderText = "Nome do Paciente";
			}
		}
	}
}
