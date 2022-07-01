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
    class ManipulaVendas
    {
        public void cadastrarVenda()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@pagoVen", Vendas.PagoVen);
                cmd.Parameters.AddWithValue("@codigoCliFK", Clientes.CodigoCli);
                cmd.Parameters.AddWithValue("@codigoFunFK", Funcionario.CodigoFun);
                cmd.Parameters.AddWithValue("@codigoPacFK", Pacotes.CodigoPac);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoVen", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do Venda efetuado com sucesso, deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                    );

                if (resposta == DialogResult.Yes)
                {
                    Vendas.Retorno = "Sim";
                    return;
                }
                else
                {
                    Vendas.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }
        public void pesquisaCodVen()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoVen", Vendas.CodigoVen);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Vendas.CodigoVen = Convert.ToInt32(arrayDados["codigoVen"]);
                    Vendas.PagoVen = Convert.ToInt32(arrayDados["pagoVen"]);
                    Clientes.CodigoCli = Convert.ToInt32(arrayDados["codigoCliFK"]);
                    Funcionario.CodigoFun = Convert.ToInt32(arrayDados["codigoFunFK"]);
                    Pacotes.CodigoPac = Convert.ToInt32(arrayDados["codigoPacFK"]);
                    Vendas.Retorno = "Sim";
                }

                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Vendas.Retorno = "Não";
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarVen()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoVen", Vendas.CodigoVen);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O Venda não pôde ser excluido.");
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarVen()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarVenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoVen", Vendas.CodigoVen);
                cmd.Parameters.AddWithValue("@pagoVen", Vendas.PagoVen);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda alterado com sucesso" +Vendas.PagoVen + Vendas.CodigoVen, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "A Venda não foi alterada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
    }
}

