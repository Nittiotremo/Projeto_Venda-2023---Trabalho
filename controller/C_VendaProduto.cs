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
        internal class C_VendaProduto : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO vendaproduto (datavenda, codcliente_fk, codfuncionario_fk) VALUES (@datavenda, @codcliente, @codfuncionario)";
            string sqlApagar = "DELETE FROM vendaproduto WHERE codvenda = @codvenda";
            string sqlTodos = "SELECT * FROM vendaproduto";

            public void apagaDados(int codVenda)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codvenda", codVenda);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Venda de produto apagada com sucesso!\nCódigo: " + codVenda);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar a venda de produto!\nErro: " + ex.ToString());
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
                DataTable vendasProduto = new DataTable();

                con.Open();

                try
                {
                    da.Fill(vendasProduto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar vendas de produto!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return vendasProduto;
            }

            public void insereDados(object obj)
            {
                VendaProduto vendaProduto = obj as VendaProduto;

                if (vendaProduto == null)
                {
                    MessageBox.Show("Objeto VendaProduto inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@datavenda", vendaProduto.Datavenda);
                cmd.Parameters.AddWithValue("@codcliente", vendaProduto.Cliente.Codcliente);
                cmd.Parameters.AddWithValue("@codfuncionario", vendaProduto.Funcionario.Codfuncionario);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Venda de produto incluída com sucesso");
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
