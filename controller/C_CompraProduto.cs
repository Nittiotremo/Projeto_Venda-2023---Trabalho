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
        internal class C_CompraProduto : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO compraproduto (datacompra, codfornecedor_fk, codfuncionario_fk) " +
                "VALUES (@datacompra, @codfornecedor, @codfuncionario)";
            string sqlApagar = "DELETE FROM compraproduto WHERE codcompra = @codcompra";
            string sqlTodos = "SELECT * FROM compraproduto";

            public void apagaDados(int codCompra)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codcompra", codCompra);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Compra de produto apagada com sucesso!\nCód. Compra: " + codCompra);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar a compra de produto!\nErro: " + ex.ToString());
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
                DataTable comprasProduto = new DataTable();

                con.Open();

                try
                {
                    da.Fill(comprasProduto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar compras de produto!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return comprasProduto;
            }

            public void insereDados(object obj)
            {
                CompraProduto compraProduto = obj as CompraProduto;

                if (compraProduto == null)
                {
                    MessageBox.Show("Objeto CompraProduto inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@datacompra", compraProduto.Datacompra);
                cmd.Parameters.AddWithValue("@codfornecedor", compraProduto.Fornecedor.Codfornecedor);
                cmd.Parameters.AddWithValue("@codfuncionario", compraProduto.Funcionario.Codfuncionario);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Compra de produto incluída com sucesso");
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
