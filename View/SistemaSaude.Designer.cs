namespace SistemaSaude
{
	partial class SistemaSaude
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabGeral = new TabControl();
			tabPage1 = new TabPage();
			button2 = new Button();
			buttonCadastrar = new Button();
			dateTimePickerCSN = new DateTimePicker();
			label25 = new Label();
			textBoxCSN = new TextBox();
			label21 = new Label();
			comboBoxDiagnostico = new ComboBox();
			label23 = new Label();
			textBoxProfissao = new TextBox();
			comboBoxEscolaridade = new ComboBox();
			label22 = new Label();
			textBoxCodExterno = new TextBox();
			label20 = new Label();
			buttonLimpar = new Button();
			checkBoxAtivo = new CheckBox();
			dateTimePickerNascimento = new DateTimePicker();
			textBoxNome = new TextBox();
			textBoxTriagem = new TextBox();
			textBoxMatricula = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			TabAtendimento = new TabPage();
			button3 = new Button();
			button1 = new Button();
			label19 = new Label();
			comboBoxInstDestino = new ComboBox();
			label18 = new Label();
			comboBoxLocais = new ComboBox();
			label17 = new Label();
			textBoxPedidoInt = new TextBox();
			label16 = new Label();
			label15 = new Label();
			label14 = new Label();
			comboBoxAssistente = new ComboBox();
			comboBoxFechou = new ComboBox();
			comboBoxUsuResp = new ComboBox();
			label11 = new Label();
			comboBoxPlano = new ComboBox();
			label10 = new Label();
			dateTimePickerDtFin = new DateTimePicker();
			label9 = new Label();
			comboBoxConvenio = new ComboBox();
			label8 = new Label();
			comboBoxTipo = new ComboBox();
			label7 = new Label();
			dateTimePickerDtIni = new DateTimePicker();
			label6 = new Label();
			comboBoxPaciente = new ComboBox();
			Consulta = new TabPage();
			button5 = new Button();
			button4 = new Button();
			label13 = new Label();
			label12 = new Label();
			dataGridViewAtendimentos = new DataGridView();
			dataGridViewPacientes = new DataGridView();
			tabGeral.SuspendLayout();
			tabPage1.SuspendLayout();
			TabAtendimento.SuspendLayout();
			Consulta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewAtendimentos).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
			SuspendLayout();
			// 
			// tabGeral
			// 
			tabGeral.Controls.Add(tabPage1);
			tabGeral.Controls.Add(TabAtendimento);
			tabGeral.Controls.Add(Consulta);
			tabGeral.Location = new Point(8, 5);
			tabGeral.Name = "tabGeral";
			tabGeral.SelectedIndex = 0;
			tabGeral.Size = new Size(506, 339);
			tabGeral.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(button2);
			tabPage1.Controls.Add(buttonCadastrar);
			tabPage1.Controls.Add(dateTimePickerCSN);
			tabPage1.Controls.Add(label25);
			tabPage1.Controls.Add(textBoxCSN);
			tabPage1.Controls.Add(label21);
			tabPage1.Controls.Add(comboBoxDiagnostico);
			tabPage1.Controls.Add(label23);
			tabPage1.Controls.Add(textBoxProfissao);
			tabPage1.Controls.Add(comboBoxEscolaridade);
			tabPage1.Controls.Add(label22);
			tabPage1.Controls.Add(textBoxCodExterno);
			tabPage1.Controls.Add(label20);
			tabPage1.Controls.Add(buttonLimpar);
			tabPage1.Controls.Add(checkBoxAtivo);
			tabPage1.Controls.Add(dateTimePickerNascimento);
			tabPage1.Controls.Add(textBoxNome);
			tabPage1.Controls.Add(textBoxTriagem);
			tabPage1.Controls.Add(textBoxMatricula);
			tabPage1.Controls.Add(label5);
			tabPage1.Controls.Add(label4);
			tabPage1.Controls.Add(label3);
			tabPage1.Controls.Add(label2);
			tabPage1.Controls.Add(label1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(498, 311);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Cadastro Paciente";
			tabPage1.UseVisualStyleBackColor = true;
			tabPage1.Click += tabPage1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(352, 177);
			button2.Name = "button2";
			button2.Size = new Size(136, 23);
			button2.TabIndex = 31;
			button2.Text = "Criar Dignóstico";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// buttonCadastrar
			// 
			buttonCadastrar.Location = new Point(243, 272);
			buttonCadastrar.Name = "buttonCadastrar";
			buttonCadastrar.Size = new Size(245, 32);
			buttonCadastrar.TabIndex = 30;
			buttonCadastrar.Text = "Cadastrar Paciente";
			buttonCadastrar.UseVisualStyleBackColor = true;
			buttonCadastrar.Click += button2_Click;
			// 
			// dateTimePickerCSN
			// 
			dateTimePickerCSN.Location = new Point(157, 210);
			dateTimePickerCSN.Name = "dateTimePickerCSN";
			dateTimePickerCSN.Size = new Size(331, 23);
			dateTimePickerCSN.TabIndex = 29;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Location = new Point(15, 213);
			label25.Name = "label25";
			label25.Size = new Size(33, 15);
			label25.TabIndex = 27;
			label25.Text = "CSN:";
			// 
			// textBoxCSN
			// 
			textBoxCSN.Location = new Point(54, 210);
			textBoxCSN.Name = "textBoxCSN";
			textBoxCSN.Size = new Size(97, 23);
			textBoxCSN.TabIndex = 26;
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(11, 180);
			label21.Name = "label21";
			label21.Size = new Size(73, 15);
			label21.TabIndex = 23;
			label21.Text = "Diagnóstico:";
			// 
			// comboBoxDiagnostico
			// 
			comboBoxDiagnostico.FormattingEnabled = true;
			comboBoxDiagnostico.Location = new Point(88, 177);
			comboBoxDiagnostico.Name = "comboBoxDiagnostico";
			comboBoxDiagnostico.Size = new Size(258, 23);
			comboBoxDiagnostico.TabIndex = 22;
			comboBoxDiagnostico.SelectedIndexChanged += comboBoxDiagnostico_SelectedIndexChanged;
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new Point(292, 149);
			label23.Name = "label23";
			label23.Size = new Size(58, 15);
			label23.TabIndex = 21;
			label23.Text = "Profissão:";
			// 
			// textBoxProfissao
			// 
			textBoxProfissao.Location = new Point(352, 146);
			textBoxProfissao.Name = "textBoxProfissao";
			textBoxProfissao.Size = new Size(136, 23);
			textBoxProfissao.TabIndex = 20;
			// 
			// comboBoxEscolaridade
			// 
			comboBoxEscolaridade.FormattingEnabled = true;
			comboBoxEscolaridade.Location = new Point(88, 145);
			comboBoxEscolaridade.Name = "comboBoxEscolaridade";
			comboBoxEscolaridade.Size = new Size(198, 23);
			comboBoxEscolaridade.TabIndex = 19;
			comboBoxEscolaridade.SelectedIndexChanged += comboBoxEscolaridade_SelectedIndexChanged_1;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(10, 149);
			label22.Name = "label22";
			label22.Size = new Size(76, 15);
			label22.TabIndex = 18;
			label22.Text = "Escolaridade:";
			// 
			// textBoxCodExterno
			// 
			textBoxCodExterno.Location = new Point(94, 46);
			textBoxCodExterno.Name = "textBoxCodExterno";
			textBoxCodExterno.Size = new Size(394, 23);
			textBoxCodExterno.TabIndex = 14;
			textBoxCodExterno.TextChanged += textBoxCodExterno_TextChanged;
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(15, 49);
			label20.Name = "label20";
			label20.Size = new Size(78, 15);
			label20.TabIndex = 13;
			label20.Text = "Cód. Externo:";
			// 
			// buttonLimpar
			// 
			buttonLimpar.Location = new Point(6, 272);
			buttonLimpar.Name = "buttonLimpar";
			buttonLimpar.Size = new Size(232, 32);
			buttonLimpar.TabIndex = 12;
			buttonLimpar.Text = "Limpar Campos";
			buttonLimpar.UseVisualStyleBackColor = true;
			buttonLimpar.Click += buttonCadastrar_Click;
			// 
			// checkBoxAtivo
			// 
			checkBoxAtivo.AutoSize = true;
			checkBoxAtivo.Location = new Point(54, 249);
			checkBoxAtivo.Name = "checkBoxAtivo";
			checkBoxAtivo.Size = new Size(15, 14);
			checkBoxAtivo.TabIndex = 11;
			checkBoxAtivo.UseVisualStyleBackColor = true;
			checkBoxAtivo.CheckedChanged += checkBoxAtivo_CheckedChanged;
			// 
			// dateTimePickerNascimento
			// 
			dateTimePickerNascimento.Location = new Point(157, 112);
			dateTimePickerNascimento.Name = "dateTimePickerNascimento";
			dateTimePickerNascimento.Size = new Size(331, 23);
			dateTimePickerNascimento.TabIndex = 10;
			// 
			// textBoxNome
			// 
			textBoxNome.Location = new Point(94, 80);
			textBoxNome.Name = "textBoxNome";
			textBoxNome.Size = new Size(394, 23);
			textBoxNome.TabIndex = 7;
			textBoxNome.TextChanged += textBoxNome_TextChanged;
			// 
			// textBoxTriagem
			// 
			textBoxTriagem.Location = new Point(324, 14);
			textBoxTriagem.Name = "textBoxTriagem";
			textBoxTriagem.Size = new Size(164, 23);
			textBoxTriagem.TabIndex = 6;
			textBoxTriagem.TextChanged += textBoxTriagem_TextChanged;
			// 
			// textBoxMatricula
			// 
			textBoxMatricula.Location = new Point(94, 14);
			textBoxMatricula.Name = "textBoxMatricula";
			textBoxMatricula.Size = new Size(166, 23);
			textBoxMatricula.TabIndex = 5;
			textBoxMatricula.TextChanged += textBoxMatricula_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(10, 248);
			label5.Name = "label5";
			label5.Size = new Size(38, 15);
			label5.TabIndex = 4;
			label5.Text = "Ativo:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(34, 116);
			label4.Name = "label4";
			label4.Size = new Size(117, 15);
			label4.TabIndex = 3;
			label4.Text = "Data de Nascimento:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(48, 83);
			label3.Name = "label3";
			label3.Size = new Size(43, 15);
			label3.TabIndex = 2;
			label3.Text = "Nome:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(266, 17);
			label2.Name = "label2";
			label2.Size = new Size(52, 15);
			label2.TabIndex = 1;
			label2.Text = "Triagem:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(33, 17);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 0;
			label1.Text = "Matrícula:";
			label1.Click += label1_Click;
			// 
			// TabAtendimento
			// 
			TabAtendimento.Controls.Add(button3);
			TabAtendimento.Controls.Add(button1);
			TabAtendimento.Controls.Add(label19);
			TabAtendimento.Controls.Add(comboBoxInstDestino);
			TabAtendimento.Controls.Add(label18);
			TabAtendimento.Controls.Add(comboBoxLocais);
			TabAtendimento.Controls.Add(label17);
			TabAtendimento.Controls.Add(textBoxPedidoInt);
			TabAtendimento.Controls.Add(label16);
			TabAtendimento.Controls.Add(label15);
			TabAtendimento.Controls.Add(label14);
			TabAtendimento.Controls.Add(comboBoxAssistente);
			TabAtendimento.Controls.Add(comboBoxFechou);
			TabAtendimento.Controls.Add(comboBoxUsuResp);
			TabAtendimento.Controls.Add(label11);
			TabAtendimento.Controls.Add(comboBoxPlano);
			TabAtendimento.Controls.Add(label10);
			TabAtendimento.Controls.Add(dateTimePickerDtFin);
			TabAtendimento.Controls.Add(label9);
			TabAtendimento.Controls.Add(comboBoxConvenio);
			TabAtendimento.Controls.Add(label8);
			TabAtendimento.Controls.Add(comboBoxTipo);
			TabAtendimento.Controls.Add(label7);
			TabAtendimento.Controls.Add(dateTimePickerDtIni);
			TabAtendimento.Controls.Add(label6);
			TabAtendimento.Controls.Add(comboBoxPaciente);
			TabAtendimento.Location = new Point(4, 24);
			TabAtendimento.Name = "TabAtendimento";
			TabAtendimento.Padding = new Padding(3);
			TabAtendimento.Size = new Size(498, 311);
			TabAtendimento.TabIndex = 1;
			TabAtendimento.Text = "Atendimento";
			TabAtendimento.UseVisualStyleBackColor = true;
			TabAtendimento.Click += TabAtendimento_Click;
			// 
			// button3
			// 
			button3.Location = new Point(8, 272);
			button3.Name = "button3";
			button3.Size = new Size(239, 32);
			button3.TabIndex = 32;
			button3.Text = "Limpar Campos";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(253, 272);
			button1.Name = "button1";
			button1.Size = new Size(239, 32);
			button1.TabIndex = 31;
			button1.Text = "Salavar Atendimento";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(5, 200);
			label19.Name = "label19";
			label19.Size = new Size(124, 15);
			label19.TabIndex = 30;
			label19.Text = "Instituição de Destino:";
			// 
			// comboBoxInstDestino
			// 
			comboBoxInstDestino.FormattingEnabled = true;
			comboBoxInstDestino.Location = new Point(129, 196);
			comboBoxInstDestino.Name = "comboBoxInstDestino";
			comboBoxInstDestino.Size = new Size(353, 23);
			comboBoxInstDestino.TabIndex = 29;
			comboBoxInstDestino.SelectedIndexChanged += comboBoxInstDestino_SelectedIndexChanged;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(16, 170);
			label18.Name = "label18";
			label18.Size = new Size(38, 15);
			label18.TabIndex = 28;
			label18.Text = "Local:";
			// 
			// comboBoxLocais
			// 
			comboBoxLocais.FormattingEnabled = true;
			comboBoxLocais.Location = new Point(60, 166);
			comboBoxLocais.Name = "comboBoxLocais";
			comboBoxLocais.Size = new Size(422, 23);
			comboBoxLocais.TabIndex = 27;
			comboBoxLocais.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(11, 137);
			label17.Name = "label17";
			label17.Size = new Size(122, 15);
			label17.TabIndex = 26;
			label17.Text = "Pedido de internação:";
			// 
			// textBoxPedidoInt
			// 
			textBoxPedidoInt.Location = new Point(138, 134);
			textBoxPedidoInt.Name = "textBoxPedidoInt";
			textBoxPedidoInt.Size = new Size(344, 23);
			textBoxPedidoInt.TabIndex = 25;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(357, 223);
			label16.Name = "label16";
			label16.Size = new Size(63, 15);
			label16.TabIndex = 24;
			label16.Text = "Assistente:";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(208, 223);
			label15.Name = "label15";
			label15.Size = new Size(49, 15);
			label15.TabIndex = 23;
			label15.Text = "Fechou:";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(38, 223);
			label14.Name = "label14";
			label14.Size = new Size(75, 15);
			label14.TabIndex = 22;
			label14.Text = "Responsável:";
			// 
			// comboBoxAssistente
			// 
			comboBoxAssistente.FormattingEnabled = true;
			comboBoxAssistente.Location = new Point(325, 241);
			comboBoxAssistente.Name = "comboBoxAssistente";
			comboBoxAssistente.Size = new Size(150, 23);
			comboBoxAssistente.TabIndex = 21;
			// 
			// comboBoxFechou
			// 
			comboBoxFechou.FormattingEnabled = true;
			comboBoxFechou.Location = new Point(169, 241);
			comboBoxFechou.Name = "comboBoxFechou";
			comboBoxFechou.Size = new Size(150, 23);
			comboBoxFechou.TabIndex = 20;
			// 
			// comboBoxUsuResp
			// 
			comboBoxUsuResp.FormattingEnabled = true;
			comboBoxUsuResp.Location = new Point(16, 241);
			comboBoxUsuResp.Name = "comboBoxUsuResp";
			comboBoxUsuResp.Size = new Size(147, 23);
			comboBoxUsuResp.TabIndex = 18;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(253, 50);
			label11.Name = "label11";
			label11.Size = new Size(40, 15);
			label11.TabIndex = 13;
			label11.Text = "Plano:";
			// 
			// comboBoxPlano
			// 
			comboBoxPlano.FormattingEnabled = true;
			comboBoxPlano.Location = new Point(293, 46);
			comboBoxPlano.Name = "comboBoxPlano";
			comboBoxPlano.Size = new Size(189, 23);
			comboBoxPlano.TabIndex = 12;
			comboBoxPlano.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(10, 49);
			label10.Name = "label10";
			label10.Size = new Size(61, 15);
			label10.TabIndex = 11;
			label10.Text = "Convênio:";
			// 
			// dateTimePickerDtFin
			// 
			dateTimePickerDtFin.Location = new Point(73, 104);
			dateTimePickerDtFin.Name = "dateTimePickerDtFin";
			dateTimePickerDtFin.Size = new Size(409, 23);
			dateTimePickerDtFin.TabIndex = 10;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(11, 107);
			label9.Name = "label9";
			label9.Size = new Size(60, 15);
			label9.TabIndex = 9;
			label9.Text = "Data final:";
			// 
			// comboBoxConvenio
			// 
			comboBoxConvenio.FormattingEnabled = true;
			comboBoxConvenio.Location = new Point(73, 46);
			comboBoxConvenio.Name = "comboBoxConvenio";
			comboBoxConvenio.Size = new Size(174, 23);
			comboBoxConvenio.TabIndex = 8;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(257, 21);
			label8.Name = "label8";
			label8.Size = new Size(33, 15);
			label8.TabIndex = 7;
			label8.Text = "Tipo:";
			// 
			// comboBoxTipo
			// 
			comboBoxTipo.FormattingEnabled = true;
			comboBoxTipo.Location = new Point(293, 17);
			comboBoxTipo.Name = "comboBoxTipo";
			comboBoxTipo.Size = new Size(189, 23);
			comboBoxTipo.TabIndex = 6;
			comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(5, 79);
			label7.Name = "label7";
			label7.Size = new Size(66, 15);
			label7.TabIndex = 3;
			label7.Text = "Data início:";
			// 
			// dateTimePickerDtIni
			// 
			dateTimePickerDtIni.Location = new Point(73, 75);
			dateTimePickerDtIni.Name = "dateTimePickerDtIni";
			dateTimePickerDtIni.Size = new Size(409, 23);
			dateTimePickerDtIni.TabIndex = 2;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(16, 19);
			label6.Name = "label6";
			label6.Size = new Size(55, 15);
			label6.TabIndex = 1;
			label6.Text = "Paciente:";
			// 
			// comboBoxPaciente
			// 
			comboBoxPaciente.FormattingEnabled = true;
			comboBoxPaciente.Location = new Point(73, 16);
			comboBoxPaciente.Name = "comboBoxPaciente";
			comboBoxPaciente.Size = new Size(174, 23);
			comboBoxPaciente.TabIndex = 0;
			comboBoxPaciente.SelectedIndexChanged += comboBoxPaciente_SelectedIndexChanged;
			// 
			// Consulta
			// 
			Consulta.Controls.Add(button5);
			Consulta.Controls.Add(button4);
			Consulta.Controls.Add(label13);
			Consulta.Controls.Add(label12);
			Consulta.Controls.Add(dataGridViewAtendimentos);
			Consulta.Controls.Add(dataGridViewPacientes);
			Consulta.Location = new Point(4, 24);
			Consulta.Name = "Consulta";
			Consulta.Padding = new Padding(3);
			Consulta.Size = new Size(498, 311);
			Consulta.TabIndex = 2;
			Consulta.Text = "Consulta de pacientes e atendimentos";
			Consulta.UseVisualStyleBackColor = true;
			Consulta.Click += tabPage2_Click;
			// 
			// button5
			// 
			button5.Location = new Point(5, 282);
			button5.Name = "button5";
			button5.Size = new Size(75, 23);
			button5.TabIndex = 5;
			button5.Text = "Consultar";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button4
			// 
			button4.Location = new Point(3, 125);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 4;
			button4.Text = "Consultar";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(6, 158);
			label13.Name = "label13";
			label13.Size = new Size(151, 15);
			label13.TabIndex = 3;
			label13.Text = "Atendimentos cadastrados:";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(6, 3);
			label12.Name = "label12";
			label12.Size = new Size(126, 15);
			label12.TabIndex = 2;
			label12.Text = "Pacientes cadastrados:";
			// 
			// dataGridViewAtendimentos
			// 
			dataGridViewAtendimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewAtendimentos.Location = new Point(6, 176);
			dataGridViewAtendimentos.Name = "dataGridViewAtendimentos";
			dataGridViewAtendimentos.Size = new Size(486, 102);
			dataGridViewAtendimentos.TabIndex = 1;
			// 
			// dataGridViewPacientes
			// 
			dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPacientes.Location = new Point(6, 21);
			dataGridViewPacientes.Name = "dataGridViewPacientes";
			dataGridViewPacientes.Size = new Size(486, 101);
			dataGridViewPacientes.TabIndex = 0;
			// 
			// SistemaSaude
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(517, 350);
			Controls.Add(tabGeral);
			MaximumSize = new Size(533, 389);
			MinimumSize = new Size(533, 389);
			Name = "SistemaSaude";
			Text = "Sistema Saúde - Projeto Sofis";
			tabGeral.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			TabAtendimento.ResumeLayout(false);
			TabAtendimento.PerformLayout();
			Consulta.ResumeLayout(false);
			Consulta.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewAtendimentos).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabGeral;
		private TabPage tabPage1;
		private TabPage TabAtendimento;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label1;
		private Button buttonLimpar;
		private CheckBox checkBoxAtivo;
		private DateTimePicker dateTimePickerNascimento;
		private TextBox textBoxNome;
		private TextBox textBoxTriagem;
		private TextBox textBoxMatricula;
		private ComboBox comboBoxPaciente;
		private Label label6;
		private Label label7;
		private DateTimePicker dateTimePickerDtIni;
		private ComboBox comboBoxTipo;
		private Label label8;
		private Label label10;
		private DateTimePicker dateTimePickerDtFin;
		private Label label9;
		private ComboBox comboBoxConvenio;
		private Label label11;
		private ComboBox comboBoxPlano;
		private ComboBox comboBoxFechou;
		private ComboBox comboBoxUsuResp;
		private ComboBox comboBoxLocais;
		private Label label17;
		private TextBox textBoxPedidoInt;
		private Label label16;
		private Label label15;
		private Label label14;
		private ComboBox comboBoxAssistente;
		private Label label19;
		private ComboBox comboBoxInstDestino;
		private Label label18;
		private TextBox textBoxCodExterno;
		private Label label20;
		private Label label2;
		private Button button1;
		private Label label21;
		private ComboBox comboBoxDiagnostico;
		private Label label23;
		private TextBox textBoxProfissao;
		private ComboBox comboBoxEscolaridade;
		private Label label22;
		private Button buttonCadastrar;
		private DateTimePicker dateTimePickerCSN;
		private Label label25;
		private TextBox textBoxCSN;
		private Button button3;
		private Button button2;
		private TabPage Consulta;
		private Button button5;
		private Button button4;
		private Label label13;
		private Label label12;
		private DataGridView dataGridViewAtendimentos;
		private DataGridView dataGridViewPacientes;
	}
}
