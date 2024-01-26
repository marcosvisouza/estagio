namespace login1.Apresentação
{
    partial class telaRegistrar
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
            button1 = new Button();
            lblEnail = new Label();
            boxEmail = new TextBox();
            boxSenhaRegistro = new TextBox();
            lblSenha = new Label();
            boxConfirmar = new TextBox();
            lblConfirmar = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Calisto MT", 11.25F);
            button1.Location = new Point(134, 296);
            button1.Name = "button1";
            button1.Size = new Size(193, 38);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblEnail
            // 
            lblEnail.AutoSize = true;
            lblEnail.Font = new Font("Calisto MT", 11.25F);
            lblEnail.Location = new Point(23, 87);
            lblEnail.Name = "lblEnail";
            lblEnail.Size = new Size(54, 17);
            lblEnail.TabIndex = 1;
            lblEnail.Text = "E-mail:";
            lblEnail.Click += label1_Click;
            // 
            // boxEmail
            // 
            boxEmail.Location = new Point(152, 86);
            boxEmail.Name = "boxEmail";
            boxEmail.Size = new Size(222, 23);
            boxEmail.TabIndex = 2;
            // 
            // boxSenhaRegistro
            // 
            boxSenhaRegistro.Location = new Point(152, 150);
            boxSenhaRegistro.Name = "boxSenhaRegistro";
            boxSenhaRegistro.Size = new Size(147, 23);
            boxSenhaRegistro.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Calisto MT", 11.25F);
            lblSenha.Location = new Point(23, 151);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(50, 17);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // boxConfirmar
            // 
            boxConfirmar.Location = new Point(152, 212);
            boxConfirmar.Name = "boxConfirmar";
            boxConfirmar.Size = new Size(147, 23);
            boxConfirmar.TabIndex = 6;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Calisto MT", 11.25F);
            lblConfirmar.Location = new Point(23, 213);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(118, 17);
            lblConfirmar.TabIndex = 5;
            lblConfirmar.Text = "Confirmar senha:";
            // 
            // telaRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(boxConfirmar);
            Controls.Add(lblConfirmar);
            Controls.Add(boxSenhaRegistro);
            Controls.Add(lblSenha);
            Controls.Add(boxEmail);
            Controls.Add(lblEnail);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "telaRegistrar";
            Text = "registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblEnail;
        private TextBox boxEmail;
        private TextBox boxSenhaRegistro;
        private Label lblSenha;
        private TextBox boxConfirmar;
        private Label lblConfirmar;
    }
}