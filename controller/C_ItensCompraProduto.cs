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
        internal class C_ItensCompraProduto : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itenscompraproduto (codcompra_fk, codproduto_fk, quantidade, valor) " +
                "VALUES (@codcompra, @codproduto, @quantidade, @valor)";
            string sqlApagar = "DELETE FROM itenscompraproduto WHERE codcompra_fk = @codcompra AND codproduto_fk = @codproduto";
            string sqlTodos = "SELECT * FROM itenscompraproduto";

            public void apagaDados(int codCompra, int codProduto)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codcompra", codCompra);
                cmd.Parameters.AddWithValue("@codproduto", codProduto);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Itens da compra de produto apagados com sucesso!\nCód. Compra: " + codCompra + ", Cód. Produto: " + codProduto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar os itens da compra de produto!\nErro: " + ex.ToString());
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
                DataTable itensCompraProduto = new DataTable();

                con.Open();

                try
                {
                    da.Fill(itensCompraProduto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar itens da compra de produto!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return itensCompraProduto;
            }

            public void insereDados(object obj)
            {
                ItensCompraProduto itensCompraProduto = obj as ItensCompraProduto;

                if (itensCompraProduto == null)
                {
                    MessageBox.Show("Objeto ItensCompraProduto inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@CodCompra", itensCompraProduto.CompraProduto.Codcompra);
                cmd.Parameters.AddWithValue("@CodProduto", itensCompraProduto.Produto.Codproduto);
                cmd.Parameters.AddWithValue("@Quantidade", itensCompraProduto.Quantidade);
                cmd.Parameters.AddWithValue("@Valor", itensCompraProduto.Valor);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Itens da compra de produto incluídos com sucesso");
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
