using Projeto_Venda_2023.conexao;
using Projeto_Venda_2023.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Venda_2023.controller
    {
        internal class C_ParcelaCompra : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO parcelacompra (datavencimento, valor, codsituacao_fk, codcompra_fk) VALUES (@datavencimento, @valor, @CodSituacao, @CodCompra)";
            string sqlApagar = "DELETE FROM parcelacompra WHERE codparcelacompra = @codparcelacompra";
            string sqlTodos = "SELECT * FROM parcelacompra";

            public void apagaDados(int codParcelaCompra)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codparcelacompra", codParcelaCompra);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Parcela de compra apagada com sucesso!\nCódigo: " + codParcelaCompra);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar a parcela de compra!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

            public DataTable buscarTodos()
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlTodos, con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable parcelasCompra = new DataTable();

                con.Open();

                try
                {
                    da.Fill(parcelasCompra);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar parcelas de compra!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return parcelasCompra;
            }

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
        }

        public void insereDados(object obj)
            {
                ParcelaCompra parcelaCompra = obj as ParcelaCompra;

                if (parcelaCompra == null)
                {
                    MessageBox.Show("Objeto ParcelaCompra inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@datavencimento", parcelaCompra.Datavencimento);
                cmd.Parameters.AddWithValue("@valor", parcelaCompra.Valor);
                cmd.Parameters.AddWithValue("@codsituacao", parcelaCompra.Situacao.Codsituacao);
                cmd.Parameters.AddWithValue("@codcompra", parcelaCompra.CompraProduto.Codcompra);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Parcela de compra incluída com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
