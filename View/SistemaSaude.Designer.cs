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
			label24 = new Label();
			comboBoxEspDiagnostico = new ComboBox();
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
			comboBox9 = new ComboBox();
			label18 = new Label();
			comboBox8 = new ComboBox();
			label17 = new Label();
			textBox1 = new TextBox();
			label16 = new Label();
			label15 = new Label();
			label14 = new Label();
			comboBox7 = new ComboBox();
			comboBox6 = new ComboBox();
			label13 = new Label();
			comboBox5 = new ComboBox();
			checkBox2 = new CheckBox();
			label12 = new Label();
			comboBox4 = new ComboBox();
			checkBox1 = new CheckBox();
			label11 = new Label();
			comboBox3 = new ComboBox();
			label10 = new Label();
			dateTimePicker2 = new DateTimePicker();
			label9 = new Label();
			comboBox2 = new ComboBox();
			label8 = new Label();
			comboBox1 = new ComboBox();
			label7 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label6 = new Label();
			comboBoxPaciente = new ComboBox();
			tabGeral.SuspendLayout();
			tabPage1.SuspendLayout();
			TabAtendimento.SuspendLayout();
			SuspendLayout();
			// 
			// tabGeral
			// 
			tabGeral.Controls.Add(tabPage1);
			tabGeral.Controls.Add(TabAtendimento);
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
			tabPage1.Controls.Add(label24);
			tabPage1.Controls.Add(comboBoxEspDiagnostico);
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
			buttonCadastrar.Location = new Point(293, 270);
			buttonCadastrar.Name = "buttonCadastrar";
			buttonCadastrar.Size = new Size(196, 32);
			buttonCadastrar.TabIndex = 30;
			buttonCadastrar.Text = "Cadastrar Paciente";
			buttonCadastrar.UseVisualStyleBackColor = true;
			buttonCadastrar.Click += button2_Click;
			// 
			// dateTimePickerCSN
			// 
			dateTimePickerCSN.Location = new Point(157, 242);
			dateTimePickerCSN.Name = "dateTimePickerCSN";
			dateTimePickerCSN.Size = new Size(331, 23);
			dateTimePickerCSN.TabIndex = 29;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Location = new Point(15, 246);
			label25.Name = "label25";
			label25.Size = new Size(33, 15);
			label25.TabIndex = 27;
			label25.Text = "CSN:";
			// 
			// textBoxCSN
			// 
			textBoxCSN.Location = new Point(54, 242);
			textBoxCSN.Name = "textBoxCSN";
			textBoxCSN.Size = new Size(97, 23);
			textBoxCSN.TabIndex = 26;
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Location = new Point(11, 212);
			label24.Name = "label24";
			label24.Size = new Size(163, 15);
			label24.TabIndex = 25;
			label24.Text = "Especificação de Diagnóstico:";
			// 
			// comboBoxEspDiagnostico
			// 
			comboBoxEspDiagnostico.FormattingEnabled = true;
			comboBoxEspDiagnostico.Location = new Point(180, 209);
			comboBoxEspDiagnostico.Name = "comboBoxEspDiagnostico";
			comboBoxEspDiagnostico.Size = new Size(308, 23);
			comboBoxEspDiagnostico.TabIndex = 24;
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
			buttonLimpar.Location = new Point(86, 271);
			buttonLimpar.Name = "buttonLimpar";
			buttonLimpar.Size = new Size(200, 32);
			buttonLimpar.TabIndex = 12;
			buttonLimpar.Text = "Limpar Campos";
			buttonLimpar.UseVisualStyleBackColor = true;
			buttonLimpar.Click += buttonCadastrar_Click;
			// 
			// checkBoxAtivo
			// 
			checkBoxAtivo.AutoSize = true;
			checkBoxAtivo.Location = new Point(59, 279);
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
			label5.Location = new Point(15, 278);
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
			TabAtendimento.Controls.Add(comboBox9);
			TabAtendimento.Controls.Add(label18);
			TabAtendimento.Controls.Add(comboBox8);
			TabAtendimento.Controls.Add(label17);
			TabAtendimento.Controls.Add(textBox1);
			TabAtendimento.Controls.Add(label16);
			TabAtendimento.Controls.Add(label15);
			TabAtendimento.Controls.Add(label14);
			TabAtendimento.Controls.Add(comboBox7);
			TabAtendimento.Controls.Add(comboBox6);
			TabAtendimento.Controls.Add(label13);
			TabAtendimento.Controls.Add(comboBox5);
			TabAtendimento.Controls.Add(checkBox2);
			TabAtendimento.Controls.Add(label12);
			TabAtendimento.Controls.Add(comboBox4);
			TabAtendimento.Controls.Add(checkBox1);
			TabAtendimento.Controls.Add(label11);
			TabAtendimento.Controls.Add(comboBox3);
			TabAtendimento.Controls.Add(label10);
			TabAtendimento.Controls.Add(dateTimePicker2);
			TabAtendimento.Controls.Add(label9);
			TabAtendimento.Controls.Add(comboBox2);
			TabAtendimento.Controls.Add(label8);
			TabAtendimento.Controls.Add(comboBox1);
			TabAtendimento.Controls.Add(label7);
			TabAtendimento.Controls.Add(dateTimePicker1);
			TabAtendimento.Controls.Add(label6);
			TabAtendimento.Controls.Add(comboBoxPaciente);
			TabAtendimento.Location = new Point(4, 24);
			TabAtendimento.Name = "TabAtendimento";
			TabAtendimento.Padding = new Padding(3);
			TabAtendimento.Size = new Size(498, 311);
			TabAtendimento.TabIndex = 1;
			TabAtendimento.Text = "Atendimento";
			TabAtendimento.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(11, 304);
			button3.Name = "button3";
			button3.Size = new Size(196, 32);
			button3.TabIndex = 32;
			button3.Text = "Limpar Campos";
			button3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(210, 304);
			button1.Name = "button1";
			button1.Size = new Size(196, 32);
			button1.TabIndex = 31;
			button1.Text = "Salavar Atendimento";
			button1.UseVisualStyleBackColor = true;
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
			// comboBox9
			// 
			comboBox9.FormattingEnabled = true;
			comboBox9.Location = new Point(129, 196);
			comboBox9.Name = "comboBox9";
			comboBox9.Size = new Size(275, 23);
			comboBox9.TabIndex = 29;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(236, 169);
			label18.Name = "label18";
			label18.Size = new Size(38, 15);
			label18.TabIndex = 28;
			label18.Text = "Local:";
			// 
			// comboBox8
			// 
			comboBox8.FormattingEnabled = true;
			comboBox8.Location = new Point(283, 166);
			comboBox8.Name = "comboBox8";
			comboBox8.Size = new Size(121, 23);
			comboBox8.TabIndex = 27;
			comboBox8.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(6, 169);
			label17.Name = "label17";
			label17.Size = new Size(122, 15);
			label17.TabIndex = 26;
			label17.Text = "Pedido de internação:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(129, 165);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(75, 23);
			textBox1.TabIndex = 25;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(307, 256);
			label16.Name = "label16";
			label16.Size = new Size(63, 15);
			label16.TabIndex = 24;
			label16.Text = "Assistente:";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(176, 256);
			label15.Name = "label15";
			label15.Size = new Size(49, 15);
			label15.TabIndex = 23;
			label15.Text = "Fechou:";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(32, 256);
			label14.Name = "label14";
			label14.Size = new Size(75, 15);
			label14.TabIndex = 22;
			label14.Text = "Responsável:";
			// 
			// comboBox7
			// 
			comboBox7.FormattingEnabled = true;
			comboBox7.Location = new Point(275, 274);
			comboBox7.Name = "comboBox7";
			comboBox7.Size = new Size(131, 23);
			comboBox7.TabIndex = 21;
			// 
			// comboBox6
			// 
			comboBox6.FormattingEnabled = true;
			comboBox6.Location = new Point(137, 274);
			comboBox6.Name = "comboBox6";
			comboBox6.Size = new Size(130, 23);
			comboBox6.TabIndex = 20;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(17, 234);
			label13.Name = "label13";
			label13.Size = new Size(55, 15);
			label13.TabIndex = 19;
			label13.Text = "Usuários:";
			// 
			// comboBox5
			// 
			comboBox5.FormattingEnabled = true;
			comboBox5.Location = new Point(10, 274);
			comboBox5.Name = "comboBox5";
			comboBox5.Size = new Size(119, 23);
			comboBox5.TabIndex = 18;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(210, 135);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(71, 19);
			checkBox2.TabIndex = 17;
			checkBox2.Text = "Fechado";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(6, 137);
			label12.Name = "label12";
			label12.Size = new Size(66, 15);
			label12.TabIndex = 16;
			label12.Text = "Conclusão:";
			// 
			// comboBox4
			// 
			comboBox4.FormattingEnabled = true;
			comboBox4.Location = new Point(73, 133);
			comboBox4.Name = "comboBox4";
			comboBox4.Size = new Size(131, 23);
			comboBox4.TabIndex = 15;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(325, 106);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(79, 19);
			checkBox1.TabIndex = 14;
			checkBox1.Text = "Finalizado";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(227, 50);
			label11.Name = "label11";
			label11.Size = new Size(40, 15);
			label11.TabIndex = 13;
			label11.Text = "Plano:";
			// 
			// comboBox3
			// 
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(267, 46);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(137, 23);
			comboBox3.TabIndex = 12;
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
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(73, 104);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(247, 23);
			dateTimePicker2.TabIndex = 10;
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
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(73, 46);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(131, 23);
			comboBox2.TabIndex = 8;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(231, 21);
			label8.Name = "label8";
			label8.Size = new Size(33, 15);
			label8.TabIndex = 7;
			label8.Text = "Tipo:";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(267, 17);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(137, 23);
			comboBox1.TabIndex = 6;
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
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(73, 75);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(247, 23);
			dateTimePicker1.TabIndex = 2;
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
			comboBoxPaciente.Size = new Size(131, 23);
			comboBoxPaciente.TabIndex = 0;
			// 
			// SistemaSaude
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(517, 350);
			Controls.Add(tabGeral);
			Name = "SistemaSaude";
			Text = "Sistema Saúde - Projeto Sofis";
			tabGeral.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			TabAtendimento.ResumeLayout(false);
			TabAtendimento.PerformLayout();
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
		private DateTimePicker dateTimePicker1;
		private ComboBox comboBox1;
		private Label label8;
		private Label label10;
		private DateTimePicker dateTimePicker2;
		private Label label9;
		private ComboBox comboBox2;
		private Label label12;
		private ComboBox comboBox4;
		private CheckBox checkBox1;
		private Label label11;
		private ComboBox comboBox3;
		private ComboBox comboBox6;
		private Label label13;
		private ComboBox comboBox5;
		private CheckBox checkBox2;
		private ComboBox comboBox8;
		private Label label17;
		private TextBox textBox1;
		private Label label16;
		private Label label15;
		private Label label14;
		private ComboBox comboBox7;
		private Label label19;
		private ComboBox comboBox9;
		private Label label18;
		private TextBox textBoxCodExterno;
		private Label label20;
		private Label label2;
		private Button button1;
		private Label label24;
		private ComboBox comboBoxEspDiagnostico;
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
	}
}
