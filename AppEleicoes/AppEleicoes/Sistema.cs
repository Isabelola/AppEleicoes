using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEleicoes.Models;

namespace AppEleicoes
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Sistema_Load(object sender, EventArgs e)
        {

        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void btVotacao_Click(object sender, EventArgs e)
        {
            Votacao votacao = new Votacao();
            votacao.ShowDialog();
        }

        private void btApuracao_Click(object sender, EventArgs e)
        {
            Apuracao apuracao = new Apuracao();
            apuracao.ShowDialog();
        }
    }
}
