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
        internal class C_Acesso : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO acesso (nomeacesso) VALUES (@nomeacesso)";
            string sqlApagar = "DELETE FROM acesso WHERE codacesso = @codacesso";
            string sqlTodos = "SELECT * FROM acesso";
            string sqlEditar = "update acesso set nomeacesso = @pnome where codacesso = @pcodacesso";
            string sqlBuscaNome = "select * from acesso where nomeacesso like @pnome";

            public void apagaDados(int codAcesso)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codacesso", codAcesso);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Acesso apagado com sucesso!\nCódigo de Acesso: " + codAcesso);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar acesso!\nErro: " + ex.ToString());
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
                DataTable acessos = new DataTable();

                con.Open();

                try
                {
                    da.Fill(acessos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar acessos!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return acessos;
            }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor+"%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable acessos = new DataTable();

            con.Open();

            try
            {
                da.Fill(acessos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar acessos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return acessos;
        }

        public void insereDados(object obj)
            {
                Acesso acesso = obj as Acesso;

                if (acesso == null)
                {
                    MessageBox.Show("Objeto Acesso inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nomeacesso", acesso.Nomeacesso);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Acesso incluído com sucesso");
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

        public void editarDados(object obj)
        {
            Acesso acesso = obj as Acesso;

            if (acesso == null)
            {
                MessageBox.Show("Objeto Acesso inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", acesso.Nomeacesso);
            cmd.Parameters.AddWithValue("@pcodacesso", acesso.Codacesso);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Acesso alterado com sucesso");
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
