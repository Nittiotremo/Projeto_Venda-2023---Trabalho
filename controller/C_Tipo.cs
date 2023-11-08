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
        internal class C_Tipo : I_CRUD
        {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO tipo (nometipo) VALUES (@nometipo)";
        string sqlApagar = "DELETE FROM tipo WHERE codtipo = @codtipo";
        string sqlTodos = "SELECT * FROM tipo";
        string sqlEditar = "update tipo set nometipo = @pnome where codtipo = @pcodtipo";
        string sqlBuscaNome = "select * from tipo where nometipo like @pnome";

        public void apagaDados(int codTipo)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codtipo", codTipo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo apagado com sucesso!\nCódigo de Tipo: " + codTipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar tipo!\nErro: " + ex.ToString());
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
            DataTable tipos = new DataTable();

            con.Open();

            try
            {
                da.Fill(tipos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return tipos;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tipos = new DataTable();

            con.Open();

            try
            {
                da.Fill(tipos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar tipos!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return tipos;
        }

        public void insereDados(object obj)
        {
            Tipo tipo = obj as Tipo;

            if (tipo == null)
            {
                MessageBox.Show("Objeto Tipo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nometipo", tipo.Nometipo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo incluído com sucesso");
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
            Tipo tipo = obj as Tipo;

            if (tipo == null)
            {
                MessageBox.Show("Objeto Tipo inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", tipo.Nometipo);
            cmd.Parameters.AddWithValue("@pcodtipo", tipo.Codtipo);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Tipo alterado com sucesso");
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
