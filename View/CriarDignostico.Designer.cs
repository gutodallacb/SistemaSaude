﻿namespace SistemaSaude.View
{
	partial class CriarDignostico
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox2 = new TextBox();
			button1 = new Button();
			label1 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// textBox2
			// 
			textBox2.Location = new Point(67, 11);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(322, 55);
			textBox2.TabIndex = 1;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(276, 72);
			button1.Name = "button1";
			button1.Size = new Size(113, 23);
			button1.TabIndex = 2;
			button1.Text = "Criar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(8, 15);
			label1.Name = "label1";
			label1.Size = new Size(61, 15);
			label1.TabIndex = 3;
			label1.Text = "Descrição:";
			// 
			// button2
			// 
			button2.Location = new Point(162, 72);
			button2.Name = "button2";
			button2.Size = new Size(108, 23);
			button2.TabIndex = 4;
			button2.Text = "Voltar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// CriarDignostico
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(397, 101);
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox2);
			MaximumSize = new Size(413, 140);
			MinimumSize = new Size(413, 140);
			Name = "CriarDignostico";
			Text = "Criar Dignóstico";
			Load += CriarDignostico_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox2;
		private Button button1;
		private Label label1;
		private Button button2;
	}
}