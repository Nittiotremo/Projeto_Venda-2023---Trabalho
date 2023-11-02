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
        internal class C_Funcionario : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO funcionario (nomefuncionario, numerocasa, foto, codrua_fk, " +
                "codbairro_fk, codcep_fk, codcidade_fk, codfuncao_fk, salario, codloja_fk, codsexo_fk, datanasc) " +
                "VALUES (@nomefuncionario, @numerocasa, @foto, @codrua, @codbairro, @codcep, @codcidade, @codfuncao, " +
                "@salario, @codloja, @codsexo, @datanasc)";
            string sqlApagar = "DELETE FROM funcionario WHERE codfuncionario = @codfuncionario";
            string sqlTodos = "SELECT * FROM funcionario";

            public void apagaDados(int codFuncionario)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codfuncionario", codFuncionario);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Funcionário apagado com sucesso!\nCódigo: " + codFuncionario);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar funcionário!\nErro: " + ex.ToString());
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
                DataTable funcionarios = new DataTable();

                con.Open();

                try
                {
                    da.Fill(funcionarios);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar funcionários!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return funcionarios;
            }

            public void insereDados(object obj)
            {
                Funcionario funcionario = obj as Funcionario;

                if (funcionario == null)
                {
                    MessageBox.Show("Objeto Funcionário inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nomefuncionario", funcionario.Nomefuncionario);
                cmd.Parameters.AddWithValue("@numerocasa", funcionario.Numerocasa);
                cmd.Parameters.AddWithValue("@foto", funcionario.Foto);
                cmd.Parameters.AddWithValue("@codrua", funcionario.Rua.Codrua);
                cmd.Parameters.AddWithValue("@codbairro", funcionario.Bairro.Codbairro);
                cmd.Parameters.AddWithValue("@codcep", funcionario.Cep.Codcep);
                cmd.Parameters.AddWithValue("@codcidade", funcionario.Cidade.Codcidade);
                cmd.Parameters.AddWithValue("@codfuncao", funcionario.Funcao.Codfuncao);
                cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
                cmd.Parameters.AddWithValue("@codloja", funcionario.Loja.Codloja);
                cmd.Parameters.AddWithValue("@codsexo", funcionario.Sexo.Codsexo);
                cmd.Parameters.AddWithValue("@datanasc", funcionario.Datanasc);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Funcionário incluído com sucesso");
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
