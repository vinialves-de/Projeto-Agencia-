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
    public partial class TelaCadastrarPacote : Form
    {
        public TelaCadastrarPacote()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxValor.Text == "" | cmbOrigem.Text == "" | cmbDestino.Text == "" | pbxImagem.Image == null | dtpIda.Value > dtpVolta.Value | rtbDescricao == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                Pacotes.ValorPac = Convert.ToDouble(tbxValor.Text);
                Pacotes.OrigemPac = cmbOrigem.Text;
                Pacotes.DestinoPac = cmbDestino.Text;
                Pacotes.DataidaPac = dtpIda.Value;
                Pacotes.DatavoltaPac = dtpVolta.Value;
                Pacotes.DescricaoPac = rtbDescricao.Text;

                MemoryStream memoryStream = new MemoryStream();
                pbxImagem.Image.Save(memoryStream, pbxImagem.Image.RawFormat);
                Pacotes.ImagePac = memoryStream.ToArray();

                ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                manipulaPacotes.cadastrarPacote();

            }
            if (Pacotes.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else if (Pacotes.Retorno == "Não")
            {
                fecharCadastro();
                return;
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
                else if (ctl is ComboBox)
                {
                    cmbDestino = null;
                    cmbOrigem = null;
                }
            }
        }

        private void TelaCadastrarPacote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }
    }
}
