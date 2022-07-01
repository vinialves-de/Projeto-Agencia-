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
    public partial class TelaCadastrarCliente : Form
    {
        public TelaCadastrarCliente()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" | tbxEmail.Text == "" | tbxSenha.Text == "" | pbxImagem.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clientes.NomeCli = tbxNome.Text;
                Clientes.EmailCli = tbxEmail.Text;
                Clientes.SenhaCli = tbxSenha.Text;

                MemoryStream memoryStream = new MemoryStream();
                pbxImagem.Image.Save(memoryStream, pbxImagem.Image.RawFormat);
                Clientes.ImageCli = memoryStream.ToArray();

                ManipulaCliente manipulaClientes = new ManipulaCliente();
                manipulaClientes.cadastrarCliente();
            }
            if (Clientes.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else if (Clientes.Retorno == "Não")
            {
                fecharCadastro();
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg;*.jpeg;*.png";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
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
                else if (ctl is PictureBox)
                {
                    pbxImagem.Image = null;
                }
            }
        }

        private void TelaCadastrarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();

            }
        }
    }
}
