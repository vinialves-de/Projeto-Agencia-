using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaCadastroFuncionario : Form
    {
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" | tbxEmail.Text == "" | tbxSenha.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Funcionario.NomeFun = tbxNome.Text;
                Funcionario.EmailFun = tbxEmail.Text;
                Funcionario.SenhaFun = tbxSenha.Text;

                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.cadastrarFuncionario();
            }
            if (Funcionario.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else if (Funcionario.Retorno == "Não")
            {
                fecharCadastro();
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

        private void btnSalvar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();

            }
        }
    }
}
