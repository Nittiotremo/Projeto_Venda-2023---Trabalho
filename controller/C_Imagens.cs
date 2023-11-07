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
        internal class C_Imagens : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO imagens (imagem, descricao, codproduto_fk) VALUES (@imagem, @descricao, @codproduto)";
            string sqlApagar = "DELETE FROM imagens WHERE codimagem = @codimagem";
            string sqlTodos = "SELECT * FROM imagens";

            public void apagaDados(int codImagem)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codimagem", codImagem);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Imagem apagada com sucesso!\nCódigo: " + codImagem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar a imagem!\nErro: " + ex.ToString());
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
                DataTable imagens = new DataTable();

                con.Open();

                try
                {
                    da.Fill(imagens);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar as imagens!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return imagens;
            }

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
        }

        public void insereDados(object obj)
            {
                Imagens imagens = obj as Imagens;

                if (imagens == null)
                {
                    MessageBox.Show("Objeto Imagens inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@imagem", imagens.Imagem);
                cmd.Parameters.AddWithValue("@descricao", imagens.Descricao);
                cmd.Parameters.AddWithValue("@codproduto", imagens.Produto.Codproduto);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Imagem incluída com sucesso");
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
