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
			buttonEnviarPatrimonio = new Button();
			radioButtonCriacaoPatrimonio = new RadioButton();
			radioButtonMovimentacaoPatrimonio = new RadioButton();
			groupBoxCriarPatrimonio = new GroupBox();
			buttonAnexarTraseira = new Button();
			buttonAnexarFrontal = new Button();
			buttonAnexarPlaqueta = new Button();
			checkBoxTraseira = new CheckBox();
			checkBoxFrontal = new CheckBox();
			checkBoxPlaqueta = new CheckBox();
			label19 = new Label();
			textBoxDescricaoCPatrimonio = new TextBox();
			textBoxNumeroCPatrimonio = new TextBox();
			textBoxLocalCPatrimonio = new TextBox();
			label18 = new Label();
			label17 = new Label();
			label16 = new Label();
			groupBoxMovimentarPatrimonio = new GroupBox();
			textBoxDescricaoMPatrimonio = new TextBox();
			textBoxLocalNovoMPatrimonio = new TextBox();
			textBoxLocalAtualMPatrimonio = new TextBox();
			textBoxNumeroMPatrimonio = new TextBox();
			label15 = new Label();
			label14 = new Label();
			label13 = new Label();
			label12 = new Label();
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
			groupBoxCriarPatrimonio.SuspendLayout();
			groupBoxMovimentarPatrimonio.SuspendLayout();
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
			tabControl.Size = new Size(506, 370);
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
			tabPageUsuarios.Size = new Size(498, 342);
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
			groupBox3.Size = new Size(490, 256);
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
			buttonTransferirUsuario.Location = new Point(364, 218);
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
			comboBoxUnidadeOrganizacional.Location = new Point(145, 219);
			comboBoxUnidadeOrganizacional.Name = "comboBoxUnidadeOrganizacional";
			comboBoxUnidadeOrganizacional.Size = new Size(202, 23);
			comboBoxUnidadeOrganizacional.TabIndex = 10;
			comboBoxUnidadeOrganizacional.SelectedIndexChanged += comboBoxUnidadeOrganizacional_SelectedIndexChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 222);
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
			tabPageComputadores.Size = new Size(498, 342);
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
			tabPagePatrimonio.Controls.Add(buttonEnviarPatrimonio);
			tabPagePatrimonio.Controls.Add(radioButtonCriacaoPatrimonio);
			tabPagePatrimonio.Controls.Add(radioButtonMovimentacaoPatrimonio);
			tabPagePatrimonio.Controls.Add(groupBoxCriarPatrimonio);
			tabPagePatrimonio.Controls.Add(groupBoxMovimentarPatrimonio);
			tabPagePatrimonio.Location = new Point(4, 24);
			tabPagePatrimonio.Name = "tabPagePatrimonio";
			tabPagePatrimonio.Padding = new Padding(3);
			tabPagePatrimonio.Size = new Size(498, 342);
			tabPagePatrimonio.TabIndex = 2;
			tabPagePatrimonio.Text = "Patrimônio";
			tabPagePatrimonio.UseVisualStyleBackColor = true;
			// 
			// buttonEnviarPatrimonio
			// 
			buttonEnviarPatrimonio.Location = new Point(205, 270);
			buttonEnviarPatrimonio.Name = "buttonEnviarPatrimonio";
			buttonEnviarPatrimonio.Size = new Size(75, 23);
			buttonEnviarPatrimonio.TabIndex = 4;
			buttonEnviarPatrimonio.Text = "Enviar";
			buttonEnviarPatrimonio.UseVisualStyleBackColor = true;
			buttonEnviarPatrimonio.Click += buttonEnviarPatrimonio_Click;
			// 
			// radioButtonCriacaoPatrimonio
			// 
			radioButtonCriacaoPatrimonio.AutoSize = true;
			radioButtonCriacaoPatrimonio.Location = new Point(262, 6);
			radioButtonCriacaoPatrimonio.Name = "radioButtonCriacaoPatrimonio";
			radioButtonCriacaoPatrimonio.Size = new Size(65, 19);
			radioButtonCriacaoPatrimonio.TabIndex = 3;
			radioButtonCriacaoPatrimonio.Text = "Criação";
			radioButtonCriacaoPatrimonio.UseVisualStyleBackColor = true;
			radioButtonCriacaoPatrimonio.CheckedChanged += radioButtonCriacaoPatrimonio_CheckedChanged;
			// 
			// radioButtonMovimentacaoPatrimonio
			// 
			radioButtonMovimentacaoPatrimonio.AutoSize = true;
			radioButtonMovimentacaoPatrimonio.Checked = true;
			radioButtonMovimentacaoPatrimonio.Location = new Point(151, 6);
			radioButtonMovimentacaoPatrimonio.Name = "radioButtonMovimentacaoPatrimonio";
			radioButtonMovimentacaoPatrimonio.Size = new Size(105, 19);
			radioButtonMovimentacaoPatrimonio.TabIndex = 2;
			radioButtonMovimentacaoPatrimonio.TabStop = true;
			radioButtonMovimentacaoPatrimonio.Text = "Movimentação";
			radioButtonMovimentacaoPatrimonio.UseVisualStyleBackColor = true;
			radioButtonMovimentacaoPatrimonio.CheckedChanged += radioButtonMovimentacaoPatrimonio_CheckedChanged;
			// 
			// groupBoxCriarPatrimonio
			// 
			groupBoxCriarPatrimonio.Controls.Add(buttonAnexarTraseira);
			groupBoxCriarPatrimonio.Controls.Add(buttonAnexarFrontal);
			groupBoxCriarPatrimonio.Controls.Add(buttonAnexarPlaqueta);
			groupBoxCriarPatrimonio.Controls.Add(checkBoxTraseira);
			groupBoxCriarPatrimonio.Controls.Add(checkBoxFrontal);
			groupBoxCriarPatrimonio.Controls.Add(checkBoxPlaqueta);
			groupBoxCriarPatrimonio.Controls.Add(label19);
			groupBoxCriarPatrimonio.Controls.Add(textBoxDescricaoCPatrimonio);
			groupBoxCriarPatrimonio.Controls.Add(textBoxNumeroCPatrimonio);
			groupBoxCriarPatrimonio.Controls.Add(textBoxLocalCPatrimonio);
			groupBoxCriarPatrimonio.Controls.Add(label18);
			groupBoxCriarPatrimonio.Controls.Add(label17);
			groupBoxCriarPatrimonio.Controls.Add(label16);
			groupBoxCriarPatrimonio.Enabled = false;
			groupBoxCriarPatrimonio.Location = new Point(246, 31);
			groupBoxCriarPatrimonio.Name = "groupBoxCriarPatrimonio";
			groupBoxCriarPatrimonio.Size = new Size(249, 233);
			groupBoxCriarPatrimonio.TabIndex = 1;
			groupBoxCriarPatrimonio.TabStop = false;
			groupBoxCriarPatrimonio.Text = "Criação de Patrimônio";
			// 
			// buttonAnexarTraseira
			// 
			buttonAnexarTraseira.Location = new Point(159, 199);
			buttonAnexarTraseira.Name = "buttonAnexarTraseira";
			buttonAnexarTraseira.Size = new Size(53, 23);
			buttonAnexarTraseira.TabIndex = 20;
			buttonAnexarTraseira.Text = "Anexar";
			buttonAnexarTraseira.UseVisualStyleBackColor = true;
			buttonAnexarTraseira.Click += buttonAnexarTraseira_Click;
			// 
			// buttonAnexarFrontal
			// 
			buttonAnexarFrontal.Location = new Point(159, 174);
			buttonAnexarFrontal.Name = "buttonAnexarFrontal";
			buttonAnexarFrontal.Size = new Size(53, 23);
			buttonAnexarFrontal.TabIndex = 19;
			buttonAnexarFrontal.Text = "Anexar";
			buttonAnexarFrontal.UseVisualStyleBackColor = true;
			buttonAnexarFrontal.Click += buttonAnexarFrontal_Click;
			// 
			// buttonAnexarPlaqueta
			// 
			buttonAnexarPlaqueta.Location = new Point(159, 149);
			buttonAnexarPlaqueta.Name = "buttonAnexarPlaqueta";
			buttonAnexarPlaqueta.Size = new Size(53, 23);
			buttonAnexarPlaqueta.TabIndex = 18;
			buttonAnexarPlaqueta.Text = "Anexar";
			buttonAnexarPlaqueta.UseVisualStyleBackColor = true;
			buttonAnexarPlaqueta.Click += buttonAnexarPlaqueta_Click;
			// 
			// checkBoxTraseira
			// 
			checkBoxTraseira.AutoCheck = false;
			checkBoxTraseira.AutoSize = true;
			checkBoxTraseira.Location = new Point(81, 202);
			checkBoxTraseira.Name = "checkBoxTraseira";
			checkBoxTraseira.Size = new Size(65, 19);
			checkBoxTraseira.TabIndex = 17;
			checkBoxTraseira.Text = "Traseira";
			checkBoxTraseira.UseVisualStyleBackColor = true;
			// 
			// checkBoxFrontal
			// 
			checkBoxFrontal.AutoCheck = false;
			checkBoxFrontal.AutoSize = true;
			checkBoxFrontal.Location = new Point(81, 177);
			checkBoxFrontal.Name = "checkBoxFrontal";
			checkBoxFrontal.Size = new Size(63, 19);
			checkBoxFrontal.TabIndex = 16;
			checkBoxFrontal.Text = "Frontal";
			checkBoxFrontal.UseVisualStyleBackColor = true;
			// 
			// checkBoxPlaqueta
			// 
			checkBoxPlaqueta.AutoCheck = false;
			checkBoxPlaqueta.AutoSize = true;
			checkBoxPlaqueta.Location = new Point(81, 152);
			checkBoxPlaqueta.Name = "checkBoxPlaqueta";
			checkBoxPlaqueta.Size = new Size(72, 19);
			checkBoxPlaqueta.TabIndex = 15;
			checkBoxPlaqueta.Text = "Plaqueta";
			checkBoxPlaqueta.UseVisualStyleBackColor = true;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(39, 152);
			label19.Name = "label19";
			label19.Size = new Size(36, 15);
			label19.TabIndex = 14;
			label19.Text = "Fotos";
			// 
			// textBoxDescricaoCPatrimonio
			// 
			textBoxDescricaoCPatrimonio.Location = new Point(85, 108);
			textBoxDescricaoCPatrimonio.Name = "textBoxDescricaoCPatrimonio";
			textBoxDescricaoCPatrimonio.Size = new Size(151, 23);
			textBoxDescricaoCPatrimonio.TabIndex = 13;
			// 
			// textBoxNumeroCPatrimonio
			// 
			textBoxNumeroCPatrimonio.Location = new Point(85, 32);
			textBoxNumeroCPatrimonio.Name = "textBoxNumeroCPatrimonio";
			textBoxNumeroCPatrimonio.Size = new Size(100, 23);
			textBoxNumeroCPatrimonio.TabIndex = 11;
			// 
			// textBoxLocalCPatrimonio
			// 
			textBoxLocalCPatrimonio.Location = new Point(85, 70);
			textBoxLocalCPatrimonio.Name = "textBoxLocalCPatrimonio";
			textBoxLocalCPatrimonio.Size = new Size(151, 23);
			textBoxLocalCPatrimonio.TabIndex = 12;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(58, 35);
			label18.Name = "label18";
			label18.Size = new Size(21, 15);
			label18.TabIndex = 8;
			label18.Text = "N°";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(39, 73);
			label17.Name = "label17";
			label17.Size = new Size(35, 15);
			label17.TabIndex = 9;
			label17.Text = "Local";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(16, 111);
			label16.Name = "label16";
			label16.Size = new Size(58, 15);
			label16.TabIndex = 10;
			label16.Text = "Descrição";
			// 
			// groupBoxMovimentarPatrimonio
			// 
			groupBoxMovimentarPatrimonio.Controls.Add(textBoxDescricaoMPatrimonio);
			groupBoxMovimentarPatrimonio.Controls.Add(textBoxLocalNovoMPatrimonio);
			groupBoxMovimentarPatrimonio.Controls.Add(textBoxLocalAtualMPatrimonio);
			groupBoxMovimentarPatrimonio.Controls.Add(textBoxNumeroMPatrimonio);
			groupBoxMovimentarPatrimonio.Controls.Add(label15);
			groupBoxMovimentarPatrimonio.Controls.Add(label14);
			groupBoxMovimentarPatrimonio.Controls.Add(label13);
			groupBoxMovimentarPatrimonio.Controls.Add(label12);
			groupBoxMovimentarPatrimonio.Location = new Point(3, 31);
			groupBoxMovimentarPatrimonio.Name = "groupBoxMovimentarPatrimonio";
			groupBoxMovimentarPatrimonio.Size = new Size(237, 233);
			groupBoxMovimentarPatrimonio.TabIndex = 0;
			groupBoxMovimentarPatrimonio.TabStop = false;
			groupBoxMovimentarPatrimonio.Text = "Movimentação de Patrimônio";
			// 
			// textBoxDescricaoMPatrimonio
			// 
			textBoxDescricaoMPatrimonio.Location = new Point(72, 146);
			textBoxDescricaoMPatrimonio.Name = "textBoxDescricaoMPatrimonio";
			textBoxDescricaoMPatrimonio.Size = new Size(151, 23);
			textBoxDescricaoMPatrimonio.TabIndex = 7;
			// 
			// textBoxLocalNovoMPatrimonio
			// 
			textBoxLocalNovoMPatrimonio.Location = new Point(72, 108);
			textBoxLocalNovoMPatrimonio.Name = "textBoxLocalNovoMPatrimonio";
			textBoxLocalNovoMPatrimonio.Size = new Size(151, 23);
			textBoxLocalNovoMPatrimonio.TabIndex = 6;
			// 
			// textBoxLocalAtualMPatrimonio
			// 
			textBoxLocalAtualMPatrimonio.Location = new Point(72, 70);
			textBoxLocalAtualMPatrimonio.Name = "textBoxLocalAtualMPatrimonio";
			textBoxLocalAtualMPatrimonio.Size = new Size(151, 23);
			textBoxLocalAtualMPatrimonio.TabIndex = 5;
			// 
			// textBoxNumeroMPatrimonio
			// 
			textBoxNumeroMPatrimonio.Location = new Point(72, 32);
			textBoxNumeroMPatrimonio.Name = "textBoxNumeroMPatrimonio";
			textBoxNumeroMPatrimonio.Size = new Size(100, 23);
			textBoxNumeroMPatrimonio.TabIndex = 4;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(8, 149);
			label15.Name = "label15";
			label15.Size = new Size(58, 15);
			label15.TabIndex = 3;
			label15.Text = "Descrição";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(-1, 111);
			label14.Name = "label14";
			label14.Size = new Size(67, 15);
			label14.TabIndex = 2;
			label14.Text = "Local Novo";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(0, 73);
			label13.Name = "label13";
			label13.Size = new Size(66, 15);
			label13.TabIndex = 1;
			label13.Text = "Local Atual";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(45, 35);
			label12.Name = "label12";
			label12.Size = new Size(21, 15);
			label12.TabIndex = 0;
			label12.Text = "N°";
			// 
			// tabPageCredenciais
			// 
			tabPageCredenciais.Location = new Point(4, 24);
			tabPageCredenciais.Name = "tabPageCredenciais";
			tabPageCredenciais.Padding = new Padding(3);
			tabPageCredenciais.Size = new Size(498, 342);
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
			tabPage1.Size = new Size(498, 342);
			tabPage1.TabIndex = 4;
			tabPage1.Text = "Configurações";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonResetarConfig
			// 
			buttonResetarConfig.Location = new Point(298, 234);
			buttonResetarConfig.Name = "buttonResetarConfig";
			buttonResetarConfig.Size = new Size(75, 23);
			buttonResetarConfig.TabIndex = 4;
			buttonResetarConfig.Text = "Resetar";
			buttonResetarConfig.UseVisualStyleBackColor = true;
			buttonResetarConfig.Click += buttonResetarConfig_Click;
			// 
			// buttonSalvarConfig
			// 
			buttonSalvarConfig.Location = new Point(99, 234);
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
			groupBox10.Location = new Point(3, 169);
			groupBox10.Name = "groupBox10";
			groupBox10.Size = new Size(492, 59);
			groupBox10.TabIndex = 2;
			groupBox10.TabStop = false;
			groupBox10.Text = "Envio de Credenciais";
			// 
			// textBoxEmailEnvioCredenciais
			// 
			textBoxEmailEnvioCredenciais.Location = new Point(96, 22);
			textBoxEmailEnvioCredenciais.Name = "textBoxEmailEnvioCredenciais";
			textBoxEmailEnvioCredenciais.Size = new Size(233, 23);
			textBoxEmailEnvioCredenciais.TabIndex = 5;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(17, 25);
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
			groupBox9.Size = new Size(492, 103);
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
			ClientSize = new Size(502, 374);
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
			tabPagePatrimonio.PerformLayout();
			groupBoxCriarPatrimonio.ResumeLayout(false);
			groupBoxCriarPatrimonio.PerformLayout();
			groupBoxMovimentarPatrimonio.ResumeLayout(false);
			groupBoxMovimentarPatrimonio.PerformLayout();
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
		private GroupBox groupBoxCriarPatrimonio;
		private GroupBox groupBoxMovimentarPatrimonio;
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
		private Label label12;
		private TextBox textBoxDescricaoCPatrimonio;
		private TextBox textBoxNumeroCPatrimonio;
		private TextBox textBoxLocalCPatrimonio;
		private Label label18;
		private Label label17;
		private Label label16;
		private TextBox textBoxDescricaoMPatrimonio;
		private TextBox textBoxLocalNovoMPatrimonio;
		private TextBox textBoxLocalAtualMPatrimonio;
		private TextBox textBoxNumeroMPatrimonio;
		private Label label15;
		private Label label14;
		private Label label13;
		private Label label19;
		private Button buttonAnexarTraseira;
		private Button buttonAnexarFrontal;
		private Button buttonAnexarPlaqueta;
		private CheckBox checkBoxTraseira;
		private CheckBox checkBoxFrontal;
		private CheckBox checkBoxPlaqueta;
		private RadioButton radioButtonMovimentacaoPatrimonio;
		private RadioButton radioButtonCriacaoPatrimonio;
		private Button buttonEnviarPatrimonio;
	}
}
