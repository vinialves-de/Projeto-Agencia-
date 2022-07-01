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
    public partial class TelaPesquisarFuncionario : Form
    {
        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCod_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                Funcionario.CodigoFun = Convert.ToInt32(tbxCod.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFuncionario();

                tbxCod.Text = Funcionario.CodigoFun.ToString();
                tbxNome.Text = Funcionario.NomeFun;
                tbxEmail.Text = Funcionario.EmailFun;
                tbxSenha.Text = Funcionario.SenhaFun;

            }
            if (Funcionario.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                return;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Funcionário " + tbxCod.Text + "?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodigoFun = Convert.ToInt32(tbxCod.Text);

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.deletarFuncionario();
                }

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do Funcionário " + tbxCod.Text + "?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodigoFun = Convert.ToInt32(tbxCod.Text);
                    Funcionario.NomeFun = tbxNome.Text;
                    Funcionario.EmailFun = tbxEmail.Text;
                    Funcionario.SenhaFun = tbxSenha.Text;

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.alterarFuncionario();
                }

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                return;
            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (tbxNomeCli.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Funcionario.NomeFun = tbxNome.Text;

            dataGridViewCliente.DataSource = ManipulaFuncionario.pesquisarNomeFuncionario();

            dataGridViewCliente.Columns[0].Visible = false;
            dataGridViewCliente.Columns[1].Visible = false;
            dataGridViewCliente.Columns[2].Visible = false;
            dataGridViewCliente.Columns[3].Visible = false;
            dataGridViewCliente.Columns[4].HeaderCell.Value = "Código";
            dataGridViewCliente.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewCliente.Columns[6].HeaderCell.Value = "E-mail";
        }
    }
}
