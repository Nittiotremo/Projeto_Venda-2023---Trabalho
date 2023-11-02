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
    internal class C_ItensTelCliente : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itenstelcliente (codtelefone_fk, codcliente_fk) VALUES (@codtelefone, @codcliente)";
            string sqlApagar = "DELETE FROM itenstelcliente WHERE codtelefone_fk = @codTelefone AND codcliente_fk = @codcliente";
            string sqlTodos = "SELECT * FROM itenstelcliente";

            public void apagaDados(int codTelefone, int codCliente)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codtelefone", codTelefone);
                cmd.Parameters.AddWithValue("@codcliente", codCliente);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Relação entre telefone e cliente apagada com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar relação entre telefone e cliente!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

        public void apagaDados(int cod)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarTodos()
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlTodos, con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable relacoes = new DataTable();

                con.Open();

                try
                {
                    da.Fill(relacoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar relações entre telefone e cliente!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return relacoes;
            }

            public void insereDados(object obj)
            {
                ItensTelCliente relacao = obj as ItensTelCliente;

                if (relacao == null)
                {
                    MessageBox.Show("Objeto de relação telefone-cliente inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codtelefone", relacao.Telefone.Codtelefone);
                cmd.Parameters.AddWithValue("@codcliente", relacao.Cliente.Codcliente);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Relação entre telefone e cliente incluída com sucesso");
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
