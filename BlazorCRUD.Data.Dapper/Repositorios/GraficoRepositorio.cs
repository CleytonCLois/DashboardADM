using BlazorCRUD.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
	public class GraficoRepositorio : IGraficoRepositorio
	{
		private string _connectionString;
		public GraficoRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

		public async Task<List<Grafico>> PreencherDados()
		{
			var db = dbConnection();

			var sql = "SELECT CASE WHEN Situacao = 3 THEN 'Desatualizadas' WHEN Situacao = 4 THEN 'Desatualizadas a mais de uma semana' END[texto], COUNT(PRF_Tid)[valores] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 3 OR Situacao = 4 GROUP BY Situacao";

			return (List<Grafico>)await db.QueryAsync<Grafico>(sql, new { });
		}

		public async Task<List<Grafico>> PrefeiturasAtualizadas()
		{
			var db = dbConnection();

			var sql = "SELECT CASE WHEN Situacao = 1 THEN 'Prefeituras Atualizadas' END [texto], COUNT(PRF_Tid)[valores] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 1 GROUP BY Situacao";

			return (List<Grafico>)await db.QueryAsync<Grafico>(sql, new { });
		}

		public async Task<List<Grafico>> PrefeiturasAtualizadasUltimas24hrs()
		{
			var db = dbConnection();

			var sql = "SELECT CASE WHEN Situacao = 2 THEN 'Prefeituras Atualizadas Últimas 24hrs' END [texto], COUNT(PRF_Tid)[valores] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 2 GROUP BY Situacao";

			return (List<Grafico>)await db.QueryAsync<Grafico>(sql, new { });
		}

		public async Task<List<Grafico>> PrefeiturasDesatualizadas()
		{
			var db = dbConnection();

			var sql = "SELECT CASE WHEN Situacao = 3 THEN 'Prefeituras Desatualizadas' END [texto], COUNT(PRF_Tid)[valores] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 3 GROUP BY Situacao";

			return (List<Grafico>)await db.QueryAsync<Grafico>(sql, new { });
		}

		public async Task<List<Grafico>> PrefeiturasDesatualizadasMaisDeUmaSemana()
		{
			var db = dbConnection();

			var sql = "SELECT CASE WHEN Situacao = 4 THEN 'Prefeituras Por mais de Uma Semana' END [texto], COUNT(PRF_Tid)[valores] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 4 GROUP BY Situacao";

			return (List<Grafico>)await db.QueryAsync<Grafico>(sql, new { });
		}

	}
}
