namespace AppEleicoes
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btVotacao = new System.Windows.Forms.Button();
            this.btApuracao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Eleições Interativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btCadastro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btCadastro.FlatAppearance.BorderSize = 2;
            this.btCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btCadastro.ForeColor = System.Drawing.Color.White;
            this.btCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btCadastro.Image")));
            this.btCadastro.Location = new System.Drawing.Point(215, 290);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btCadastro.Size = new System.Drawing.Size(265, 150);
            this.btCadastro.TabIndex = 1;
            this.btCadastro.Text = "Cadastro de Candidatos";
            this.btCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btVotacao
            // 
            this.btVotacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btVotacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.btVotacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btVotacao.FlatAppearance.BorderSize = 2;
            this.btVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVotacao.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btVotacao.ForeColor = System.Drawing.Color.White;
            this.btVotacao.Image = ((System.Drawing.Image)(resources.GetObject("btVotacao.Image")));
            this.btVotacao.Location = new System.Drawing.Point(496, 290);
            this.btVotacao.Name = "btVotacao";
            this.btVotacao.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btVotacao.Size = new System.Drawing.Size(265, 150);
            this.btVotacao.TabIndex = 2;
            this.btVotacao.Text = "Votação";
            this.btVotacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btVotacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btVotacao.UseMnemonic = false;
            this.btVotacao.UseVisualStyleBackColor = false;
            this.btVotacao.Click += new System.EventHandler(this.btVotacao_Click);
            // 
            // btApuracao
            // 
            this.btApuracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btApuracao.Cursor = System.Windows.Forms.Cursors.Default;
            this.btApuracao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btApuracao.FlatAppearance.BorderSize = 2;
            this.btApuracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApuracao.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btApuracao.ForeColor = System.Drawing.Color.White;
            this.btApuracao.Image = ((System.Drawing.Image)(resources.GetObject("btApuracao.Image")));
            this.btApuracao.Location = new System.Drawing.Point(776, 290);
            this.btApuracao.Name = "btApuracao";
            this.btApuracao.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btApuracao.Size = new System.Drawing.Size(265, 150);
            this.btApuracao.TabIndex = 3;
            this.btApuracao.Text = "Apuração dos Votos";
            this.btApuracao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btApuracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btApuracao.UseVisualStyleBackColor = false;
            this.btApuracao.Click += new System.EventHandler(this.btApuracao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(433, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Simulação Eleitoral Acadêmica por Isabelly Cristina e Nicoly Silva";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btApuracao);
            this.Controls.Add(this.btVotacao);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label1);
            this.Name = "Sistema";
            this.Text = "Sistema de Eleições";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btCadastro;
        internal System.Windows.Forms.Button btVotacao;
        internal System.Windows.Forms.Button btApuracao;
        private System.Windows.Forms.Label label2;
    }
}

