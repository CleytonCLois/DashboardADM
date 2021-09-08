using BlazorCRUD.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public class PrefeituraRepositorio : IPrefeituraRepositorio
	{
		private string _connectionString;
		public PrefeituraRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

		public async Task<IEnumerable<Prefeitura>> TodasPrefeituras()
		{
			var db = dbConnection();

			var sql = "SELECT PRF_Tid[id], PRF_RazaoSocial[nomePrefeitura], UltimaAtualizacao[ultimaAtualizacao], Situacao[situacao] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3)";

			return await db.QueryAsync<Prefeitura>(sql, new { });
		}

		public async Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas()
		{
			var db = dbConnection();

			var sql = "SELECT PRF_Tid, PRF_RazaoSocial, UltimaAtualizacao, Situacao FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 1";

			return await db.QueryAsync<Prefeitura>(sql, new { });
		}

		public async Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas24Horas()
		{
			var db = dbConnection();

			var sql = "SELECT PRF_Tid, PRF_RazaoSocial, UltimaAtualizacao, Situacao FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 2";

			return await db.QueryAsync<Prefeitura>(sql, new { });
		}

		public async Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadas()
		{
			var db = dbConnection();

			var sql = "SELECT PRF_Tid, PRF_RazaoSocial, UltimaAtualizacao, Situacao FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 3";

			return await db.QueryAsync<Prefeitura>(sql, new { });
		}

		public async Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadasMaisDeUmaSemana()
		{
			var db = dbConnection();

			var sql = "SELECT PRF_Tid, PRF_RazaoSocial, UltimaAtualizacao, Situacao FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = 4";

			return await db.QueryAsync<Prefeitura>(sql, new { });
		}
	}
}
