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
    internal class C_ItensTelefoneLoja : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itenstelefoneloja (codloja_fk, codtelefone_fk) VALUES (@codloja, @codtelefone)";
            string sqlApagar = "DELETE FROM itenstelefoneloja WHERE codloja_fk = @codloja AND codtelefone_fk = @codtelefone";
            string sqlTodos = "SELECT * FROM itenstelefoneloja";

            public void apagaDados(int codLoja, int codTelefone)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codloja", codLoja);
                cmd.Parameters.AddWithValue("@codtelefone", codTelefone);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Associação entre Loja e Telefone apagada com sucesso!\nCódigo de Loja: " + codLoja + ", Código de Telefone: " + codTelefone);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar associação entre Loja e Telefone!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

        public void apagaDados(int cod)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarTodos()
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlTodos, con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable itensTelefoneLoja = new DataTable();

                con.Open();

                try
                {
                    da.Fill(itensTelefoneLoja);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar associações entre Loja e Telefone!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return itensTelefoneLoja;
            }

            public void insereDados(object obj)
            {
                ItensTelefoneLoja itensTelefoneLoja = obj as ItensTelefoneLoja;

                if (itensTelefoneLoja == null)
                {
                    MessageBox.Show("Objeto ItensTelefoneLoja inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codloja", itensTelefoneLoja.Loja.Codloja);
                cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneLoja.Telefone.Codtelefone);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Associação entre Loja e Telefone incluída com sucesso");
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
