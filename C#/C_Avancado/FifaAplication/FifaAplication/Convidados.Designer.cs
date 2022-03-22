
namespace FifaAplication
{
    partial class Convidados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convidados));
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNotificacoes = new System.Windows.Forms.Button();
            this.btnJogos = new System.Windows.Forms.Button();
            this.btnConvidados = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.moduloDesktopDataSet1 = new FifaAplication.ModuloDesktopDataSet();
            this.dtgridConvidados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnRenovaConvite = new System.Windows.Forms.Button();
            this.btnNovoConvite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloDesktopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConvidados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(736, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(36, 32);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnNotificacoes);
            this.panel1.Controls.Add(this.btnJogos);
            this.panel1.Controls.Add(this.btnConvidados);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 127);
            this.panel1.TabIndex = 8;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.lbUsuario.Location = new System.Drawing.Point(631, 103);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 14;
            this.lbUsuario.Text = "label1";
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.button5.Location = new System.Drawing.Point(531, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 52);
            this.button5.TabIndex = 13;
            this.button5.Text = "Configurações";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.button4.Location = new System.Drawing.Point(424, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ranking";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnNotificacoes
            // 
            this.btnNotificacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotificacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificacoes.FlatAppearance.BorderSize = 0;
            this.btnNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnNotificacoes.Location = new System.Drawing.Point(317, 48);
            this.btnNotificacoes.Name = "btnNotificacoes";
            this.btnNotificacoes.Size = new System.Drawing.Size(105, 52);
            this.btnNotificacoes.TabIndex = 11;
            this.btnNotificacoes.Text = "Notificações";
            this.btnNotificacoes.UseVisualStyleBackColor = true;
            // 
            // btnJogos
            // 
            this.btnJogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogos.FlatAppearance.BorderSize = 0;
            this.btnJogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnJogos.Location = new System.Drawing.Point(210, 48);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(105, 52);
            this.btnJogos.TabIndex = 10;
            this.btnJogos.Text = "Jogos";
            this.btnJogos.UseVisualStyleBackColor = true;
            // 
            // btnConvidados
            // 
            this.btnConvidados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvidados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvidados.FlatAppearance.BorderSize = 0;
            this.btnConvidados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvidados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvidados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnConvidados.Location = new System.Drawing.Point(103, 48);
            this.btnConvidados.Name = "btnConvidados";
            this.btnConvidados.Size = new System.Drawing.Size(105, 52);
            this.btnConvidados.TabIndex = 9;
            this.btnConvidados.Text = "Convidados";
            this.btnConvidados.UseVisualStyleBackColor = true;
            this.btnConvidados.Click += new System.EventHandler(this.btnConvidados_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(16, 19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(81, 97);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.White;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(658, 48);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(48, 52);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 7;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Convidados";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(621, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Revalidade Convites";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(251, 234);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(136, 27);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // moduloDesktopDataSet1
            // 
            this.moduloDesktopDataSet1.DataSetName = "ModuloDesktopDataSet";
            this.moduloDesktopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtgridConvidados
            // 
            this.dtgridConvidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridConvidados.GridColor = System.Drawing.Color.White;
            this.dtgridConvidados.Location = new System.Drawing.Point(251, 267);
            this.dtgridConvidados.Name = "dtgridConvidados";
            this.dtgridConvidados.Size = new System.Drawing.Size(278, 393);
            this.dtgridConvidados.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(64, 155);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(161, 22);
            this.txbEmail.TabIndex = 27;
            // 
            // btnRenovaConvite
            // 
            this.btnRenovaConvite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnRenovaConvite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenovaConvite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovaConvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovaConvite.ForeColor = System.Drawing.Color.White;
            this.btnRenovaConvite.Location = new System.Drawing.Point(393, 234);
            this.btnRenovaConvite.Name = "btnRenovaConvite";
            this.btnRenovaConvite.Size = new System.Drawing.Size(136, 27);
            this.btnRenovaConvite.TabIndex = 28;
            this.btnRenovaConvite.Text = "Renovar Convite";
            this.btnRenovaConvite.UseVisualStyleBackColor = false;
            // 
            // btnNovoConvite
            // 
            this.btnNovoConvite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.btnNovoConvite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoConvite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoConvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoConvite.ForeColor = System.Drawing.Color.White;
            this.btnNovoConvite.Location = new System.Drawing.Point(64, 184);
            this.btnNovoConvite.Name = "btnNovoConvite";
            this.btnNovoConvite.Size = new System.Drawing.Size(161, 27);
            this.btnNovoConvite.TabIndex = 29;
            this.btnNovoConvite.Text = "Novo Convite";
            this.btnNovoConvite.UseVisualStyleBackColor = false;
            // 
            // Convidados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(784, 672);
            this.ControlBox = false;
            this.Controls.Add(this.btnNovoConvite);
            this.Controls.Add(this.btnRenovaConvite);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgridConvidados);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Convidados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Convidados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloDesktopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridConvidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNotificacoes;
        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.Button btnConvidados;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtualizar;
        private ModuloDesktopDataSet moduloDesktopDataSet1;
        private System.Windows.Forms.DataGridView dtgridConvidados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnRenovaConvite;
        private System.Windows.Forms.Button btnNovoConvite;
    }
}