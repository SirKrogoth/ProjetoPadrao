using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPadrao
{
    public class AcessarDadosSQLServer
    {
        string string_conexao = "Data Source=(local);Initial Catalog=hospital;User ID=sa;Password=506829; Trusted_Connection=True";

        SqlConnection sqlConnection;
        
        //Métodos para criar nova conexao com o banco
        public SqlConnection CriarConexao()
        {
            try
            {
                return sqlConnection = new SqlConnection(string_conexao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
            finally
            {
                sqlConnection.Close();
            }
        }

        public void FecharConexao()
        {
            sqlConnection.Close();
        }

        //Parametro que irá ao banco de dados
        //Este parametro irá receber do C# os dados e enviar ao banco de dados pelas Store Procedures
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        //Limpando parametro criado.
        public void limparParametro()
        {
            sqlParameterCollection.Clear();
        }

        //adicionando o nome e o valor do parametro que irá ser enviado ao banco de dados
        public void adicionarParametro(string nome, object valor)
        {
            sqlParameterCollection.Add(new SqlParameter(nome, valor));
        }

        //executando parametro com as informações desejadas pelo usuário
        //o programa irá me trazer o tipo de comando executado, exemplo, procedure ou texto e tambem
        //terá de me informar o nome da procedure ou o codigo a ser executado
        //Inserção, Alteração e Exclusão de dados
        public object executarManipulacao(CommandType commandType, string nomeProcedure)
        {
            try
            {
                //criando conexao
                SqlConnection sqlConnection = CriarConexao();
                //abrindo conexao com o banco
                sqlConnection.Open();
                //conexao está aberta, agora temos de criar o comando que irá movimentar os dados
                //nesta conexao já aberta, e este comando é o SqlCommand
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //usando commandType e nomeProcedure
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeProcedure;
                sqlCommand.CommandTimeout = 600;//tempo de espera
                //agora vmos informar os valores a serem setados no banco, exemplo
                /* 
                 * @nome = valor
                 * @telefone = valor
                 * @cpf = valor
                 */
                //aqui vai ficar os valores e colocar na store procedure
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta
        public DataTable executarConsulta(CommandType commandType, string nomeProcedureOuTexto)
        {
            try
            {
                //criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //criando comando que irá percorrer a conexao
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeProcedureOuTexto;
                sqlCommand.CommandTimeout = 600;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Criando adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //Criando um dataTable que é o local onde os dados ficarão
                DataTable dataTable = new DataTable();
                //Mandando o comando até o banco
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}