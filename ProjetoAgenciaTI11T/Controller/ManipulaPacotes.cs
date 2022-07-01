using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaPacotes
    {
        public void cadastrarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac", Pacotes.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPac);
                cmd.Parameters.AddWithValue("@dataidaPac", Pacotes.DataidaPac);
                cmd.Parameters.AddWithValue("@datavoltaPac", Pacotes.DatavoltaPac);
                cmd.Parameters.AddWithValue("@descricaoPac", Pacotes.DescricaoPac);
                cmd.Parameters.AddWithValue("@imagemPac", Pacotes.ImagePac);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoPac", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do pacote efetuado com sucesso, deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation
                    );

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacotes.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }
        public void pesquisaCodPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPac", Pacotes.CodigoPac);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Pacotes.CodigoPac = Convert.ToInt32(arrayDados["codigoPac"]);
                    Pacotes.ValorPac = Convert.ToInt32(arrayDados["valorPac"]);
                    Pacotes.OrigemPac = arrayDados["origemPac"].ToString();
                    Pacotes.DestinoPac = arrayDados["destinoPac"].ToString();
                    Pacotes.DataidaPac = Convert.ToDateTime(arrayDados["dataidaPac"]);
                    Pacotes.DatavoltaPac = Convert.ToDateTime(arrayDados["datavoltaPac"]);
                    Pacotes.DescricaoPac = arrayDados["descricaoPac"].ToString();
                    Pacotes.ImagePac = (Array)arrayDados["imagemPac"];
                    Pacotes.Retorno = "Sim";
                }

                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pacotes.Retorno = "Não";
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPac", Pacotes.CodigoPac);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O pacote não pôde ser excluido.");
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPacotes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPac", Pacotes.CodigoPac);
                cmd.Parameters.AddWithValue("@valorPac", Pacotes.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPac);
                cmd.Parameters.AddWithValue("@dataidaPac", Pacotes.DataidaPac);
                cmd.Parameters.AddWithValue("@datavoltaPac", Pacotes.DatavoltaPac);
                cmd.Parameters.AddWithValue("@descricaoPac", Pacotes.DescricaoPac);
                cmd.Parameters.AddWithValue("@imagemPac", Pacotes.ImagePac);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O pacote não foi alterado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisaOrigemPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaOrigemPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigemPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }

        public static BindingSource pesquisaDestinoPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaDestinoPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
