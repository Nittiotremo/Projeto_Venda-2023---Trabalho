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
    internal class C_Cep
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInsere = "insert into cep (nomecep) values (@Nome)";
       // string sqlEditar = "update cep set nomecep = @Nome where id = @Nome";
        string sqlApagar = "delete from cep where codcep = @Id";
        string sqlTodos = "select * from cep";
        //string sqlBuscarId = "select * from cep where codcep = @Id";
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
                    MessageBox.Show("Cep deletada com Sucesso!!!\n" +
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
        public List<Cep> carregaDados()
        {
            List<Cep> lista_cep = new List<Cep>();

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlTodos, con);

            cmd.CommandType = CommandType.Text;

            SqlDataReader tabCep; //Representa uma Tabela Virtual para a leitura de dados
            con.Open();


            try
            {
                tabCep = cmd.ExecuteReader();
                while (tabCep.Read())
                {
                    Cep aux = new Cep();

                    aux.Codcep = Int32.Parse(tabCep["codcep"].ToString());
                    aux.Numerocep = tabCep["nomecep"].ToString();

                    lista_cep.Add(aux);
                }
            }
            catch (Exception ex)
            {

            }
            finally { con.Close(); }

            return lista_cep;
        }

        public void insereDados(object obj)
        {
            Cep cep = new Cep();
            cep = (Cep)obj;

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInsere, con);

            cmd.Parameters.AddWithValue("@Nome", cep.Numerocep);
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
