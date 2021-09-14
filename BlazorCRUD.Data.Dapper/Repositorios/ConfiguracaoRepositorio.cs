using BlazorCRUD.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public class ConfiguracaoRepositorio : IConfiguracaoRepositorio
	{
		private string _connectionString;

		public ConfiguracaoRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

		public async Task<IEnumerable<Configuracao>> TodasConfiguracoes()
		{
			var db = dbConnection();

			var sql = "SELECT * FROM Almoxarifado.Almoxarifado";

			return await db.QueryAsync<Configuracao>(sql, new { });
		}

        public async Task<bool> UpdateConfiguracao(Configuracao configuracao)
        {
            var db = dbConnection();
            var sql = "UPDATE dbo.ConfiguracaoDashboard SET TempoAtualizacao = @TempoAtualizacao";

            var result = await db.ExecuteAsync(sql,
                new { configuracao.tempoAtualizacao });

            return result > 0;
        }
    }
}
