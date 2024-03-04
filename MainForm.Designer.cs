namespace GerenciadorTI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			tabControl = new TabControl();
			tabPageUsuarios = new TabPage();
			groupBox3 = new GroupBox();
			textBoxMaquinaLiberada = new TextBox();
			listBoxMaquinaLiberada = new ListBox();
			buttonRemoverMaquinaLiberada = new Button();
			buttonAdicionarMaquinaLiberada = new Button();
			buttonTransferirUsuario = new Button();
			comboBoxUnidadeOrganizacional = new ComboBox();
			label5 = new Label();
			label4 = new Label();
			buttonAlterarEmailUsuario = new Button();
			textBoxEmailUsuario = new TextBox();
			label3 = new Label();
			labelNomeUsuario = new Label();
			label2 = new Label();
			groupBox2 = new GroupBox();
			buttonToggleStatusUsuario = new Button();
			labelStatusUsuario = new Label();
			groupBox1 = new GroupBox();
			buttonBuscarUsuario = new Button();
			textBoxUser = new TextBox();
			label1 = new Label();
			tabPageComputadores = new TabPage();
			groupBox5 = new GroupBox();
			buttonToggleStatusNetbios = new Button();
			labelStatusNetbios = new Label();
			groupBox4 = new GroupBox();
			buttonBuscarNetbios = new Button();
			textBoxNetbios = new TextBox();
			label6 = new Label();
			tabPagePatrimonio = new TabPage();
			tabPageCredenciais = new TabPage();
			tabControl.SuspendLayout();
			tabPageUsuarios.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			tabPageComputadores.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(tabPageUsuarios);
			tabControl.Controls.Add(tabPageComputadores);
			tabControl.Controls.Add(tabPagePatrimonio);
			tabControl.Controls.Add(tabPageCredenciais);
			tabControl.Location = new Point(0, 4);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(506, 430);
			tabControl.TabIndex = 0;
			// 
			// tabPageUsuarios
			// 
			tabPageUsuarios.Controls.Add(groupBox3);
			tabPageUsuarios.Controls.Add(groupBox2);
			tabPageUsuarios.Controls.Add(groupBox1);
			tabPageUsuarios.Location = new Point(4, 24);
			tabPageUsuarios.Name = "tabPageUsuarios";
			tabPageUsuarios.Padding = new Padding(3);
			tabPageUsuarios.Size = new Size(498, 402);
			tabPageUsuarios.TabIndex = 0;
			tabPageUsuarios.Text = "Usuários";
			tabPageUsuarios.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(textBoxMaquinaLiberada);
			groupBox3.Controls.Add(listBoxMaquinaLiberada);
			groupBox3.Controls.Add(buttonRemoverMaquinaLiberada);
			groupBox3.Controls.Add(buttonAdicionarMaquinaLiberada);
			groupBox3.Controls.Add(buttonTransferirUsuario);
			groupBox3.Controls.Add(comboBoxUnidadeOrganizacional);
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(buttonAlterarEmailUsuario);
			groupBox3.Controls.Add(textBoxEmailUsuario);
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(labelNomeUsuario);
			groupBox3.Controls.Add(label2);
			groupBox3.Location = new Point(3, 81);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(490, 318);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Informações do Usuário";
			// 
			// textBoxMaquinaLiberada
			// 
			textBoxMaquinaLiberada.Location = new Point(131, 86);
			textBoxMaquinaLiberada.Name = "textBoxMaquinaLiberada";
			textBoxMaquinaLiberada.Size = new Size(153, 23);
			textBoxMaquinaLiberada.TabIndex = 6;
			textBoxMaquinaLiberada.TextChanged += textBoxMaquinaLiberada_TextChanged;
			// 
			// listBoxMaquinaLiberada
			// 
			listBoxMaquinaLiberada.FormattingEnabled = true;
			listBoxMaquinaLiberada.ItemHeight = 15;
			listBoxMaquinaLiberada.Location = new Point(131, 115);
			listBoxMaquinaLiberada.Name = "listBoxMaquinaLiberada";
			listBoxMaquinaLiberada.Size = new Size(153, 94);
			listBoxMaquinaLiberada.TabIndex = 8;
			listBoxMaquinaLiberada.SelectedIndexChanged += listBoxMaquinaLiberada_SelectedIndexChanged;
			// 
			// buttonRemoverMaquinaLiberada
			// 
			buttonRemoverMaquinaLiberada.Enabled = false;
			buttonRemoverMaquinaLiberada.Location = new Point(290, 114);
			buttonRemoverMaquinaLiberada.Name = "buttonRemoverMaquinaLiberada";
			buttonRemoverMaquinaLiberada.Size = new Size(75, 23);
			buttonRemoverMaquinaLiberada.TabIndex = 9;
			buttonRemoverMaquinaLiberada.Text = "Remover";
			buttonRemoverMaquinaLiberada.UseVisualStyleBackColor = true;
			buttonRemoverMaquinaLiberada.Click += buttonRemoverMaquinaLiberada_Click;
			// 
			// buttonAdicionarMaquinaLiberada
			// 
			buttonAdicionarMaquinaLiberada.Enabled = false;
			buttonAdicionarMaquinaLiberada.Location = new Point(290, 85);
			buttonAdicionarMaquinaLiberada.Name = "buttonAdicionarMaquinaLiberada";
			buttonAdicionarMaquinaLiberada.Size = new Size(75, 23);
			buttonAdicionarMaquinaLiberada.TabIndex = 7;
			buttonAdicionarMaquinaLiberada.Text = "Adicionar";
			buttonAdicionarMaquinaLiberada.UseVisualStyleBackColor = true;
			buttonAdicionarMaquinaLiberada.Click += buttonAdicionarMaquinaLiberada_Click;
			// 
			// buttonTransferirUsuario
			// 
			buttonTransferirUsuario.Enabled = false;
			buttonTransferirUsuario.Location = new Point(224, 285);
			buttonTransferirUsuario.Name = "buttonTransferirUsuario";
			buttonTransferirUsuario.Size = new Size(75, 23);
			buttonTransferirUsuario.TabIndex = 11;
			buttonTransferirUsuario.Text = "Transferir";
			buttonTransferirUsuario.UseVisualStyleBackColor = true;
			buttonTransferirUsuario.Click += buttonTransferirUsuario_Click;
			// 
			// comboBoxUnidadeOrganizacional
			// 
			comboBoxUnidadeOrganizacional.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxUnidadeOrganizacional.Enabled = false;
			comboBoxUnidadeOrganizacional.FormattingEnabled = true;
			comboBoxUnidadeOrganizacional.Location = new Point(162, 256);
			comboBoxUnidadeOrganizacional.Name = "comboBoxUnidadeOrganizacional";
			comboBoxUnidadeOrganizacional.Size = new Size(202, 23);
			comboBoxUnidadeOrganizacional.TabIndex = 10;
			comboBoxUnidadeOrganizacional.SelectedIndexChanged += comboBoxUnidadeOrganizacional_SelectedIndexChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(21, 259);
			label5.Name = "label5";
			label5.Size = new Size(136, 15);
			label5.TabIndex = 8;
			label5.Text = "Unidade Organizacional:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(20, 89);
			label4.Name = "label4";
			label4.Size = new Size(105, 15);
			label4.TabIndex = 5;
			label4.Text = "Máquina Liberada:";
			// 
			// buttonAlterarEmailUsuario
			// 
			buttonAlterarEmailUsuario.Enabled = false;
			buttonAlterarEmailUsuario.Location = new Point(290, 54);
			buttonAlterarEmailUsuario.Name = "buttonAlterarEmailUsuario";
			buttonAlterarEmailUsuario.Size = new Size(75, 23);
			buttonAlterarEmailUsuario.TabIndex = 5;
			buttonAlterarEmailUsuario.Text = "Alterar";
			buttonAlterarEmailUsuario.UseVisualStyleBackColor = true;
			buttonAlterarEmailUsuario.Click += buttonAlterarEmailUsuario_Click;
			// 
			// textBoxEmailUsuario
			// 
			textBoxEmailUsuario.Enabled = false;
			textBoxEmailUsuario.Location = new Point(70, 54);
			textBoxEmailUsuario.Name = "textBoxEmailUsuario";
			textBoxEmailUsuario.Size = new Size(214, 23);
			textBoxEmailUsuario.TabIndex = 4;
			textBoxEmailUsuario.TextChanged += textBoxEmailUsuario_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(20, 57);
			label3.Name = "label3";
			label3.Size = new Size(44, 15);
			label3.TabIndex = 2;
			label3.Text = "E-mail:";
			// 
			// labelNomeUsuario
			// 
			labelNomeUsuario.AutoSize = true;
			labelNomeUsuario.Location = new Point(70, 29);
			labelNomeUsuario.Name = "labelNomeUsuario";
			labelNomeUsuario.Size = new Size(0, 15);
			labelNomeUsuario.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 29);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 0;
			label2.Text = "Nome:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(buttonToggleStatusUsuario);
			groupBox2.Controls.Add(labelStatusUsuario);
			groupBox2.Location = new Point(293, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(200, 72);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Status";
			// 
			// buttonToggleStatusUsuario
			// 
			buttonToggleStatusUsuario.Enabled = false;
			buttonToggleStatusUsuario.Location = new Point(49, 37);
			buttonToggleStatusUsuario.Name = "buttonToggleStatusUsuario";
			buttonToggleStatusUsuario.Size = new Size(100, 23);
			buttonToggleStatusUsuario.TabIndex = 3;
			buttonToggleStatusUsuario.Text = "Desativar/Ativar";
			buttonToggleStatusUsuario.UseVisualStyleBackColor = true;
			buttonToggleStatusUsuario.Click += buttonToggleStatusUsuario_Click;
			// 
			// labelStatusUsuario
			// 
			labelStatusUsuario.AutoSize = true;
			labelStatusUsuario.Location = new Point(50, 19);
			labelStatusUsuario.Name = "labelStatusUsuario";
			labelStatusUsuario.Size = new Size(99, 15);
			labelStatusUsuario.TabIndex = 0;
			labelStatusUsuario.Text = "Status do Usuário";
			labelStatusUsuario.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(buttonBuscarUsuario);
			groupBox1.Controls.Add(textBoxUser);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(284, 72);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Buscar Usuário";
			// 
			// buttonBuscarUsuario
			// 
			buttonBuscarUsuario.Enabled = false;
			buttonBuscarUsuario.Location = new Point(197, 26);
			buttonBuscarUsuario.Name = "buttonBuscarUsuario";
			buttonBuscarUsuario.Size = new Size(75, 23);
			buttonBuscarUsuario.TabIndex = 1;
			buttonBuscarUsuario.Text = "Buscar";
			buttonBuscarUsuario.UseVisualStyleBackColor = true;
			buttonBuscarUsuario.Click += buttonBuscarUsuario_Click;
			// 
			// textBoxUser
			// 
			textBoxUser.Location = new Point(65, 27);
			textBoxUser.Name = "textBoxUser";
			textBoxUser.Size = new Size(126, 23);
			textBoxUser.TabIndex = 0;
			textBoxUser.TextChanged += textBoxUser_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(9, 30);
			label1.Name = "label1";
			label1.Size = new Size(50, 15);
			label1.TabIndex = 0;
			label1.Text = "Usuário:";
			// 
			// tabPageComputadores
			// 
			tabPageComputadores.Controls.Add(groupBox5);
			tabPageComputadores.Controls.Add(groupBox4);
			tabPageComputadores.Location = new Point(4, 24);
			tabPageComputadores.Name = "tabPageComputadores";
			tabPageComputadores.Padding = new Padding(3);
			tabPageComputadores.Size = new Size(498, 402);
			tabPageComputadores.TabIndex = 1;
			tabPageComputadores.Text = "Computadores";
			tabPageComputadores.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(buttonToggleStatusNetbios);
			groupBox5.Controls.Add(labelStatusNetbios);
			groupBox5.Location = new Point(293, 3);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(200, 72);
			groupBox5.TabIndex = 2;
			groupBox5.TabStop = false;
			groupBox5.Text = "Status";
			// 
			// buttonToggleStatusNetbios
			// 
			buttonToggleStatusNetbios.Enabled = false;
			buttonToggleStatusNetbios.Location = new Point(49, 37);
			buttonToggleStatusNetbios.Name = "buttonToggleStatusNetbios";
			buttonToggleStatusNetbios.Size = new Size(100, 23);
			buttonToggleStatusNetbios.TabIndex = 3;
			buttonToggleStatusNetbios.Text = "Desativar/Ativar";
			buttonToggleStatusNetbios.UseVisualStyleBackColor = true;
			buttonToggleStatusNetbios.Click += buttonToggleStatusNetbios_Click;
			// 
			// labelStatusNetbios
			// 
			labelStatusNetbios.AutoSize = true;
			labelStatusNetbios.Location = new Point(50, 19);
			labelStatusNetbios.Name = "labelStatusNetbios";
			labelStatusNetbios.Size = new Size(127, 15);
			labelStatusNetbios.TabIndex = 0;
			labelStatusNetbios.Text = "Status do Computador";
			labelStatusNetbios.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(buttonBuscarNetbios);
			groupBox4.Controls.Add(textBoxNetbios);
			groupBox4.Controls.Add(label6);
			groupBox4.Location = new Point(3, 3);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(284, 72);
			groupBox4.TabIndex = 1;
			groupBox4.TabStop = false;
			groupBox4.Text = "Buscar Computador";
			// 
			// buttonBuscarNetbios
			// 
			buttonBuscarNetbios.Enabled = false;
			buttonBuscarNetbios.Location = new Point(197, 26);
			buttonBuscarNetbios.Name = "buttonBuscarNetbios";
			buttonBuscarNetbios.Size = new Size(75, 23);
			buttonBuscarNetbios.TabIndex = 1;
			buttonBuscarNetbios.Text = "Buscar";
			buttonBuscarNetbios.UseVisualStyleBackColor = true;
			buttonBuscarNetbios.Click += buttonBuscarNetbios_Click;
			// 
			// textBoxNetbios
			// 
			textBoxNetbios.Location = new Point(65, 27);
			textBoxNetbios.Name = "textBoxNetbios";
			textBoxNetbios.Size = new Size(126, 23);
			textBoxNetbios.TabIndex = 0;
			textBoxNetbios.TextChanged += textBoxNetbios_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(9, 30);
			label6.Name = "label6";
			label6.Size = new Size(51, 15);
			label6.TabIndex = 0;
			label6.Text = "Netbios:";
			// 
			// tabPagePatrimonio
			// 
			tabPagePatrimonio.Location = new Point(4, 24);
			tabPagePatrimonio.Name = "tabPagePatrimonio";
			tabPagePatrimonio.Padding = new Padding(3);
			tabPagePatrimonio.Size = new Size(498, 402);
			tabPagePatrimonio.TabIndex = 2;
			tabPagePatrimonio.Text = "Patrimônio";
			tabPagePatrimonio.UseVisualStyleBackColor = true;
			// 
			// tabPageCredenciais
			// 
			tabPageCredenciais.Location = new Point(4, 24);
			tabPageCredenciais.Name = "tabPageCredenciais";
			tabPageCredenciais.Padding = new Padding(3);
			tabPageCredenciais.Size = new Size(498, 402);
			tabPageCredenciais.TabIndex = 3;
			tabPageCredenciais.Text = "Credenciais";
			tabPageCredenciais.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(502, 434);
			Controls.Add(tabControl);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Gerenciador T.I";
			tabControl.ResumeLayout(false);
			tabPageUsuarios.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			tabPageComputadores.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl;
		private TabPage tabPageUsuarios;
		private TabPage tabPageComputadores;
		private GroupBox groupBox1;
		private TabPage tabPagePatrimonio;
		private TabPage tabPageCredenciais;
		private GroupBox groupBox2;
		private Button buttonBuscarUsuario;
		private TextBox textBoxUser;
		private Label label1;
		private Button buttonToggleStatusUsuario;
		private Label labelStatusUsuario;
		private GroupBox groupBox3;
		private Label label3;
		private Label labelNomeUsuario;
		private Label label2;
		private TextBox textBoxEmailUsuario;
		private Label label4;
		private Button buttonAlterarEmailUsuario;
		private Button buttonTransferirUsuario;
		private ComboBox comboBoxUnidadeOrganizacional;
		private Label label5;
		private GroupBox groupBox4;
		private Button buttonBuscarNetbios;
		private TextBox textBoxNetbios;
		private Label label6;
		private GroupBox groupBox5;
		private Button buttonToggleStatusNetbios;
		private Label labelStatusNetbios;
		private Button buttonRemoverMaquinaLiberada;
		private Button buttonAdicionarMaquinaLiberada;
		private ListBox listBoxMaquinaLiberada;
		private TextBox textBoxMaquinaLiberada;
	}
}
