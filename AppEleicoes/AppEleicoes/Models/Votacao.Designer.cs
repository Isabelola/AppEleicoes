namespace AppEleicoes.Models
{
    partial class Votacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxCandidatos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCorrige = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Votação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite o número e vote no candidato escolhido.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.listBoxCandidatos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(56, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 459);
            this.panel1.TabIndex = 7;
            // 
            // listBoxCandidatos
            // 
            this.listBoxCandidatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.listBoxCandidatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCandidatos.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.listBoxCandidatos.ForeColor = System.Drawing.Color.White;
            this.listBoxCandidatos.FormattingEnabled = true;
            this.listBoxCandidatos.IntegralHeight = false;
            this.listBoxCandidatos.ItemHeight = 32;
            this.listBoxCandidatos.Location = new System.Drawing.Point(26, 82);
            this.listBoxCandidatos.Name = "listBoxCandidatos";
            this.listBoxCandidatos.Size = new System.Drawing.Size(336, 359);
            this.listBoxCandidatos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Candidatos Disponíveis";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btCorrige);
            this.panel2.Controls.Add(this.btConfirmar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(480, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 459);
            this.panel2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(22, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(413, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Voto em Branco: Digite um número inexistente e confirme.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.lblnumero);
            this.panel3.Controls.Add(this.lblPartido);
            this.panel3.Controls.Add(this.lblNome);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(26, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 188);
            this.panel3.TabIndex = 10;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblnumero.Location = new System.Drawing.Point(13, 129);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(75, 21);
            this.lblnumero.TabIndex = 9;
            this.lblnumero.Text = "Número: ";
            this.lblnumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.BackColor = System.Drawing.Color.Transparent;
            this.lblPartido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPartido.Location = new System.Drawing.Point(13, 89);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(66, 21);
            this.lblPartido.TabIndex = 8;
            this.lblPartido.Text = "Partido: ";
            this.lblPartido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Location = new System.Drawing.Point(13, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 21);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome: ";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Informações do Candidato";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(22, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Voto Nulo: Digite \"00\" e confirme.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(22, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digite o número do seu candidato.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.txt.ForeColor = System.Drawing.Color.DarkGray;
            this.txt.Location = new System.Drawing.Point(26, 105);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(341, 52);
            this.txt.TabIndex = 8;
            this.txt.Text = "00";
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seu Voto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btVoltar.FlatAppearance.BorderSize = 2;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(1078, 669);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(116, 43);
            this.btVoltar.TabIndex = 16;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Green;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btConfirmar.FlatAppearance.BorderSize = 0;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.White;
            this.btConfirmar.Location = new System.Drawing.Point(455, 329);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(196, 48);
            this.btConfirmar.TabIndex = 15;
            this.btConfirmar.Text = "CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            // 
            // btCorrige
            // 
            this.btCorrige.BackColor = System.Drawing.Color.OrangeRed;
            this.btCorrige.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btCorrige.FlatAppearance.BorderSize = 0;
            this.btCorrige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCorrige.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCorrige.ForeColor = System.Drawing.Color.White;
            this.btCorrige.Location = new System.Drawing.Point(455, 262);
            this.btCorrige.Name = "btCorrige";
            this.btCorrige.Size = new System.Drawing.Size(196, 48);
            this.btCorrige.TabIndex = 16;
            this.btCorrige.Text = "CORRIGE";
            this.btCorrige.UseVisualStyleBackColor = false;
            // 
            // Votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Votacao";
            this.Text = "Votação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCandidatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCorrige;
    }
}