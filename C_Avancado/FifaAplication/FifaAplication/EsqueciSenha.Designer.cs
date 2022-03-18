
namespace FifaAplication
{
    partial class EsqueciSenha
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbResposta = new System.Windows.Forms.TextBox();
            this.lbPergunta = new System.Windows.Forms.Label();
            this.dtPiker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(92, 152);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(215, 42);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(339, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(36, 33);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perguntas de Segurança";
            // 
            // txbResposta
            // 
            this.txbResposta.Location = new System.Drawing.Point(92, 110);
            this.txbResposta.Name = "txbResposta";
            this.txbResposta.Size = new System.Drawing.Size(215, 20);
            this.txbResposta.TabIndex = 7;
            // 
            // lbPergunta
            // 
            this.lbPergunta.AutoSize = true;
            this.lbPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.lbPergunta.Location = new System.Drawing.Point(89, 79);
            this.lbPergunta.Name = "lbPergunta";
            this.lbPergunta.Size = new System.Drawing.Size(62, 16);
            this.lbPergunta.TabIndex = 15;
            this.lbPergunta.Text = "Pergunta";
            this.lbPergunta.Click += new System.EventHandler(this.lbPergunta_Click);
            // 
            // dtPiker
            // 
            this.dtPiker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPiker.Location = new System.Drawing.Point(92, 110);
            this.dtPiker.Name = "dtPiker";
            this.dtPiker.Size = new System.Drawing.Size(215, 20);
            this.dtPiker.TabIndex = 16;
            // 
            // EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 228);
            this.ControlBox = false;
            this.Controls.Add(this.dtPiker);
            this.Controls.Add(this.lbPergunta);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbResposta);
            this.Name = "EsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EsqueciSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbResposta;
        private System.Windows.Forms.Label lbPergunta;
        private System.Windows.Forms.DateTimePicker dtPiker;
    }
}