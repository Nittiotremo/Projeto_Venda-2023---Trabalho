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
    internal class C_Telefone : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable telefone;
        string sqlInsere = "insert into telefone(numerotelefone, codoperadora_fk) values (@numerotelefone, @codoperadora)";
        string sqlTodosNormalizados = "select c.codtelefone as Código, c.numerotelefone as Telefone," +
            " u.numero as Numero from telefone c, " +
            "operadora u where c.codoperadora_fk = u.codoperadora";
        string sqlApagar = "delete from telefone where codtelefone = @Id";

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
                    MessageBox.Show("Telefone deletado com Sucesso!!!\n" +
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

        public DataTable buscarTodosNormalizados()
        {


            ConectaBanco conectaBanco = new ConectaBanco();
            con = conectaBanco.conectaSqlServer();



            //cria o objeto command para executar a instruçao sql
            cmd = new SqlCommand(sqlTodosNormalizados, con);
            //abre a conexao
            con.Open();
            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            da = new SqlDataAdapter(cmd);
            //cria um objeto datatable
            telefone = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(telefone);

            return telefone;
        }
        public DataTable buscarTodos()
        {
            throw new NotImplementedException();
        }

        public void insereDados(object obj)
        {
            Telefone telefone = new Telefone();
            telefone = (Telefone)obj;

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInsere, con);

            cmd.Parameters.AddWithValue("@numerotelefone", telefone.Numerotelefone);
            cmd.Parameters.AddWithValue("@codoperadora", telefone.Operadora.Codoperadora);
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

        public void editarDados(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
