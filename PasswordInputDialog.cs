using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorTI
{
	public partial class PasswordInputDialog : Form
	{
		public string Password
		{
			get { return textBoxPassword.Text; }
		}

		public PasswordInputDialog()
		{
			InitializeComponent();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxPassword.Text.Trim()))
			{
				MessageBox.Show("A senha não pode ser nula!");
				return;
			}

			DialogResult = DialogResult.OK;
		}

		private void buttonCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
