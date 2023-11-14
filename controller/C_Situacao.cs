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
    internal class C_Situacao : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO situacao (nomesituacao) VALUES (@nomesituacao)";
        string sqlApagar = "DELETE FROM situacao WHERE codsituacao = @codsituacao";
        string sqlTodos = "SELECT * FROM situacao";
        string sqlEditar = "update situacao set nomesituacao = @pnome where codsituacao = @pcodsituacao";
        string sqlBuscaNome = "select * from situacao where nomesituacao like @pnome";

        public void apagaDados(int codSituacao)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codsituacao", codSituacao);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Situacao apagado com sucesso!\nCódigo de Situacao: " + codSituacao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar situacao!\nErro: " + ex.ToString());
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
            DataTable situacaos = new DataTable();

            con.Open();

            try
            {
                da.Fill(situacaos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar situacaos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return situacaos;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable situacaos = new DataTable();

            con.Open();

            try
            {
                da.Fill(situacaos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar situacaos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return situacaos;
        }

        public void insereDados(object obj)
        {
            Situacao situacao = obj as Situacao;

            if (situacao == null)
            {
                MessageBox.Show("Objeto Situacao inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomesituacao", situacao.Nomesituacao);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Situacao incluído com sucesso");
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
            Situacao situacao = obj as Situacao;

            if (situacao == null)
            {
                MessageBox.Show("Objeto Situacao inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", situacao.Nomesituacao);
            cmd.Parameters.AddWithValue("@pcodsituacao", situacao.Codsituacao);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Situacao alterado com sucesso");
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