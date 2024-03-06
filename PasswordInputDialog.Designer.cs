namespace GerenciadorTI
{
	partial class PasswordInputDialog
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
			buttonOk = new Button();
			textBoxPassword = new TextBox();
			label1 = new Label();
			buttonCancelar = new Button();
			SuspendLayout();
			// 
			// buttonOk
			// 
			buttonOk.Location = new Point(46, 74);
			buttonOk.Name = "buttonOk";
			buttonOk.Size = new Size(75, 23);
			buttonOk.TabIndex = 0;
			buttonOk.Text = "OK";
			buttonOk.UseVisualStyleBackColor = true;
			buttonOk.Click += buttonOk_Click;
			// 
			// textBoxPassword
			// 
			textBoxPassword.Location = new Point(67, 31);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.PasswordChar = '*';
			textBoxPassword.Size = new Size(150, 23);
			textBoxPassword.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(100, 9);
			label1.Name = "label1";
			label1.Size = new Size(87, 15);
			label1.TabIndex = 2;
			label1.Text = "Senha de envio";
			// 
			// buttonCancelar
			// 
			buttonCancelar.Location = new Point(168, 74);
			buttonCancelar.Name = "buttonCancelar";
			buttonCancelar.Size = new Size(75, 23);
			buttonCancelar.TabIndex = 3;
			buttonCancelar.Text = "Cancelar";
			buttonCancelar.UseVisualStyleBackColor = true;
			buttonCancelar.Click += buttonCancelar_Click;
			// 
			// PasswordInputDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(305, 109);
			Controls.Add(buttonCancelar);
			Controls.Add(label1);
			Controls.Add(textBoxPassword);
			Controls.Add(buttonOk);
			Name = "PasswordInputDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Check de Segurança";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonOk;
		private TextBox textBoxPassword;
		private Label label1;
		private Button buttonCancelar;
	}
}