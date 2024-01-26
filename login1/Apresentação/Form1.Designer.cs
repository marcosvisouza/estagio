namespace login1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            btnSair = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            txbSenha = new TextBox();
            btnRegistrar = new Button();
            txbLogin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(319, 239);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(422, 239);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button2_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(333, 110);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(42, 15);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += label1_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(333, 169);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "SENHA";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(422, 160);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(172, 23);
            txbSenha.TabIndex = 6;
            txbSenha.TextChanged += boxSenha_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(524, 239);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(422, 110);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(172, 23);
            txbLogin.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(txbLogin);
            Controls.Add(btnRegistrar);
            Controls.Add(txbSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button btnSair;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txbSenha;
        private Button btnRegistrar;
        private TextBox txbLogin;
    }
}
