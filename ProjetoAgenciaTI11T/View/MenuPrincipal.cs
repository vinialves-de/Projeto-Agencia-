using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarCliente cliente = new TelaCadastrarCliente();
            cliente.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionario funcionario = new TelaCadastroFuncionario();
            funcionario.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCadastrarPacote pacote = new TelaCadastrarPacote();
            pacote.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarVendas vendas = new TelaCadastrarVendas();
            vendas.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarCliente pesquisarCliente = new TelaPesquisarCliente();
            pesquisarCliente.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisarFuncionario pesquisarFuncionario = new TelaPesquisarFuncionario();
            pesquisarFuncionario.Show();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaPesquisarPacotes pesquisarPacote = new TelaPesquisarPacotes();
            pesquisarPacote.Show();
        }

        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaPesquisarVendas pesquisarVendas = new TelaPesquisarVendas();
            pesquisarVendas.Show();
        }
    }
}
