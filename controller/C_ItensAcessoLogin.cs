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
    internal class C_ItensAcessoLogin : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itensacessologin (codacesso_fk, codlogin_fk) VALUES (@codacesso, @codlogin)";
            string sqlApagar = "DELETE FROM itensacessologin WHERE codacesso_fk = @codacesso AND codlogin_fk = @codlogin";
            string sqlTodos = "SELECT * FROM itensacessologin";

            public void apagaDados(int codAcesso, int codLogin)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codacesso", codAcesso);
                cmd.Parameters.AddWithValue("@codlogin", codLogin);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Associação entre Acesso e Login apagada com sucesso!\nCódigo de Acesso: " + codAcesso + ", Código de Login: " + codLogin);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar associação entre Acesso e Login!\nErro: " + ex.ToString());
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
                DataTable itensAcessoLogin = new DataTable();

                con.Open();

                try
                {
                    da.Fill(itensAcessoLogin);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar associações entre Acesso e Login!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return itensAcessoLogin;
            }

            public void insereDados(object obj)
            {
                ItensAcessoLogin itensAcessoLogin = obj as ItensAcessoLogin;

                if (itensAcessoLogin == null)
                {
                    MessageBox.Show("Objeto ItensAcessoLogin inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codacesso", itensAcessoLogin.Acesso.Codacesso);
                cmd.Parameters.AddWithValue("@codlogin", itensAcessoLogin.Logins.Codlogin);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Associação entre Acesso e Login incluída com sucesso");
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
