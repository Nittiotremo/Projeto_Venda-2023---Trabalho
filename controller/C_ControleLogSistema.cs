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
        internal class C_ControleLogSistema : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO controlelogsistema (codlogin_fk, datas, hora) " +
                "VALUES (@codlogin, @datas, @hora)";
            string sqlApagar = "DELETE FROM controlelogsistema WHERE codcontrole = @codcontrole";
            string sqlTodos = "SELECT * FROM controlelogsistema";

            public void apagaDados(int codControle)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codcontrole", codControle);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Controle de Log apagado com sucesso!\nCódigo do Controle: " + codControle);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar controle de log!\nErro: " + ex.ToString());
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
                DataTable controles = new DataTable();

                con.Open();

                try
                {
                    da.Fill(controles);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar controles de log!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return controles;
            }

            public void insereDados(object obj)
            {
                ControleLogSistema controleLog = obj as ControleLogSistema;

                if (controleLog == null)
                {
                    MessageBox.Show("Objeto ControleLogSistema inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codlogin", controleLog.Logins.Codlogin);
                cmd.Parameters.AddWithValue("@datas", controleLog.Datas);
                cmd.Parameters.AddWithValue("@hora", controleLog.Hora.Interval);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Controle de Log incluído com sucesso");
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
