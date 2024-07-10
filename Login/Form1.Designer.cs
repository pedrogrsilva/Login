namespace Login
{
    partial class tela_de_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.Transparent;
            this.lb_login.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(282, 164);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(55, 16);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Login:";
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.BackColor = System.Drawing.Color.Transparent;
            this.lb_senha.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(282, 224);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(55, 16);
            this.lb_senha.TabIndex = 1;
            this.lb_senha.Text = "Senha:";
            this.lb_senha.Click += new System.EventHandler(this.lb_senha_Click);
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(339, 164);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(156, 20);
            this.text_login.TabIndex = 1;
            this.text_login.Text = "Digite o Login";
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(339, 221);
            this.text_senha.Name = "text_senha";
            this.text_senha.PasswordChar = '*';
            this.text_senha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_senha.Size = new System.Drawing.Size(156, 20);
            this.text_senha.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(339, 274);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(420, 274);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(253, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(253, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(339, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 64);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tela_de_login
            // 
            this.AcceptButton = this.btn_entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_login);
            this.Name = "tela_de_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

