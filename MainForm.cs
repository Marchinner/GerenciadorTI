using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;
using System.Xml.Linq;

namespace GerenciadorTI
{
	public partial class MainForm : Form
	{
		private string configFilePath = "Config.xml";
		private PrincipalContext AD;
		private UserPrincipal user;
		private UserPrincipal userFound;
		private ComputerPrincipal computer;
		private string userOrganizationalUnit;
		private string hostPassword;
		private string filePathPlaqueta;
		private string filePathFrontal;
		private string filePathTraseira;

		public MainForm()
		{
			try
			{
				// Conecta ao Active Directory
				AD = new PrincipalContext(ContextType.Domain);
				user = new UserPrincipal(AD);
				InitializeComponent();

				// Verifica se existe arquivo de configura��o
				if (File.Exists(configFilePath))
				{
					LoadConfig();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}
		}
		private void LoadConfig()
		{
			XElement xml = XElement.Load(configFilePath);
			textBoxHostSmtp.Text = xml.Element("Host").Value;
			textBoxPortaSmtp.Text = xml.Element("Porta").Value;
			checkBoxUsaSSLSmtp.Checked = bool.Parse(xml.Element("SSL").Value);
			textBoxEmailDestinoPatrimonio.Text = xml.Element("EmailDestinoPatrimonio").Value;
			textBoxEmailEnvioPatrimonio.Text = xml.Element("EmailEnvioPatrimonio").Value;
			textBoxEmailEnvioCredenciais.Text = xml.Element("EmailEnvioCredenciais").Value;
		}

		private void SaveConfig()
		{
			XElement xml = new XElement("Config",
				new XElement("Host", textBoxHostSmtp.Text.Trim()),
				new XElement("Porta", textBoxPortaSmtp.Text.Trim()),
				new XElement("SSL", checkBoxUsaSSLSmtp.Checked),
				new XElement("EmailDestinoPatrimonio", textBoxEmailDestinoPatrimonio.Text.Trim()),
				new XElement("EmailEnvioPatrimonio", textBoxEmailEnvioPatrimonio.Text.Trim()),
				new XElement("EmailEnvioCredenciais", textBoxEmailEnvioCredenciais.Text.Trim()));
			xml.Save(configFilePath);

			LoadConfig();
		}

		private UserPrincipal SearchUser(string username)
		{
			user.SamAccountName = username;
			PrincipalSearcher userSearchFilter = new PrincipalSearcher(user);
			UserPrincipal result = (UserPrincipal)userSearchFilter.FindOne();
			userSearchFilter.Dispose();

			return result;
		}

		private void LoadUserInfos(UserPrincipal user)
		{
			if (user != null)
			{
				// Mostra o nome completo do usu�rio
				labelNomeUsuario.Text = userFound.DisplayName;

				// Mostra o e-mail do usu�rio
				textBoxEmailUsuario.Text = userFound.EmailAddress;

				// Habilita o textBox do e-mail do usu�rio
				textBoxEmailUsuario.Enabled = true;

				// Mostra o status do usu�rio
				labelStatusUsuario.Text = userFound.Enabled == true ? "Usu�rio habilitado" : "Usu�rio desabilitado";

				// Habilita o bot�o de mudar o status do usu�rio
				buttonToggleStatusUsuario.Text = userFound.Enabled == true ? "Desabilitar" : "Habilitar";
				buttonToggleStatusUsuario.Enabled = true;

				// Mostra o equipamento liberado para logon do usu�rio
				listBoxMaquinaLiberada.Items.Clear();
				listBoxMaquinaLiberada.Items.AddRange(userFound.PermittedWorkstations.ToArray());

				// Habilita o textBox do equipamento liberado para o usu�rio
				textBoxMaquinaLiberada.Enabled = true;

				// Cria uma query para as Unidades Organizacionais
				DirectoryEntry directoryEntry = new DirectoryEntry();
				DirectorySearcher directorySearcher = new DirectorySearcher(directoryEntry);
				directorySearcher.Filter = "(objectClass=organizationalUnit)";
				SearchResultCollection directorySearcherResults = directorySearcher.FindAll();
				// Cria a lista que vai armazenar o resultado da query
				List<string> ouList = new List<string>();
				// Armazena cada resultado da query na lista como uma string
				foreach (SearchResult results in directorySearcherResults)
				{
					DirectoryEntry directoryEntryResult = results.GetDirectoryEntry();
					string ouName = directoryEntryResult.Name;
					ouList.Add(ouName);
				}
				// Cria o array de OU's e inicializa com a lista de resultados
				string[] ouArray = ouList.ToArray();
				// Adiciona o array ao comboBox
				comboBoxUnidadeOrganizacional.Items.AddRange(ouArray);
				// Recupera a OU atual do usu�rio pelo DistinguishedName
				string[] dnComponents = userFound.DistinguishedName.Split(',');
				// O primeiro elemento do array dnComponents � a OU
				userOrganizationalUnit = dnComponents[1];
				// Procura pela OU atual no array das OU's encontradas e seleciona 
				comboBoxUnidadeOrganizacional.SelectedIndex = Array.IndexOf(ouArray, userOrganizationalUnit);

				// Habilita o comboBox da OU do usu�rio
				comboBoxUnidadeOrganizacional.Enabled = true;
			}
			else
			{
				MessageBox.Show("Usu�rio n�o encontrado!");
				textBoxUser.Clear();
				textBoxUser.Focus();
			}
		}

		private void buttonBuscarUsuario_Click(object sender, EventArgs e)
		{
			userFound = SearchUser(textBoxUser.Text.Trim());
			LoadUserInfos(userFound);
		}

		private void textBoxUser_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(textBoxUser.Text))
			{
				buttonBuscarUsuario.Enabled = true;
			}
			else
			{
				buttonBuscarUsuario.Enabled = false;
			}
		}

		private void comboBoxUnidadeOrganizacional_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxUnidadeOrganizacional.GetItemText(comboBoxUnidadeOrganizacional.SelectedItem) != userOrganizationalUnit)
			{
				buttonTransferirUsuario.Enabled = true;
			}
			else
			{
				buttonTransferirUsuario.Enabled = false;
			}
		}

		private void buttonToggleStatusUsuario_Click(object sender, EventArgs e)
		{
			if (userFound.Enabled == true)
			{
				userFound.Enabled = false;
			}
			else
			{
				userFound.Enabled = true;
			}

			userFound.Save();
			LoadUserInfos(userFound);
		}

		private void textBoxEmailUsuario_TextChanged(object sender, EventArgs e)
		{
			if (textBoxEmailUsuario.Text != userFound.EmailAddress
				&& !String.IsNullOrEmpty(textBoxEmailUsuario.Text.Trim()))
			{
				buttonAlterarEmailUsuario.Enabled = true;
			}
			else
			{
				buttonAlterarEmailUsuario.Enabled = false;
			}
		}

		private void buttonAlterarEmailUsuario_Click(object sender, EventArgs e)
		{
			userFound.EmailAddress = textBoxEmailUsuario.Text.Trim();
			userFound.Save();
			LoadUserInfos(userFound);
		}

		private void buttonTransferirUsuario_Click(object sender, EventArgs e)
		{
			string selectedOU = comboBoxUnidadeOrganizacional.GetItemText(comboBoxUnidadeOrganizacional.SelectedItem).Split('=')[1];

			DirectoryEntry root = new DirectoryEntry();
			DirectorySearcher rootSearcher = new DirectorySearcher(root);

			rootSearcher.Filter = $"(&(objectClass=organizationalUnit)(name={selectedOU}))";
			SearchResult rootSearcherResult = rootSearcher.FindOne();

			if (rootSearcherResult != null)
			{
				DirectoryEntry newOuEntry = rootSearcherResult.GetDirectoryEntry();
				DirectoryEntry userEntry = (DirectoryEntry)userFound.GetUnderlyingObject();
				userEntry.MoveTo(newOuEntry);
				userEntry.CommitChanges();
				MessageBox.Show("Usu�rio transferido com sucesso!");
			}
			else
			{
				MessageBox.Show("Unidade Organizacional n�o encontrada!");
			}
		}

		private void textBoxMaquinaLiberada_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxMaquinaLiberada.Text.Trim())
				&& !userFound.PermittedWorkstations.Contains(textBoxMaquinaLiberada.Text))
			{
				buttonAdicionarMaquinaLiberada.Enabled = true;
			}
			else
			{
				buttonAdicionarMaquinaLiberada.Enabled = false;
			}
		}

		private void listBoxMaquinaLiberada_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonRemoverMaquinaLiberada.Enabled = true;
		}

		private void buttonRemoverMaquinaLiberada_Click(object sender, EventArgs e)
		{
			userFound.PermittedWorkstations.RemoveAt(listBoxMaquinaLiberada.SelectedIndex);

			userFound.Save();
			LoadUserInfos(userFound);
		}

		private void buttonAdicionarMaquinaLiberada_Click(object sender, EventArgs e)
		{
			userFound.PermittedWorkstations.Add(textBoxMaquinaLiberada.Text);
			textBoxMaquinaLiberada.Clear();

			userFound.Save();
			LoadUserInfos(userFound);
		}

		private void LoadComputerInfos(ComputerPrincipal computerPrincipal)
		{
			labelStatusNetbios.Text = computerPrincipal.Enabled == true
				? "Netbios habilitada" : "Netbios desabilitada";

			buttonToggleStatusNetbios.Text = computerPrincipal.Enabled == true
				? "Desabilitar" : "Habilitar";
		}

		private void SearchComputer(String netbios)
		{
			computer = ComputerPrincipal.FindByIdentity(AD, netbios);
			if (computer != null)
			{
				buttonToggleStatusNetbios.Enabled = true;
				LoadComputerInfos(computer);
			}
			else
			{
				buttonToggleStatusNetbios.Enabled = false;
				MessageBox.Show("Computador n�o encontrado!");
			}
		}

		private void textBoxNetbios_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxNetbios.Text.Trim()))
			{
				buttonBuscarNetbios.Enabled = true;
			}
			else
			{
				buttonBuscarNetbios.Enabled = false;
			}
		}

		private void buttonBuscarNetbios_Click(object sender, EventArgs e)
		{
			SearchComputer(textBoxNetbios.Text.Trim());
		}

		private void buttonToggleStatusNetbios_Click(object sender, EventArgs e)
		{
			switch (computer.Enabled)
			{
				case true:
					computer.Enabled = false; break;
				case false:
					computer.Enabled = true; break;
			}

			computer.Save();
			LoadComputerInfos(computer);
		}

		private void buttonSalvarConfig_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBoxHostSmtp.Text.Trim())
				&& !string.IsNullOrEmpty(textBoxPortaSmtp.Text.Trim())
				&& !string.IsNullOrEmpty(textBoxEmailDestinoPatrimonio.Text.Trim())
				&& !string.IsNullOrEmpty(textBoxEmailEnvioPatrimonio.Text.Trim())
				&& !string.IsNullOrEmpty(textBoxEmailEnvioCredenciais.Text.Trim()))
			{
				SaveConfig();
				MessageBox.Show("Configura��es salvas!");
			}
			else
			{
				MessageBox.Show("Todos os campos de configura��o devem estar preenchidos!");
			}

		}

		private void buttonResetarConfig_Click(object sender, EventArgs e)
		{
			textBoxHostSmtp.Clear();
			textBoxPortaSmtp.Clear();
			checkBoxUsaSSLSmtp.Checked = false;
			textBoxEmailDestinoPatrimonio.Clear();
			textBoxEmailEnvioPatrimonio.Clear();
			textBoxEmailEnvioCredenciais.Clear();

			SaveConfig();

			MessageBox.Show("Configura��es redefinidas!");
		}

		private void radioButtonMovimentacaoPatrimonio_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonMovimentacaoPatrimonio.Checked)
			{
				radioButtonCriacaoPatrimonio.Checked = false;
				groupBoxMovimentarPatrimonio.Enabled = true;
				groupBoxCriarPatrimonio.Enabled = false;
			}
		}

		private void radioButtonCriacaoPatrimonio_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonCriacaoPatrimonio.Checked)
			{
				radioButtonMovimentacaoPatrimonio.Checked = false;
				groupBoxCriarPatrimonio.Enabled = true;
				groupBoxMovimentarPatrimonio.Enabled = false;
			}
		}

		private void buttonEnviarPatrimonio_Click(object sender, EventArgs e)
		{

			if (File.Exists(configFilePath))
			{
				LoadConfig();
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(textBoxEmailEnvioPatrimonio.Text);
				mailMessage.To.Add(new MailAddress(textBoxEmailDestinoPatrimonio.Text));
				mailMessage.CC.Add(textBoxEmailEnvioPatrimonio.Text);
				mailMessage.IsBodyHtml = true;
				string message;

				if (radioButtonMovimentacaoPatrimonio.Checked)
				{
					if (!string.IsNullOrEmpty(textBoxNumeroMPatrimonio.Text.Trim())
						&& !string.IsNullOrEmpty(textBoxLocalAtualMPatrimonio.Text.Trim())
						&& !string.IsNullOrEmpty(textBoxLocalNovoMPatrimonio.Text.Trim())
						&& !string.IsNullOrEmpty(textBoxDescricaoMPatrimonio.Text.Trim()))
					{
						mailMessage.Subject = "Movimenta��o de Patrim�nio N�" + textBoxNumeroMPatrimonio.Text;
						message = $"" +
							"<html>" +
							"<body>" +
							"<h3>Detalhes da Movimenta��o de Patrim�nio</h3><br>" +
							$"<strong>N�:</strong> {textBoxNumeroMPatrimonio.Text}<br>" +
							$"<strong>Local Atual:</strong> {textBoxLocalAtualMPatrimonio.Text}<br>" +
							$"<strong>Local Novo:</strong> {textBoxLocalNovoMPatrimonio.Text}<br>" +
							$"<strong>Descri��o:</strong> {textBoxDescricaoMPatrimonio.Text}<br>" +
							"</body>" +
							"</html>";

						mailMessage.Body = message;

						try
						{
							if (hostPassword == null)
							{
								using (PasswordInputDialog passwordInputDialog = new PasswordInputDialog())
								{
									if (passwordInputDialog.ShowDialog() == DialogResult.OK)
									{
										hostPassword = passwordInputDialog.Password;
									}
								}
							}
							using (SmtpClient smtpClient = new SmtpClient(textBoxHostSmtp.Text))
							{
								smtpClient.Port = int.Parse(textBoxPortaSmtp.Text);
								smtpClient.UseDefaultCredentials = false;
								smtpClient.EnableSsl = checkBoxUsaSSLSmtp.Checked;
								smtpClient.Credentials = new NetworkCredential(textBoxEmailEnvioPatrimonio.Text, hostPassword);
								smtpClient.Send(mailMessage);
							}
							MessageBox.Show("E-mail envidado!");
						}
						catch (Exception ex)
						{
							MessageBox.Show("O envio falhou: " + ex.ToString());
						}
					}
					else
					{
						MessageBox.Show("Todas as informa��es devem ser preenchidas!");
					}
				}
				else
				{
					if (!string.IsNullOrEmpty(textBoxNumeroCPatrimonio.Text.Trim())
										&& !string.IsNullOrEmpty(textBoxLocalCPatrimonio.Text.Trim())
										&& !string.IsNullOrEmpty(textBoxDescricaoCPatrimonio.Text.Trim())
										&& checkBoxFrontal.Checked && checkBoxPlaqueta.Checked && checkBoxTraseira.Checked)
					{
						mailMessage.Subject = "Novo Patrim�nio N�" + textBoxNumeroCPatrimonio.Text;
						message = "" +
							"<html>" +
							"<body>" +
							"<h3>Novo Item de Patrim�nio</h3><br>" +
							$"<strong>N�:</strong> {textBoxNumeroCPatrimonio.Text}<br>" +
							$"<strong>Local:</strong> {textBoxLocalCPatrimonio.Text}<br>" +
							$"<strong>Descri��o:</strong> {textBoxDescricaoCPatrimonio.Text}<br><br>" +
							"Fotos seguem em <strong>anexo</strong>." +
							"</body>" +
							"</html>";
						mailMessage.Body = message;
						Attachment attachmentPlaqueta = new Attachment(filePathPlaqueta);
						Attachment attachmentFrontal = new Attachment(filePathFrontal);
						Attachment attachmentTraseira = new Attachment(filePathTraseira);

						mailMessage.Attachments.Add(attachmentPlaqueta);
						mailMessage.Attachments.Add(attachmentFrontal);
						mailMessage.Attachments.Add(attachmentTraseira);

						try
						{
							if (hostPassword == null)
							{
								using (PasswordInputDialog passwordInputDialog = new PasswordInputDialog())
								{
									if (passwordInputDialog.ShowDialog() == DialogResult.OK)
									{
										hostPassword = passwordInputDialog.Password;
									}
								}
							}
							using (SmtpClient smtpClient = new SmtpClient(textBoxHostSmtp.Text))
							{
								smtpClient.Port = int.Parse(textBoxPortaSmtp.Text);
								smtpClient.UseDefaultCredentials = false;
								smtpClient.EnableSsl = checkBoxUsaSSLSmtp.Checked;
								smtpClient.Credentials = new NetworkCredential(textBoxEmailEnvioPatrimonio.Text, hostPassword);
								smtpClient.Send(mailMessage);
							}

							MessageBox.Show("E-mail envidado!");
							checkBoxPlaqueta.Checked = false;
							checkBoxFrontal.Checked = false;
							checkBoxTraseira.Checked = false;
						}
						catch (Exception ex)
						{
							MessageBox.Show("O envio falhou: " + ex.ToString());
						}
					}
					else
					{
						MessageBox.Show("Todas as informa��es devem ser preenchidas!");
					}
				}
			}
			else
			{
				MessageBox.Show("Configura��es de envio n�o localizada!");
			}
		}

		private void buttonAnexarPlaqueta_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Imagens(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.Multiselect = false;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					filePathPlaqueta = openFileDialog.FileName;
					checkBoxPlaqueta.Checked = true;
				}
			}
		}

		private void buttonAnexarFrontal_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Imagens(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.Multiselect = false;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					filePathFrontal = openFileDialog.FileName;
					checkBoxFrontal.Checked = true;
				}
			}
		}

		private void buttonAnexarTraseira_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Imagens(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.Multiselect = false;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					filePathTraseira = openFileDialog.FileName;
					checkBoxTraseira.Checked = true;
				}
			}
		}

		private void checkBoxJrti_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxJrti.Checked)
			{
				groupBoxJrti.Enabled = true;
			}
			else
			{
				groupBoxJrti.Enabled = false;
			}
		}

		private void checkBoxSysemp_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxSysemp.Checked)
			{
				groupBoxSysemp.Enabled = true;
			}
			else
			{
				groupBoxSysemp.Enabled = false;
			}
		}

		private void buttonEnviarCredenciais_Click(object sender, EventArgs e)
		{
			if (File.Exists(configFilePath))
			{
				LoadConfig();
				MailMessage welcomeMailMessage = new MailMessage(textBoxEmailEnvioCredenciais.Text, textBoxEmailUsuarioAd.Text);
				welcomeMailMessage.CC.Add(textBoxEmailEnvioCredenciais.Text);
				welcomeMailMessage.IsBodyHtml = true;
				string pronome = radioButtonSexoF.Checked ? "a" : "o";
				string subject = $"Bem-vind{pronome}!";
				string message;
				string jrti = "";
				string sysemp = "";
				welcomeMailMessage.Subject = subject;
				bool checkInformacoesJrti = true;
				bool checkInformacoesSysemp = true;

				if (!string.IsNullOrEmpty(textBoxUsuarioAd.Text.Trim())
								&& !string.IsNullOrEmpty(textBoxSenhaAd.Text.Trim())
								&& !string.IsNullOrEmpty(textBoxImpressorasAd.Text.Trim())
								&& !string.IsNullOrEmpty(maskedTextBoxPinImpressoras.Text.Trim())
								&& !string.IsNullOrEmpty(textBoxEmailUsuarioAd.Text.Trim()))
				{
					if (checkBoxJrti.Checked)
					{
						if (!string.IsNullOrEmpty(textBoxUsuarioJrti.Text.Trim())
							&& !string.IsNullOrEmpty(textBoxSenhaJrti.Text.Trim()))
						{
							jrti = $"<strong>Credenciais JRTI:</strong><br>" +
								$"<strong>Usu�rio:</strong> {textBoxUsuarioJrti.Text.Trim()}<br>" +
								$"<strong>Senha:</strong> {textBoxSenhaJrti.Text.Trim()}<br><br>";
							checkInformacoesJrti = true;
						}
						else
						{
							MessageBox.Show("Todos os campos de informa��es do JRTi devem estar preenchidos!");
							checkInformacoesJrti = false;
						}
					}
					if (checkBoxSysemp.Checked)
					{
						if (!string.IsNullOrEmpty(textBoxUsuarioSysemp.Text.Trim())
							&& !string.IsNullOrEmpty(textBoxSenhaSysemp.Text.Trim()))
						{
							sysemp = $"<strong>Credenciais Sysemp:</strong><br>" +
								$"<strong>Usu�rio:</strong> {textBoxUsuarioSysemp.Text.Trim()}<br>" +
								$"<strong>Senha:</strong> {textBoxSenhaSysemp.Text.Trim()}<br><br>";
							checkInformacoesSysemp = true;
						}
						else
						{
							MessageBox.Show("Todos os campos de informa��es do Sysemp devem estar preenchidos!");
							checkInformacoesSysemp = false;
						}
					}

					if (checkInformacoesJrti && checkInformacoesSysemp)
					{

						message = "" +
															"<html>" +
															"<body>" +
															$"<h3>Bem-vind{pronome}!</h3><br>" +
															"Somos da equipe de T.I e viemos te desejar boas-vindas!" +
															"Segue abaixo as suas credenciais de acesso que ir� utilizar:<br><br>" +
															$"<strong>E-mail:</strong> {textBoxEmailUsuarioAd.Text.Trim()}<br>" +
															$"<strong>Login:</strong> {textBoxUsuarioAd.Text.Trim()}<br>" +
															$"<strong>Senha:</strong> {textBoxSenhaAd.Text.Trim()}<br>" +
															$"<strong>Impressoras:</strong> {textBoxImpressorasAd.Text.Trim()}<br>" +
															$"<strong>PIN de Impress�o:</strong> {maskedTextBoxPinImpressoras.Text.Trim()}<br><br>" +
															$"{jrti}" +
															$"{sysemp}" +
															"Por favor, anote estas informa��es e deixe este e-mail guardado em um local seguro caso " +
															"necessite revisar estas informa��es!<br>" +
															"Qualquer d�vida ou problemas relacionados ao nosso setor, favor abrir um chamado atrav�s do " +
															$"email <a href='maito:{textBoxEmailEnvioCredenciais.Text.Trim()}'>{textBoxEmailEnvioCredenciais.Text.Trim()}</a>.<br><br>" +
															$"<strong>Observa��o:</strong> para ser atendido, � <span style='color:red'>CRUCIAL</span>" +
															$" a abertura de chamado via e-mail pois controlamos e planejamos todos os atendimentos e" +
															$" procedimentos.<br><br>" +
															$"Att,<br><br>" +
															$"<strong>Departamento de Tecnologia da Informa��o.</strong>" +
															"</body>" +
															"</html>";

						welcomeMailMessage.Body = message;


						try
						{
							if (hostPassword == null)
							{
								using (PasswordInputDialog passwordInputDialog = new PasswordInputDialog())
								{
									if (passwordInputDialog.ShowDialog() == DialogResult.OK)
									{
										hostPassword = passwordInputDialog.Password;
									}
								}
							}
							using (SmtpClient smtpClient = new SmtpClient(textBoxHostSmtp.Text))
							{
								smtpClient.Port = int.Parse(textBoxPortaSmtp.Text);
								smtpClient.UseDefaultCredentials = false;
								smtpClient.EnableSsl = checkBoxUsaSSLSmtp.Checked;
								smtpClient.Credentials = new NetworkCredential(textBoxEmailEnvioCredenciais.Text, hostPassword);
								smtpClient.Send(welcomeMailMessage);
							}
							MessageBox.Show("E-mail envidado!");
						}
						catch (Exception ex)
						{
							MessageBox.Show("O envio falhou: " + ex.ToString());
						}
					}
				}
				else
				{
					MessageBox.Show("Todos os campos das informa��es b�sicas devem estar preenchidos!");
				}
			}
			else
			{
				MessageBox.Show("Arquivo de Configura��o n�o encontrado!");
			}
		}
	}
}
