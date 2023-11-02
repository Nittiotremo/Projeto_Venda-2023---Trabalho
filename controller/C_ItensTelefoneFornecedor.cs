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
        internal class C_ItensTelefoneFornecedor : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itenstelefonefornecedor (codtelefone_fk, codfornecedor_fk) " +
                "VALUES (@codtelefone, @codfornecedor)";
            string sqlApagar = "DELETE FROM itenstelefonefornecedor WHERE codtelefone_fk = @codtelefone AND codfornecedor_fk = @codfornecedor";
            string sqlTodos = "SELECT * FROM itenstelefonefornecedor";

            public void apagaDados(int codTelefone, int codFornecedor)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codtelefone", codTelefone);
                cmd.Parameters.AddWithValue("@codfornecedor", codFornecedor);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Item de telefone do fornecedor apagado com sucesso!\nCód. Telefone: " + codTelefone + ", Cód. Fornecedor: " + codFornecedor);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar o item de telefone do fornecedor!\nErro: " + ex.ToString());
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
                DataTable itensTelefoneFornecedor = new DataTable();

                con.Open();

                try
                {
                    da.Fill(itensTelefoneFornecedor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar itens de telefone do fornecedor!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return itensTelefoneFornecedor;
            }

            public void insereDados(object obj)
            {
                ItensTelefoneFornecedor itensTelefoneFornecedor = obj as ItensTelefoneFornecedor;

                if (itensTelefoneFornecedor == null)
                {
                    MessageBox.Show("Objeto ItensTelefoneFornecedor inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codtelefone", itensTelefoneFornecedor.Telefone.Codtelefone);
                cmd.Parameters.AddWithValue("@codfornecedor", itensTelefoneFornecedor.Fornecedor.Codfornecedor);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Item de telefone do fornecedor incluído com sucesso");
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
