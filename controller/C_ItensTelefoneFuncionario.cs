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
        internal class C_ItensTelefoneFuncionario : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itenstelefonefuncionario (codfuncionario_fk, codtelefone_fk) " +
                "VALUES (@codfuncionario, @codtelefone)";
            string sqlApagar = "DELETE FROM itenstelefonefuncionario WHERE codfuncionario_fk = @codfuncionario";
            string sqlTodos = "SELECT * FROM itenstelefonefuncionario";

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
                        MessageBox.Show("Itens de telefone do funcionário apagados com sucesso!\nCódigo do Funcionário: " + codFuncionario);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar itens de telefone do funcionário!\nErro: " + ex.ToString());
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
                DataTable itensTelefoneFuncionario = new DataTable();

                con.Open();

                try
                {
                    da.Fill(itensTelefoneFuncionario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar itens de telefone do funcionário!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return itensTelefoneFuncionario;
            }

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
        }

        public void insereDados(object obj)
            {
                ItensTelefoneFuncionario itensTelefoneFuncionario = obj as ItensTelefoneFuncionario;

                if (itensTelefoneFuncionario == null)
                {
                    MessageBox.Show("Objeto ItensTelefoneFuncionario inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codfuncionario", itensTelefoneFuncionario.Funcionario.Codfuncionario);
                cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneFuncionario.Telefone.Codtelefone);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Itens de telefone do funcionário incluídos com sucesso");
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
