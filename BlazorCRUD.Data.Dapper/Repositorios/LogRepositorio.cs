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

	#region " LogRepositorio "

	public class LogRepositorio : ILogRepositorio
	{
        #region " Conexão "

        private string _connectionString;

		public LogRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

		#endregion

		#region " Funções/Consultas "

		public async Task<IEnumerable<Log>> CarregarDadosLog()
		{
			var db = dbConnection();
			var sql = "SELECT TOP 10 LogSistema.Id, LogSistema.DataHoraInicial, LogSistema.DataHoraFinal, TipoLogSistema.Descricao AS TipoLog, LogSistema.Notificacao, LogSistema.UsuarioIp, LogSistema.UsuarioUrl, LogSistema.EmailEnviado, PRF_RazaoSocial,  USU_Nome, dbo.FormatarCpfCnpj(USU_CPF) AS USU_Cpf, LogSistema.PrefeituraId, LogSistema.UsuarioId FROM LogSistema INNER JOIN TipoLogSistema ON TipoLogSistema.Id = LogSistema.TipoLogId INNER JOIN PREFEITURA ON PRF_TID = LogSistema.PrefeituraId INNER JOIN USUARIO ON USU_tID = LogSistema.UsuarioId WHERE TipoNotificacaoId = 2 ORDER BY LogSistema.Id DESC";
			var result = await db.QueryAsync<Log>(sql, new { });

			return result;
		}


		#endregion
	}

	#endregion
}
