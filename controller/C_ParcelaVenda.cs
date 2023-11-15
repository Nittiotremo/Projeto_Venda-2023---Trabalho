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
        internal class C_ParcelaVenda : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO parcelavenda (datavencimento, valor, codsituacao_fk, codvenda_fk) VALUES (@datavencimento, @valor, @codsituacao, @codvenda)";
            string sqlApagar = "DELETE FROM parcelavenda WHERE codparcela = @codparcela";
            string sqlTodos = "SELECT * FROM parcelavenda";

            public void apagaDados(int codParcela)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codparcela", codParcela);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Parcela de venda apagada com sucesso!\nCódigo: " + codParcela);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar a parcela de venda!\nErro: " + ex.ToString());
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
                DataTable parcelasVenda = new DataTable();

                con.Open();

                try
                {
                    da.Fill(parcelasVenda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar as parcelas de venda!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return parcelasVenda;
            }

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
        }

        public void insereDados(object obj)
            {
                ParcelaVenda parcelaVenda = obj as ParcelaVenda;

                if (parcelaVenda == null)
                {
                    MessageBox.Show("Objeto ParcelaVenda inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@datavencimento", parcelaVenda.Datavencimento);
                cmd.Parameters.AddWithValue("@valor", parcelaVenda.Valor);
                cmd.Parameters.AddWithValue("@codsituacao", parcelaVenda.Situacao.Codsituacao);
                cmd.Parameters.AddWithValue("@codvenda", parcelaVenda.VendaProduto.Codvenda);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Parcela de venda incluída com sucesso");
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
