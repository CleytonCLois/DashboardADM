namespace BlazorCRUD.Data.Dapper.Repositorios
{
    #region " Usings "

    using BlazorCRUD.Model;
    using global::Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    #endregion

    #region " GraficoRepositorio "

    public class GraficoRepositorio : IGraficoRepositorio
	{
        #region " Conexão "

        private string _connectionString;

		public GraficoRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

        #endregion

        #region " Funções/Consultas "

        public async Task<List<Grafico>> PreencherDados()
		{
			var db = dbConnection();

			var sql = "SELECT CASE WHEN Situacao = 3 THEN 'Desatualizadas' WHEN Situacao = 4 THEN 'Desatualizadas a mais de uma semana' END[texto], COUNT(PRF_Tid)[valores] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 3 OR Situacao = 4 GROUP BY Situacao";

			return (List<Grafico>)await db.QueryAsync<Grafico>(sql, new { });
		}

		public async Task<IEnumerable<Grafico>> DadosPrefeituraGrafico(int situacao)
		{
			try
			{
				var db = dbConnection();
				var sql = "SELECT	CASE WHEN @Situacao = 1 THEN 'Prefeituras Atualizadas' WHEN @Situacao = 2 THEN 'Prefeituras Atualizadas Últimas 24hrs' WHEN @Situacao = 3 THEN 'Prefeituras Desatualizadas' WHEN @Situacao = 4 THEN 'Prefeituras Por mais de Uma Semana' END [texto], COUNT(PRF_Tid)[valores] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = @Situacao GROUP BY Situacao";
				var result = await db.QueryAsync<Grafico>(sql, new { situacao });
				return result;
			}
			catch (Exception e)
			{
				throw;
			}
		}

		#endregion
	}

	#endregion
}
