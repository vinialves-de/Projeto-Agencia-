using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Controller;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaCadastrarVendas : Form
    {
        public TelaCadastrarVendas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxValor.Text == "" | tbxCliente.Text == "" | tbxFuncionario.Text == "" | tbxPacote.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Vendas.PagoVen = Convert.ToInt32(tbxValor.Text);
                Clientes.CodigoCli = Convert.ToInt32(tbxCliente.Text);
                Funcionario.CodigoFun = Convert.ToInt32(tbxFuncionario.Text);
                Pacotes.CodigoPac = Convert.ToInt32(tbxPacote.Text);

                ManipulaVendas manipulaVendas = new ManipulaVendas();
                manipulaVendas.cadastrarVenda();
            }
            if (Vendas.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else if (Vendas.Retorno == "Não")
            {
                fecharCadastro();
                return;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (tbxCliente.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCliente.Text = string.Empty;
                tbxCliente.Focus();
                tbxCliente.SelectAll();
            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCliente.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                tbxCliente.Text = Clientes.CodigoCli.ToString();
                tbxNomeCli.Text = Clientes.NomeCli;

            }
            if (Clientes.Retorno == "Não")
            {
                tbxCliente.Text = string.Empty;
                tbxCliente.Focus();
                tbxCliente.SelectAll();
                tbxNomeCli.Text = string.Empty;
                return;
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxFuncionario.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxFuncionario.Text = string.Empty;
                tbxFuncionario.Focus();
                tbxFuncionario.SelectAll();
            }
            else
            {
                Funcionario.CodigoFun = Convert.ToInt32(tbxFuncionario.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFuncionario();

                tbxFuncionario.Text = Funcionario.CodigoFun.ToString();
                tbxNomeFun.Text = Funcionario.NomeFun;

            }
            if (Funcionario.Retorno == "Não")
            {
                tbxFuncionario.Text = string.Empty;
                tbxFuncionario.Focus();
                tbxFuncionario.SelectAll();
                tbxNomeFun.Text = string.Empty;
                return;
            }
        }

        private void btnPacote_Click(object sender, EventArgs e)
        {
            if (tbxPacote.Text == "")
            {
                MessageBox.Show("Digite um código de pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxPacote.Text = string.Empty;
                tbxPacote.Focus();
                tbxPacote.SelectAll();
                tbxOrigem.Text = string.Empty;
                tbxDestino.Text = string.Empty;
            }
            else
            {
                Pacotes.CodigoPac = Convert.ToInt32(tbxPacote.Text);
                ManipulaPacotes manipulaPacote = new ManipulaPacotes();
                manipulaPacote.pesquisaCodPac();

                tbxPacote.Text = Pacotes.CodigoPac.ToString();
                tbxOrigem.Text = Pacotes.OrigemPac;
                tbxDestino.Text = Pacotes.DestinoPac;

            }
            if (Pacotes.Retorno == "Não")
            {
                tbxPacote.Text = string.Empty;
                tbxPacote.Focus();
                tbxPacote.SelectAll();
                tbxOrigem.Text = string.Empty;
                tbxDestino.Text = string.Empty;
                return;
            }
        }
        public void fecharCadastro()
        {
            this.Close();
        }

        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }
    }
}
