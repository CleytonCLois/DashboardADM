namespace BlazorCRUD.Data.Dapper.Repositorios
{
    #region " Usings "

    using BlazorCRUD.Model;
    using global::Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;

    #endregion

    #region " PrefeituraRepositorio "

    public class PrefeituraRepositorio : IPrefeituraRepositorio
	{
        #region " Conexão "

        private string _connectionString;

		public PrefeituraRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

        #endregion

        #region " Funções/Consultas "

        public async Task<IEnumerable<Prefeitura>> TodasPrefeituras()
		{
			var db = dbConnection();

			var sql = "SELECT PRF_Tid[id], PRF_RazaoSocial[nomePrefeitura], UltimaAtualizacao[ultimaAtualizacao], Situacao[situacao] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3)";

			return await db.QueryAsync<Prefeitura>(sql, new { });
		}

		public async Task<IEnumerable<Prefeitura>> ListaDePrefeituras(int situacao)
		{
			try
			{
				var db = dbConnection();
				var sql = "SELECT PRF_Tid[id], PRF_RazaoSocial[nomePrefeitura], FORMAT(UltimaAtualizacao, 'dd/MM/yyyy hh:mm:ss')[ultimaAtualizacao], CASE WHEN Situacao = 1 THEN 'Atualizada' WHEN Situacao = 2 THEN 'Atualizada nas últimas 24hrs' WHEN Situacao = 3 THEN 'Desatualizada' WHEN Situacao = 4 THEN 'Desatualizada por mais de uma semana' END [Situacao] FROM PREFEITURA INNER JOIN PARAMETROPREFEITURA ON (PAP_PAR_TidParametro = 17) AND (PAP_PRF_TidPrefeitura = PRF_Tid) AND (PAP_Valor = 'N') LEFT JOIN (SELECT MAX(UltimaAtualizacao) UltimaAtualizacao, TidPrefeitura, Situacao FROM VIEW_ULTIMA_SINCRONIZACAO GROUP BY TidPrefeitura, Situacao) U ON (U.TidPrefeitura = PRF_Tid) WHERE PRF_Tid NOT IN (1,3) AND Situacao = @Situacao";
				var result = await db.QueryAsync<Prefeitura>(sql, new { situacao });

                if (situacao == 4 && result.Count() == 0)
                {
					await ListaDePrefeituras(3);
                }
				if(situacao == 3 && result.Count() == 0)
                {
                    await ListaDePrefeituras(2);
                }
				if(situacao == 2 && result.Count() == 0)
                {
                    await ListaDePrefeituras(1);
                }
                return result;
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion
	}

    #endregion
}
