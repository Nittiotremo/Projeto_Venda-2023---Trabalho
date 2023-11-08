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
    internal class C_Rua : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO rua (nomerua) VALUES (@nomerua)";
        string sqlApagar = "DELETE FROM rua WHERE codrua = @codrua";
        string sqlTodos = "SELECT * FROM rua";
        string sqlEditar = "update rua set nomerua = @pnome where codrua = @pcodrua";
        string sqlBuscaNome = "select * from rua where nomerua like @pnome";

        public void apagaDados(int codRua)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codrua", codRua);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Rua apagado com sucesso!\nCódigo de Rua: " + codRua);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar rua!\nErro: " + ex.ToString());
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
            DataTable ruas = new DataTable();

            con.Open();

            try
            {
                da.Fill(ruas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ruas!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return ruas;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ruas = new DataTable();

            con.Open();

            try
            {
                da.Fill(ruas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ruas!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return ruas;
        }

        public void insereDados(object obj)
        {
            Rua rua = obj as Rua;

            if (rua == null)
            {
                MessageBox.Show("Objeto Rua inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomerua", rua.Nomerua);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Rua incluído com sucesso");
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
            Rua rua = obj as Rua;

            if (rua == null)
            {
                MessageBox.Show("Objeto Rua inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", rua.Nomerua);
            cmd.Parameters.AddWithValue("@pcodrua", rua.Codrua);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Rua alterado com sucesso");
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
