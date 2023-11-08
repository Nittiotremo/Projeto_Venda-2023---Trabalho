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
        internal class C_Operadora : I_CRUD
        {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInserir = "INSERT INTO operadora (nomeoperadora) VALUES (@nomeoperadora)";
        string sqlApagar = "DELETE FROM operadora WHERE codoperadora = @codoperadora";
        string sqlTodos = "SELECT * FROM operadora";
        string sqlEditar = "update operadora set nomeoperadora = @pnome where codoperadora = @pcodoperadora";
        string sqlBuscaNome = "select * from operadora where nomeoperadora like @pnome";

        public void apagaDados(int codOperadora)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            cmd.Parameters.AddWithValue("@codoperadora", codOperadora);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Operadora apagado com sucesso!\nCódigo de Operadora: " + codOperadora);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar operadora!\nErro: " + ex.ToString());
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
            DataTable operadoras = new DataTable();

            con.Open();

            try
            {
                da.Fill(operadoras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar operadoras!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return operadoras;
        }

        public DataTable buscarNome(String valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlBuscaNome, con);

            cmd.Parameters.AddWithValue("@pnome", valor + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable operadoras = new DataTable();

            con.Open();

            try
            {
                da.Fill(operadoras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar operadoras!\nErro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return operadoras;
        }

        public void insereDados(object obj)
        {
            Operadora operadora = obj as Operadora;

            if (operadora == null)
            {
                MessageBox.Show("Objeto Operadora inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInserir, con);

            cmd.Parameters.AddWithValue("@nomeoperadora", operadora.Nomeoperadora);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Operadora incluído com sucesso");
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
            Operadora operadora = obj as Operadora;

            if (operadora == null)
            {
                MessageBox.Show("Objeto Operadora inválido.");
                return;
            }

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlEditar, con);

            cmd.Parameters.AddWithValue("@pnome", operadora.Nomeoperadora);
            cmd.Parameters.AddWithValue("@pcodoperadora", operadora.Codoperadora);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Operadora alterado com sucesso");
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
