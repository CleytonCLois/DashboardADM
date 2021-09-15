namespace BlazorCRUD.Data.Dapper.Repositorios
{
    #region " Usings "

    using BlazorCRUD.Model;
    using global::Dapper;
    using System;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    #endregion

    #region " ConfiguracaoRepositorio "

    public class ConfiguracaoRepositorio : IConfiguracaoRepositorio
	{
        #region " Conexão "

        private string _connectionString;

		public ConfiguracaoRepositorio(string connectionString)
		{
			_connectionString = "server=localhost; database=PSG; uid=sa; pwd=3464241; Pooling=true; Min Pool Size=10; Max Pool Size=100; Connect Timeout=60";
		}
        protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

        #endregion

        #region " Funções/Consultas "

        public int ConfiguracaoAtual()
		{
			try
			{
				var db = dbConnection();
				var sql = "SELECT [TempoAtualizacao] from [Acesso].[ConfiguracaoDashboard]";
				int tempoAtualizacao = db.QueryFirstOrDefault<int>(sql, new { });
				return tempoAtualizacao;
			}
			catch (Exception e)
			{
				throw;
			}
		}

        public async Task<bool> UpdateConfiguracao(Configuracao configuracao)
        {
			try
			{
				var db = dbConnection();
				var sql = "UPDATE [Acesso].[ConfiguracaoDashboard] SET [TempoAtualizacao] = @TempoAtualizacao";
				var result = await db.ExecuteAsync(sql, new { configuracao.tempoAtualizacao });
				return result > 0;
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
