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
    internal class C_Trabalho : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO trabalho (nometrabalho) VALUES (@nometrabalho)";
        string sqlApagar = "DELETE FROM trabalho WHERE codtrabalho = @codtrabalho";
        string sqlTodos = "SELECT * FROM trabalho";
        string sqlEditar = "update trabalho set nometrabalho = @pnome where codtrabalho = @pcodtrabalho";
        string sqlBuscaNome = "select * from trabalho where nometrabalho like @pnome";

        public void apagaDados(int codTrabalho)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codtrabalho", codTrabalho);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Trabalho apagado com sucesso!\nCódigo de Trabalho: " + codTrabalho);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar trabalho!\nErro: " + ex.ToString());
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
            DataTable trabalhos = new DataTable();

            con.Open();

            try
            {
                da.Fill(trabalhos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar trabalhos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return trabalhos;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable trabalhos = new DataTable();

            con.Open();

            try
            {
                da.Fill(trabalhos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar trabalhos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return trabalhos;
        }

        public void insereDados(object obj)
        {
            Trabalho trabalho = obj as Trabalho;

            if (trabalho == null)
            {
                MessageBox.Show("Objeto Trabalho inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nometrabalho", trabalho.Nometrabalho);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Trabalho incluído com sucesso");
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
            Trabalho trabalho = obj as Trabalho;

            if (trabalho == null)
            {
                MessageBox.Show("Objeto Trabalho inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", trabalho.Nometrabalho);
            cmd.Parameters.AddWithValue("@pcodtrabalho", trabalho.Codtrabalho);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Trabalho alterado com sucesso");
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
