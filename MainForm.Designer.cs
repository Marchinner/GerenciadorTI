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
			groupBox7 = new GroupBox();
			groupBox6 = new GroupBox();
			tabPageCredenciais = new TabPage();
			tabPage1 = new TabPage();
			buttonResetarConfig = new Button();
			buttonSalvarConfig = new Button();
			groupBox10 = new GroupBox();
			textBoxEmailEnvioCredenciais = new TextBox();
			label11 = new Label();
			groupBox9 = new GroupBox();
			textBoxEmailEnvioPatrimonio = new TextBox();
			label10 = new Label();
			textBoxEmailDestinoPatrimonio = new TextBox();
			label9 = new Label();
			groupBox8 = new GroupBox();
			checkBoxUsaSSLSmtp = new CheckBox();
			textBoxPortaSmtp = new TextBox();
			textBoxHostSmtp = new TextBox();
			label8 = new Label();
			label7 = new Label();
			tabControl.SuspendLayout();
			tabPageUsuarios.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			tabPageComputadores.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox4.SuspendLayout();
			tabPagePatrimonio.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox10.SuspendLayout();
			groupBox9.SuspendLayout();
			groupBox8.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(tabPageUsuarios);
			tabControl.Controls.Add(tabPageComputadores);
			tabControl.Controls.Add(tabPagePatrimonio);
			tabControl.Controls.Add(tabPageCredenciais);
			tabControl.Controls.Add(tabPage1);
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
			tabPagePatrimonio.Controls.Add(groupBox7);
			tabPagePatrimonio.Controls.Add(groupBox6);
			tabPagePatrimonio.Location = new Point(4, 24);
			tabPagePatrimonio.Name = "tabPagePatrimonio";
			tabPagePatrimonio.Padding = new Padding(3);
			tabPagePatrimonio.Size = new Size(498, 402);
			tabPagePatrimonio.TabIndex = 2;
			tabPagePatrimonio.Text = "Patrimônio";
			tabPagePatrimonio.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			groupBox7.Location = new Point(246, 3);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(249, 274);
			groupBox7.TabIndex = 1;
			groupBox7.TabStop = false;
			groupBox7.Text = "Criação de Patrimônio";
			// 
			// groupBox6
			// 
			groupBox6.Location = new Point(3, 3);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(237, 274);
			groupBox6.TabIndex = 0;
			groupBox6.TabStop = false;
			groupBox6.Text = "Movimentação de Patrimônio";
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
			// tabPage1
			// 
			tabPage1.Controls.Add(buttonResetarConfig);
			tabPage1.Controls.Add(buttonSalvarConfig);
			tabPage1.Controls.Add(groupBox10);
			tabPage1.Controls.Add(groupBox9);
			tabPage1.Controls.Add(groupBox8);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(498, 402);
			tabPage1.TabIndex = 4;
			tabPage1.Text = "Configurações";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonResetarConfig
			// 
			buttonResetarConfig.Location = new Point(298, 359);
			buttonResetarConfig.Name = "buttonResetarConfig";
			buttonResetarConfig.Size = new Size(75, 23);
			buttonResetarConfig.TabIndex = 4;
			buttonResetarConfig.Text = "Resetar";
			buttonResetarConfig.UseVisualStyleBackColor = true;
			buttonResetarConfig.Click += buttonResetarConfig_Click;
			// 
			// buttonSalvarConfig
			// 
			buttonSalvarConfig.Location = new Point(112, 359);
			buttonSalvarConfig.Name = "buttonSalvarConfig";
			buttonSalvarConfig.Size = new Size(75, 23);
			buttonSalvarConfig.TabIndex = 3;
			buttonSalvarConfig.Text = "Salvar";
			buttonSalvarConfig.UseVisualStyleBackColor = true;
			buttonSalvarConfig.Click += buttonSalvarConfig_Click;
			// 
			// groupBox10
			// 
			groupBox10.Controls.Add(textBoxEmailEnvioCredenciais);
			groupBox10.Controls.Add(label11);
			groupBox10.Location = new Point(3, 207);
			groupBox10.Name = "groupBox10";
			groupBox10.Size = new Size(492, 135);
			groupBox10.TabIndex = 2;
			groupBox10.TabStop = false;
			groupBox10.Text = "Envio de Credenciais";
			// 
			// textBoxEmailEnvioCredenciais
			// 
			textBoxEmailEnvioCredenciais.Location = new Point(96, 54);
			textBoxEmailEnvioCredenciais.Name = "textBoxEmailEnvioCredenciais";
			textBoxEmailEnvioCredenciais.Size = new Size(233, 23);
			textBoxEmailEnvioCredenciais.TabIndex = 5;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(17, 57);
			label11.Name = "label11";
			label11.Size = new Size(73, 15);
			label11.TabIndex = 4;
			label11.Text = "E-Mail Envio";
			// 
			// groupBox9
			// 
			groupBox9.Controls.Add(textBoxEmailEnvioPatrimonio);
			groupBox9.Controls.Add(label10);
			groupBox9.Controls.Add(textBoxEmailDestinoPatrimonio);
			groupBox9.Controls.Add(label9);
			groupBox9.Location = new Point(3, 60);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new Size(492, 141);
			groupBox9.TabIndex = 1;
			groupBox9.TabStop = false;
			groupBox9.Text = "Envio de Patrimônios";
			// 
			// textBoxEmailEnvioPatrimonio
			// 
			textBoxEmailEnvioPatrimonio.Location = new Point(96, 67);
			textBoxEmailEnvioPatrimonio.Name = "textBoxEmailEnvioPatrimonio";
			textBoxEmailEnvioPatrimonio.Size = new Size(233, 23);
			textBoxEmailEnvioPatrimonio.TabIndex = 3;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(17, 70);
			label10.Name = "label10";
			label10.Size = new Size(73, 15);
			label10.TabIndex = 2;
			label10.Text = "E-Mail Envio";
			// 
			// textBoxEmailDestinoPatrimonio
			// 
			textBoxEmailDestinoPatrimonio.Location = new Point(96, 25);
			textBoxEmailDestinoPatrimonio.Name = "textBoxEmailDestinoPatrimonio";
			textBoxEmailDestinoPatrimonio.Size = new Size(233, 23);
			textBoxEmailDestinoPatrimonio.TabIndex = 1;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(6, 28);
			label9.Name = "label9";
			label9.Size = new Size(84, 15);
			label9.TabIndex = 0;
			label9.Text = "E-Mail Destino";
			// 
			// groupBox8
			// 
			groupBox8.Controls.Add(checkBoxUsaSSLSmtp);
			groupBox8.Controls.Add(textBoxPortaSmtp);
			groupBox8.Controls.Add(textBoxHostSmtp);
			groupBox8.Controls.Add(label8);
			groupBox8.Controls.Add(label7);
			groupBox8.Location = new Point(3, 3);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new Size(492, 51);
			groupBox8.TabIndex = 0;
			groupBox8.TabStop = false;
			groupBox8.Text = "SMTP";
			// 
			// checkBoxUsaSSLSmtp
			// 
			checkBoxUsaSSLSmtp.AutoSize = true;
			checkBoxUsaSSLSmtp.Location = new Point(439, 18);
			checkBoxUsaSSLSmtp.Name = "checkBoxUsaSSLSmtp";
			checkBoxUsaSSLSmtp.Size = new Size(44, 19);
			checkBoxUsaSSLSmtp.TabIndex = 5;
			checkBoxUsaSSLSmtp.Text = "SSL";
			checkBoxUsaSSLSmtp.UseVisualStyleBackColor = true;
			// 
			// textBoxPortaSmtp
			// 
			textBoxPortaSmtp.Location = new Point(376, 16);
			textBoxPortaSmtp.Name = "textBoxPortaSmtp";
			textBoxPortaSmtp.Size = new Size(37, 23);
			textBoxPortaSmtp.TabIndex = 3;
			// 
			// textBoxHostSmtp
			// 
			textBoxHostSmtp.Location = new Point(44, 16);
			textBoxHostSmtp.Name = "textBoxHostSmtp";
			textBoxHostSmtp.Size = new Size(285, 23);
			textBoxHostSmtp.TabIndex = 2;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(335, 19);
			label8.Name = "label8";
			label8.Size = new Size(35, 15);
			label8.TabIndex = 1;
			label8.Text = "Porta";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 19);
			label7.Name = "label7";
			label7.Size = new Size(32, 15);
			label7.TabIndex = 0;
			label7.Text = "Host";
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
			tabPagePatrimonio.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			groupBox10.ResumeLayout(false);
			groupBox10.PerformLayout();
			groupBox9.ResumeLayout(false);
			groupBox9.PerformLayout();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
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
		private GroupBox groupBox7;
		private GroupBox groupBox6;
		private TabPage tabPage1;
		private GroupBox groupBox8;
		private TextBox textBoxPortaSmtp;
		private TextBox textBoxHostSmtp;
		private Label label8;
		private Label label7;
		private CheckBox checkBoxUsaSSLSmtp;
		private GroupBox groupBox10;
		private GroupBox groupBox9;
		private Label label9;
		private Button buttonResetarConfig;
		private Button buttonSalvarConfig;
		private TextBox textBoxEmailEnvioCredenciais;
		private Label label11;
		private TextBox textBoxEmailEnvioPatrimonio;
		private Label label10;
		private TextBox textBoxEmailDestinoPatrimonio;
	}
}
