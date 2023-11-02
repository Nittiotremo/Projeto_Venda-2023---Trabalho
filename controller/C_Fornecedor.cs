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
        internal class C_Fornecedor : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO fornecedor (nomefornecedor, numerocasa, codrua_fk, codbairro_fk, codcep_fk, codcidade_fk) " +
                "VALUES (@nomefornecedor, @numeroCasa, @codrua, @codbairro, @codcep, @codcidade)";
            string sqlApagar = "DELETE FROM fornecedor WHERE codfornecedor = @codfornecedor";
            string sqlTodos = "SELECT * FROM fornecedor";

            public void apagaDados(int codFornecedor)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codfornecedor", codFornecedor);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Fornecedor apagado com sucesso!\nCódigo do Fornecedor: " + codFornecedor);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar o Fornecedor!\nErro: " + ex.ToString());
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
                DataTable fornecedores = new DataTable();

                con.Open();

                try
                {
                    da.Fill(fornecedores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar Fornecedores!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return fornecedores;
            }

            public void insereDados(object obj)
            {
                Fornecedor fornecedor = obj as Fornecedor;

                if (fornecedor == null)
                {
                    MessageBox.Show("Objeto Fornecedor inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nomefornecedor", fornecedor.Nomefornecedor);
                cmd.Parameters.AddWithValue("@numerocasa", fornecedor.Numerocasa);
                cmd.Parameters.AddWithValue("@codrua", fornecedor.Rua.Codrua);
                cmd.Parameters.AddWithValue("@codbairro", fornecedor.Bairro.Codbairro);
                cmd.Parameters.AddWithValue("@codcep", fornecedor.Cep.Codcep);
                cmd.Parameters.AddWithValue("@codcidade", fornecedor.Cidade.Codcidade);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Fornecedor incluído com sucesso");
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
