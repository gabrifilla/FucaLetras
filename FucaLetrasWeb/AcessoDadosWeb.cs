using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace FucaLetrasBD
{
    public class AcessoDadosWeb
    {
        private SqlConnection dbConn = null;

        // Parametros que irão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        // Limpa a coleção de parâmeteos
        public void RemoverTodosParametros()
        {
            sqlParameterCollection.Clear();
        }

        //Aciciona parâmetros
        public void AdicionarParametro(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        private SqlConnection CriarConexao()
        {
            // Cria a conexão com o database
            dbConn = new SqlConnection();


            // Criar referência a System.Configuraton.dll
            dbConn.ConnectionString = @"Data Source=GABRIELFILLA-PC\CPTNMIKKI;Initial Catalog=fucaletrasWeb;Integrated Security=True";
            //ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            return dbConn;
        }


        //Consultar a Letra do Banco de Dados
        //Vai até o banco e traz para uma rich text box.
        public DataTable BuscarLetra(CommandType commandType, string nomeStoredProcedure)
        {
            try
            {
                // Criar conexão
                dbConn = CriarConexao();

                // Abrir Conexão
                dbConn.Open();

                // Criar comando que vai levar informação até o banco
                SqlCommand sqlCommand = new SqlCommand();

                // Associando o comando à conexão existente
                sqlCommand.Connection = dbConn;

                //Colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedure;
                sqlCommand.CommandTimeout = 7200;

                // Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Criar um ADAPTADOR
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //Criar um DataTable 
                //Tabela de dados vazia onde será inserido os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador
                // preencher o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            // Capturar o erro e colocar no ex
            catch (Exception ex)
            {
                // Dispara uma nova excessão e passa o erro para ela.
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open)
                    dbConn.Close();
            }
        }

        //Insere as informações da musica no banco de dados.
        public object InserirMusica(CommandType commandType, string nomeStoredProcedure)
        {
            try
            {
                // Criar conexão
                dbConn = CriarConexao();

                // Abrir Conexão
                dbConn.Open();

                // Criar comando que vai levar informação até o banco
                SqlCommand sqlCommand = new SqlCommand();

                // Associando o comando à conexão existente
                sqlCommand.Connection = dbConn;

                //Colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedure;
                sqlCommand.CommandTimeout = 7200;

                // Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlCommand.ExecuteScalar();
            }
            // Capturar o erro e colocar no ex
            catch (Exception ex)
            {
                // Dispara uma nova excessão e passa o erro para ela.
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open)
                    dbConn.Close();
            }
        }

        //Consultar registros do banco de dados
        // vai até o banco, executa e traz para um grid
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedure)
        {
            try
            {
                // Criar conexão
                dbConn = CriarConexao();

                // Abrir Conexão
                dbConn.Open();

                // Criar comando que vai levar informação até o banco
                SqlCommand sqlCommand = new SqlCommand();

                // Associando o comando à conexão existente
                sqlCommand.Connection = dbConn;

                //Colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedure;
                sqlCommand.CommandTimeout = 7200;

                // Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Criar um ADAPTADOR
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //Criar um DataTable 
                //Tabela de dados vazia onde será inserido os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador
                // preencher o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            // Capturar o erro e colocar no ex
            catch (Exception ex)
            {
                // Dispara uma nova excessão e passa o erro para ela.
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open)
                    dbConn.Close();
            }
        }

        //Não sei pra que serve esse
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {

                // Criar a conexão     chamar o método criar conexão...
                SqlConnection sqlConnection = CriarConexao();

                // Abrir Conexão
                sqlConnection.Open();

                // Criar comando que vai levar informação até o banco  
                // Solicitar a conexão aberta: sqlConnection 
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                // Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; // Em segundos

                // Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }


                //Executar o comando, ou seja, mandar o comando ir até o banco de dados
                return sqlCommand.ExecuteScalar();

            }

                // Capturar o erro e colocar no ex
            catch (Exception ex)
            {
                //Dispara uma nova excessão e passa o erro pra ela...
                throw new Exception(ex.Message);
            }

        }

        //Validar se a música já existe no banco
        public void ExecuteNonQuery(string nomeStoredProcedure)
        {
            try
            {
                // Criar conexão
                dbConn = CriarConexao();

                // Abrir Conexão
                dbConn.Open();

                // Criar comando que vai levar informação até o banco
                SqlCommand sqlCommand = new SqlCommand();

                // Associando o comando à conexão existente
                sqlCommand.Connection = dbConn;

                //Colocando as coisas dentro do comando
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = nomeStoredProcedure;
                sqlCommand.CommandTimeout = 7200;

                // Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                    sqlCommand.Parameters.AddWithValue(sqlParameter.ParameterName.ToString(), sqlParameter.Value);

                // Executa a procedure e coleta o número de linhas afetadas
                //int rowsAffected = int.Parse(sqlCommand.ExecuteScalar().ToString());
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Parameters.Clear();
            }
            // Capturar o erro e colocar no ex
            catch (SqlException ex)
            {
                // Dispara uma nova excessão e passa o erro para ela.
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open)
                    dbConn.Close();
            }
        }
    }


}
