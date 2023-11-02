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
        internal class C_Cliente : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInsere = "INSERT INTO cliente (nomecliente, foto, datanasc, codsexo_fk, codrua_fk, codbairro_fk, codcep_fk, " +
            "codcidade_fk, salario, codtrabalho_fk, numerocasa) " +
                "VALUES (@nomecliente, @foto, @datanasc, @codsexo, @codrua, @codbairro, @codcep, @codcidade, @salario, @codtrabalho, " +
            "@Numerocasa)";
            string sqlApagar = "DELETE FROM cliente WHERE codcliente = @Id";
            string sqlTodos = "SELECT * FROM cliente";

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
                        MessageBox.Show("Cliente deletado com sucesso!\nCódigo: " + cod);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Apagar!\nErro: " + ex.ToString());
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
                DataTable clientes = new DataTable();

                con.Open();

                try
                {
                    da.Fill(clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar clientes!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return clientes;
            }

            public void insereDados(object obj)
            {
                Cliente cliente = obj as Cliente;

                if (cliente == null)
                {
                    MessageBox.Show("Objeto Cliente inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInsere, con);

                cmd.Parameters.AddWithValue("@nomecliente", cliente.Nomecliente);
                cmd.Parameters.AddWithValue("@foto", cliente.Foto);
                cmd.Parameters.AddWithValue("@datanasc", cliente.Datanasc);
                cmd.Parameters.AddWithValue("@codsexo", cliente.Sexo.Codsexo);
                cmd.Parameters.AddWithValue("@codrua", cliente.Rua.Codrua);
                cmd.Parameters.AddWithValue("@codbairro", cliente.Bairro.Codbairro);
                cmd.Parameters.AddWithValue("@codcep", cliente.Cep.Codcep);
                cmd.Parameters.AddWithValue("@codcidade", cliente.Cidade.Codcidade);
                cmd.Parameters.AddWithValue("@salario", cliente.Salario);
                cmd.Parameters.AddWithValue("@codtrabalho", cliente.Trabalho.Codtrabalho);
                cmd.Parameters.AddWithValue("@numerocasa", cliente.Numerocasa);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cliente incluído com sucesso");
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
