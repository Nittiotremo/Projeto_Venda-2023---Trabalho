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
    internal class C_Trabalho
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInsere = "insert into trabalho (nometrabalho) values (@Nome)";
        //string sqlEditar = "update trabalho set nometrabalho = @Nome where id = @Nome";
        string sqlApagar = "delete from trabalho where codtrabalho = @Id";
        string sqlTodos = "select * from trabalho";
        //string sqlBuscarId = "select * from trabalho where codtrabalho = @Id";
        public void apagaDados(int cod)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@Id", cod);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("trabalho deletado com Sucesso!!!\n" +
                        "Código: " + cod);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Apagar!\nErro:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable buscarTodos()
        {
            throw new NotImplementedException();
        }


        //List para carregar ComboBox da aplicação.
        public List<Trabalho> carregaDados()
        {
            List<Trabalho> lista_trabalho = new List<Trabalho>();

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlTodos, con);

            cmd.CommandType = CommandType.Text;

            SqlDataReader tabTrabalho; //Representa uma Tabela Virtual para a leitura de dados
            con.Open();


            try
            {
                tabTrabalho = cmd.ExecuteReader();
                while (tabTrabalho.Read())
                {
                    Trabalho aux = new Trabalho();

                    aux.Codtrabalho = Int32.Parse(tabTrabalho["codtrabalho"].ToString());
                    aux.Nometrabalho = tabTrabalho["nometrabalho"].ToString();

                    lista_trabalho.Add(aux);
                }
            }
            catch (Exception ex)
            {

            }
            finally { con.Close(); }

            return lista_trabalho;
        }

        public void insereDados(object obj)
        {
            Trabalho trabalho = new Trabalho();
            trabalho = (Trabalho)obj;

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInsere, con);

            cmd.Parameters.AddWithValue("@Nome", trabalho.Nometrabalho);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro incluído com sucesso");
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
