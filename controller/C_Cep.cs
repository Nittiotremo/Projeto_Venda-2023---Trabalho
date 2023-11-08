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
    internal class C_Cep : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO cep (nomecep) VALUES (@nomecep)";
        string sqlApagar = "DELETE FROM cep WHERE codcep = @codcep";
        string sqlTodos = "SELECT * FROM cep";
        string sqlEditar = "update cep set nomecep = @pnome where codcep = @pcodcep";
        string sqlBuscaNome = "select * from cep where nomecep like @pnome";

        public void apagaDados(int codCep)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codcep", codCep);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cep apagado com sucesso!\nCódigo de Cep: " + codCep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar cep!\nErro: " + ex.ToString());
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
            DataTable ceps = new DataTable();

            con.Open();

            try
            {
                da.Fill(ceps);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ceps!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return ceps;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ceps = new DataTable();

            con.Open();

            try
            {
                da.Fill(ceps);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ceps!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return ceps;
        }

        public void insereDados(object obj)
        {
            Cep cep = obj as Cep;

            if (cep == null)
            {
                MessageBox.Show("Objeto Cep inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomecep", cep.Numerocep);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cep incluído com sucesso");
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
            Cep cep = obj as Cep;

            if (cep == null)
            {
                MessageBox.Show("Objeto Cep inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", cep.Numerocep);
            cmd.Parameters.AddWithValue("@pcodcep", cep.Codcep);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cep alterado com sucesso");
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
