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
        internal class C_Produto : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO produto (nomeproduto, quantidade, valor, codmarca_fk, codtipo_fk) " +
                "VALUES (@nomeproduto, @quantidade, @valor, @codmarca, @codtipo)";
            string sqlApagar = "DELETE FROM produto WHERE codproduto = @codproduto";
            string sqlTodos = "SELECT * FROM produto";

            public void apagaDados(int codProduto)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codproduto", codProduto);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Produto apagado com sucesso!\nCódigo do Produto: " + codProduto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar o Produto!\nErro: " + ex.ToString());
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
                DataTable produtos = new DataTable();

                con.Open();

                try
                {
                    da.Fill(produtos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar Produtos!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return produtos;
            }

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
        }

        public void insereDados(object obj)
            {
                Produto produto = obj as Produto;

                if (produto == null)
                {
                    MessageBox.Show("Objeto Produto inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nomeproduto", produto.Nomeproduto);
                cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                cmd.Parameters.AddWithValue("@valor", produto.Valor);
                cmd.Parameters.AddWithValue("@codmarca", produto.Marca.Codmarca);
                cmd.Parameters.AddWithValue("@codtipo", produto.Tipo.Codtipo);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Produto incluído com sucesso");
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
