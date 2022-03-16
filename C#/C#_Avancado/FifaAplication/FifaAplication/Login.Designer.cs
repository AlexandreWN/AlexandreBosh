
namespace FifaAplication
{
    partial class Login
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
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(61, 109);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(158, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Location = new System.Drawing.Point(61, 63);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(158, 20);
            this.txbEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // lkEsqueciSenha
            // 
            this.lkEsqueciSenha.AutoSize = true;
            this.lkEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkEsqueciSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkEsqueciSenha.LinkColor = System.Drawing.Color.Gray;
            this.lkEsqueciSenha.Location = new System.Drawing.Point(67, 189);
            this.lkEsqueciSenha.Name = "lkEsqueciSenha";
            this.lkEsqueciSenha.Size = new System.Drawing.Size(136, 16);
            this.lkEsqueciSenha.TabIndex = 3;
            this.lkEsqueciSenha.TabStop = true;
            this.lkEsqueciSenha.Text = "Esqueci minha senha";
            this.lkEsqueciSenha.VisitedLinkColor = System.Drawing.Color.Black;
            this.lkEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkEsqueciSenha_LinkClicked);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(232, 14);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(61, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Lembrar Minha Senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(61, 145);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(158, 23);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 290);
            this.ControlBox = false;
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lkEsqueciSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbSenha);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lkEsqueciSenha;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnEntrar;
    }
}