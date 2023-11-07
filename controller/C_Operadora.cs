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
            string sqlApagar = "DELETE FROM operadora WHERE codoperadora = @Id";
            string sqlTodos = "SELECT * FROM operadora";

            public void apagaDados(int cod)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@Id", cod);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Operadora deletada com sucesso!\nCódigo: " + cod);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar Operadora!\nErro: " + ex.ToString());
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

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
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
                        MessageBox.Show("Operadora incluída com sucesso");
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
