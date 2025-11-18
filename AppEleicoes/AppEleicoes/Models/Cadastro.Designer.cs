namespace AppEleicoes.Models
{
    partial class Cadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabelaCadastros = new System.Windows.Forms.DataGridView();
            this.NomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUrna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCadastros)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(392, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Candidatos";
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
            this.label2.Size = new System.Drawing.Size(391, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preencha os campos para registrar um novo candidato.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btLimpar);
            this.panel1.Controls.Add(this.btCadastrar);
            this.panel1.Controls.Add(this.txtPartido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUrna);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(56, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 459);
            this.panel1.TabIndex = 6;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(232, 335);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(196, 48);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar Campos";
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            this.btCadastrar.FlatAppearance.BorderSize = 2;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(25, 335);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(196, 48);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtPartido
            // 
            this.txtPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.txtPartido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPartido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartido.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPartido.Location = new System.Drawing.Point(232, 247);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(196, 29);
            this.txtPartido.TabIndex = 13;
            this.txtPartido.Text = "Ex: Partido Juntos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(228, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Partido";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNum.Location = new System.Drawing.Point(25, 247);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(196, 29);
            this.txtNum.TabIndex = 11;
            this.txtNum.Text = "Apenas números";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número do Candidato";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUrna
            // 
            this.txtUrna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.txtUrna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrna.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUrna.Location = new System.Drawing.Point(25, 153);
            this.txtUrna.Name = "txtUrna";
            this.txtUrna.Size = new System.Drawing.Size(403, 29);
            this.txtUrna.TabIndex = 9;
            this.txtUrna.Text = "Digite o nome para aparecer na urna.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome de Urna";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNome.Location = new System.Drawing.Point(25, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(403, 29);
            this.txtNome.TabIndex = 7;
            this.txtNome.Text = "Digite o nome completo do candidato.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Completo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.tabelaCadastros);
            this.panel2.Location = new System.Drawing.Point(555, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 459);
            this.panel2.TabIndex = 7;
            // 
            // tabelaCadastros
            // 
            this.tabelaCadastros.AllowUserToResizeColumns = false;
            this.tabelaCadastros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.tabelaCadastros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaCadastros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaCadastros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.tabelaCadastros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaCadastros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelaCadastros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaCadastros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaCadastros.ColumnHeadersHeight = 35;
            this.tabelaCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaCadastros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCompleto,
            this.NomeUrna,
            this.Numero,
            this.Partido});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaCadastros.DefaultCellStyle = dataGridViewCellStyle7;
            this.tabelaCadastros.EnableHeadersVisualStyles = false;
            this.tabelaCadastros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.tabelaCadastros.Location = new System.Drawing.Point(3, 5);
            this.tabelaCadastros.Name = "tabelaCadastros";
            this.tabelaCadastros.RowHeadersVisible = false;
            this.tabelaCadastros.RowTemplate.Height = 30;
            this.tabelaCadastros.Size = new System.Drawing.Size(633, 416);
            this.tabelaCadastros.TabIndex = 0;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NomeCompleto.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomeCompleto.HeaderText = "Nome Completo";
            this.NomeCompleto.Name = "NomeCompleto";
            this.NomeCompleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NomeUrna
            // 
            this.NomeUrna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NomeUrna.DefaultCellStyle = dataGridViewCellStyle4;
            this.NomeUrna.HeaderText = "Nome de Urna";
            this.NomeUrna.Name = "NomeUrna";
            this.NomeUrna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle5;
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Partido
            // 
            this.Partido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Partido.DefaultCellStyle = dataGridViewCellStyle6;
            this.Partido.HeaderText = "Partido";
            this.Partido.Name = "Partido";
            this.Partido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.btVoltar.TabIndex = 15;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // Cadastro
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
            this.Name = "Cadastro";
            this.Text = "Cadastro de Candidatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tabelaCadastros;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUrna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partido;
        private System.Windows.Forms.Button btVoltar;
    }
}