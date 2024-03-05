using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
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

		public MainForm()
		{
			try
			{
				// Conecta ao Active Directory
				AD = new PrincipalContext(ContextType.Domain);
				user = new UserPrincipal(AD);
				InitializeComponent();

				// Verifica se existe arquivo de configuração
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
				new XElement("Host", textBoxHostSmtp.Text),
				new XElement("Porta", textBoxPortaSmtp.Text),
				new XElement("SSL", checkBoxUsaSSLSmtp.Checked),
				new XElement("EmailDestinoPatrimonio", textBoxEmailDestinoPatrimonio.Text),
				new XElement("EmailEnvioPatrimonio", textBoxEmailEnvioPatrimonio.Text),
				new XElement("EmailEnvioCredenciais", textBoxEmailEnvioCredenciais.Text));
			xml.Save(configFilePath);
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
				// Mostra o nome completo do usuário
				labelNomeUsuario.Text = userFound.DisplayName;

				// Mostra o e-mail do usuário
				textBoxEmailUsuario.Text = userFound.EmailAddress;

				// Habilita o textBox do e-mail do usuário
				textBoxEmailUsuario.Enabled = true;

				// Mostra o status do usuário
				labelStatusUsuario.Text = userFound.Enabled == true ? "Usuário habilitado" : "Usuário desabilitado";

				// Habilita o botão de mudar o status do usuário
				buttonToggleStatusUsuario.Text = userFound.Enabled == true ? "Desabilitar" : "Habilitar";
				buttonToggleStatusUsuario.Enabled = true;

				// Mostra o equipamento liberado para logon do usuário
				listBoxMaquinaLiberada.Items.Clear();
				listBoxMaquinaLiberada.Items.AddRange(userFound.PermittedWorkstations.ToArray());

				// Habilita o textBox do equipamento liberado para o usuário
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
				// Recupera a OU atual do usuário pelo DistinguishedName
				string[] dnComponents = userFound.DistinguishedName.Split(',');
				// O primeiro elemento do array dnComponents é a OU
				userOrganizationalUnit = dnComponents[1];
				// Procura pela OU atual no array das OU's encontradas e seleciona 
				comboBoxUnidadeOrganizacional.SelectedIndex = Array.IndexOf(ouArray, userOrganizationalUnit);

				// Habilita o comboBox da OU do usuário
				comboBoxUnidadeOrganizacional.Enabled = true;
			}
			else
			{
				MessageBox.Show("Usuário não encontrado!");
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
				MessageBox.Show("Usuário transferido com sucesso!");
			}
			else
			{
				MessageBox.Show("Unidade Organizacional não encontrada!");
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
				MessageBox.Show("Computador não encontrado!");
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
			SaveConfig();

			MessageBox.Show("Configurações salvas!");
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

			MessageBox.Show("Configurações redefinidas!");
		}
	}
}
