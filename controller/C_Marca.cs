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
    internal class C_Marca : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO marca (nomemarca) VALUES (@nomemarca)";
        string sqlApagar = "DELETE FROM marca WHERE codmarca = @codmarca";
        string sqlTodos = "SELECT * FROM marca";
        string sqlEditar = "update marca set nomemarca = @pnome where codmarca = @pcodmarca";
        string sqlBuscaNome = "select * from marca where nomemarca like @pnome";

        public void apagaDados(int codMarca)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codmarca", codMarca);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Marca apagado com sucesso!\nCódigo de Marca: " + codMarca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar marca!\nErro: " + ex.ToString());
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
            DataTable marcas = new DataTable();

            con.Open();

            try
            {
                da.Fill(marcas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return marcas;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable marcas = new DataTable();

            con.Open();

            try
            {
                da.Fill(marcas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar marcas!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return marcas;
        }

        public void insereDados(object obj)
        {
            Marca marca = obj as Marca;

            if (marca == null)
            {
                MessageBox.Show("Objeto Marca inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomemarca", marca.Nomemarca);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Marca incluído com sucesso");
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
            Marca marca = obj as Marca;

            if (marca == null)
            {
                MessageBox.Show("Objeto Marca inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", marca.Nomemarca);
            cmd.Parameters.AddWithValue("@pcodmarca", marca.Codmarca);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Marca alterado com sucesso");
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

