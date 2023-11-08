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
    internal class C_Bairro : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO bairro (nomebairro) VALUES (@nomebairro)";
        string sqlApagar = "DELETE FROM bairro WHERE codbairro = @codbairro";
        string sqlTodos = "SELECT * FROM bairro";
        string sqlEditar = "update bairro set nomebairro = @pnome where codbairro = @pcodbairro";
        string sqlBuscaNome = "select * from bairro where nomebairro like @pnome";

        public void apagaDados(int codBairro)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codbairro", codBairro);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Bairro apagado com sucesso!\nCódigo de Bairro: " + codBairro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar bairro!\nErro: " + ex.ToString());
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
            DataTable bairros = new DataTable();

            con.Open();

            try
            {
                da.Fill(bairros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar bairros!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return bairros;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable bairros = new DataTable();

            con.Open();

            try
            {
                da.Fill(bairros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar bairros!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return bairros;
        }

        public void insereDados(object obj)
        {
            Bairro bairro = obj as Bairro;

            if (bairro == null)
            {
                MessageBox.Show("Objeto Bairro inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomebairro", bairro.Nomebairro);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Bairro incluído com sucesso");
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
            Bairro bairro = obj as Bairro;

            if (bairro == null)
            {
                MessageBox.Show("Objeto Bairro inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", bairro.Nomebairro);
            cmd.Parameters.AddWithValue("@pcodbairro", bairro.Codbairro);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Bairro alterado com sucesso");
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
