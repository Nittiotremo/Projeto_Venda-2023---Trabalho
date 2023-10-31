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
    internal class C_Bairro : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;

        string sqlInsere = "insert into bairro (nomebairro) values (@Nome)";
        //string sqlEditar = "update bairro set nomebairro = @Nome where id = @Nome";
        string sqlApagar = "delete from bairro where codbairro = @Id";
        string sqlTodos = "select * from bairro";
        //string sqlBuscarId = "select * from bairro where codbairro = @Id";
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
                    MessageBox.Show("bairro deletado com Sucesso!!!\n" +
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
        public List<Bairro> carregaDados()
        {
            List<Bairro> lista_bairro = new List<Bairro>();

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlTodos, con);

            cmd.CommandType = CommandType.Text;

            SqlDataReader tabBairro; //Representa uma Tabela Virtual para a leitura de dados
            con.Open();


            try
            {
                tabBairro = cmd.ExecuteReader();
                while (tabBairro.Read())
                {
                    Bairro aux = new Bairro();

                    aux.Codbairro = Int32.Parse(tabBairro["codbairro"].ToString());
                    aux.Nomebairro = tabBairro["nomebairro"].ToString();

                    lista_bairro.Add(aux);
                }
            }
            catch (Exception ex)
            {

            }
            finally { con.Close(); }

            return lista_bairro;
        }

        public void insereDados(object obj)
        {
            Bairro bairro = new Bairro();
            bairro = (Bairro)obj;

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInsere, con);

            cmd.Parameters.AddWithValue("@Nome", bairro.Nomebairro);
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
