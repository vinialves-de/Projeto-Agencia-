using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;
using System.IO;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCod.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                tbxCod.Text = Clientes.CodigoCli.ToString();
                tbxNome.Text = Clientes.NomeCli;
                tbxEmail.Text = Clientes.EmailCli;
                tbxSenha.Text = Clientes.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Clientes.ImageCli);
                pbxImagem.Image = Image.FromStream(ms);
                
            }
            if (Clientes.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pbxImagem.Image = null;
                return;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pbxImagem.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Cliente " + tbxCod.Text + "?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCli = Convert.ToInt32(tbxCod.Text);

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.deletarCliente();
                }

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pbxImagem.Image = null;
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pbxImagem.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja Alterar os dados do Cliente " + tbxCod.Text + "?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCli = Convert.ToInt32(tbxCod.Text);
                    Clientes.NomeCli = tbxNome.Text;
                    Clientes.EmailCli = tbxEmail.Text;
                    Clientes.SenhaCli = tbxSenha.Text;

                    MemoryStream ms = new MemoryStream();
                    pbxImagem.Image.Save(ms,pbxImagem.Image.RawFormat);

                    Clientes.ImageCli = ms.ToArray();

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.alterarCliente();
                }
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg;*.jpeg;*.png";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }

        private void btnBuscarNomeCli_Click(object sender, EventArgs e)
        {
            if (tbxNomeCli.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Clientes.NomeCli = tbxNomeCli.Text;

            dataGridViewCliente.DataSource = ManipulaCliente.pesquisarNomeCliente();

            dataGridViewCliente.Columns[0].Visible = false;
            dataGridViewCliente.Columns[1].Visible = false;
            dataGridViewCliente.Columns[2].Visible = false;
            dataGridViewCliente.Columns[3].Visible = false;
            dataGridViewCliente.Columns[4].HeaderCell.Value = "Código";
            dataGridViewCliente.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewCliente.Columns[6].HeaderCell.Value = "E-mail";
            dataGridViewCliente.Columns[7].Visible = false;
            dataGridViewCliente.Columns[8].HeaderCell.Value = "Foto";


        }
    }
}
