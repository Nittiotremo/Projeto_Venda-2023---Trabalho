﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.controller
    {
        internal class C_ItensTelefoneTrabalho : I_CRUD
        {
            SqlConnection con;
            SqlCommand cmd;

            string sqlInserir = "INSERT INTO itenstelefonetrabalho (codtrabalho_fk, codtelefone_fk) VALUES (@codtrabalho, @codtelefone)";
            string sqlApagar = "DELETE FROM itenstelefonetrabalho WHERE codtrabalho_fk = @codtrabalho AND codtelefone_fk = @codtelefone";
            string sqlTodos = "SELECT * FROM itenstelefonetrabalho";

            public void apagaDados(int codTrabalho, int codTelefone)
            {
                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlApagar, con);

                cmd.Parameters.AddWithValue("@codtrabalho", codTrabalho);
                cmd.Parameters.AddWithValue("@codtelefone", codTelefone);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Relação entre trabalho e telefone apagada com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar relação entre trabalho e telefone!\nErro: " + ex.ToString());
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
                DataTable relacoes = new DataTable();

                con.Open();

                try
                {
                    da.Fill(relacoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar relações entre trabalho e telefone!\nErro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                return relacoes;
            }

            public void insereDados(object obj)
            {
                ItensTelefoneTrabalho relacao = obj as ItensTelefoneTrabalho;

                if (relacao == null)
                {
                    MessageBox.Show("Objeto de relação trabalho-telefone inválido.");
                    return;
                }

                ConectaBanco cb = new ConectaBanco();
                con = cb.conectaSqlServer();
                cmd = new SqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@codtrabalho", relacao.Trabalho.Codtrabalho);
                cmd.Parameters.AddWithValue("@codtelefone", relacao.Telefone.Codtelefone);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Relação entre trabalho e telefone incluída com sucesso");
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

}
}
