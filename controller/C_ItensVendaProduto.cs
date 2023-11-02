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
        internal class C_ItensVendaProduto : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itensvendaproduto (codvenda_fk, codproduto_fk, quantidade, valor) VALUES (@codvenda, @codproduto, @quantidade, @valor)";
            string sqlApagar = "DELETE FROM itensvendaproduto WHERE coditensvenda = @coditensvenda";
            string sqlTodos = "SELECT * FROM itensvendaproduto";

            public void apagaDados(int codItensVenda)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@coditensvenda", codItensVenda);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Itens de venda de produto apagados com sucesso!\nCódigo: " + codItensVenda);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar os itens de venda de produto!\nErro: " + ex.ToString());
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
                DataTable itensVendaProduto = new DataTable();

                con.Open();

                try
                {
                    da.Fill(itensVendaProduto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar os itens de venda de produto!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return itensVendaProduto;
            }

            public void insereDados(object obj)
            {
                ItensVendaProduto itensVendaProduto = obj as ItensVendaProduto;

                if (itensVendaProduto == null)
                {
                    MessageBox.Show("Objeto ItensVendaProduto inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codvenda", itensVendaProduto.VendaProduto.Codvenda);
                cmd.Parameters.AddWithValue("@codproduto", itensVendaProduto.Produto.Codproduto);
                cmd.Parameters.AddWithValue("@quantidade", itensVendaProduto.Quantidade);
                cmd.Parameters.AddWithValue("@valor", itensVendaProduto.Valor);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Itens de venda de produto incluídos com sucesso");
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
