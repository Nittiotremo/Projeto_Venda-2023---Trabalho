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
        internal class C_Loja : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO loja (nomeloja, cnpj, nomefantasia, razaosocial) " +
                "VALUES (@nomeloja, @cnpj, @nomefantasia, @razaosocial)";
            string sqlApagar = "DELETE FROM loja WHERE codloja = @codloja";
            string sqlTodos = "SELECT * FROM loja";

            public void apagaDados(int codLoja)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codloja", codLoja);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Loja apagada com sucesso!\nCódigo: " + codLoja);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar loja!\nErro: " + ex.ToString());
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
                DataTable lojas = new DataTable();

                con.Open();

                try
                {
                    da.Fill(lojas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar lojas!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return lojas;
            }

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
        }

        public void insereDados(object obj)
            {
                Loja loja = obj as Loja;

                if (loja == null)
                {
                    MessageBox.Show("Objeto Loja inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nomeloja", loja.Nomeloja);
                cmd.Parameters.AddWithValue("@cnpj", loja.Cnpj);
                cmd.Parameters.AddWithValue("@nomefantasia", loja.Nomefantasia);
                cmd.Parameters.AddWithValue("@razaosocial", loja.Razaosocial);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Loja incluída com sucesso");
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
