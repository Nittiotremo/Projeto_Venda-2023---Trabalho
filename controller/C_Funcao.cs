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
    internal class C_Funcao : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO funcao (nomefuncao) VALUES (@nomefuncao)";
        string sqlApagar = "DELETE FROM funcao WHERE codfuncao = @codfuncao";
        string sqlTodos = "SELECT * FROM funcao";
        string sqlEditar = "update funcao set nomefuncao = @pnome where codfuncao = @pcodfuncao";
        string sqlBuscaNome = "select * from funcao where nomefuncao like @pnome";

        public void apagaDados(int codFuncao)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codfuncao", codFuncao);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Funcao apagado com sucesso!\nCódigo de Funcao: " + codFuncao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar funcao!\nErro: " + ex.ToString());
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
            DataTable funcaos = new DataTable();

            con.Open();

            try
            {
                da.Fill(funcaos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar funcaos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return funcaos;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable funcaos = new DataTable();

            con.Open();

            try
            {
                da.Fill(funcaos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar funcaos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return funcaos;
        }

        public void insereDados(object obj)
        {
            Funcao funcao = obj as Funcao;

            if (funcao == null)
            {
                MessageBox.Show("Objeto Funcao inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomefuncao", funcao.Nomefuncao);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Funcao incluído com sucesso");
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
            Funcao funcao = obj as Funcao;

            if (funcao == null)
            {
                MessageBox.Show("Objeto Funcao inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", funcao.Nomefuncao);
            cmd.Parameters.AddWithValue("@pcodfuncao", funcao.Codfuncao);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Funcao alterado com sucesso");
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
