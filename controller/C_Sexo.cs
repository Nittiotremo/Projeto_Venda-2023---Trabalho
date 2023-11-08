using Projeto_Venda_2023.conexao;
using Projeto_Venda_2023.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Venda_2023.controller
{
    internal class C_Sexo : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO sexo (nomesexo) VALUES (@nomesexo)";
        string sqlApagar = "DELETE FROM sexo WHERE codsexo = @codsexo";
        string sqlTodos = "SELECT * FROM sexo";
        string sqlEditar = "update sexo set nomesexo = @pnome where codsexo = @pcodsexo";
        string sqlBuscaNome = "select * from sexo where nomesexo like @pnome";

        public void apagaDados(int codSexo)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codsexo", codSexo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sexo apagado com sucesso!\nCódigo de Sexo: " + codSexo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar sexo!\nErro: " + ex.ToString());
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
            DataTable sexos = new DataTable();

            con.Open();

            try
            {
                da.Fill(sexos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar sexos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return sexos;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable sexos = new DataTable();

            con.Open();

            try
            {
                da.Fill(sexos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar sexos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return sexos;
        }

        public void insereDados(object obj)
        {
            Sexo sexo = obj as Sexo;

            if (sexo == null)
            {
                MessageBox.Show("Objeto Sexo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomesexo", sexo.Nomesexo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sexo incluído com sucesso");
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
            Sexo sexo = obj as Sexo;

            if (sexo == null)
            {
                MessageBox.Show("Objeto Sexo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", sexo.Nomesexo);
            cmd.Parameters.AddWithValue("@pcodsexo", sexo.Codsexo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sexo alterado com sucesso");
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
