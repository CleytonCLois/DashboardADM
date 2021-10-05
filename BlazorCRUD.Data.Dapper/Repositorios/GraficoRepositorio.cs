namespace BlazorCRUD.Data.Dapper.Repositorios
{
    #region " Usings "

    using BlazorCRUD.Model;
    using global::Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Threading.Tasks;
	using System.Drawing;
    using System.Text.RegularExpressions;

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

		public async Task<IEnumerable<Grafico>> DadosGraficoMaioresEmissoresDeNFE()
		{
			try
			{
				var db = dbConnection();
				var sql = @"SELECT TOP 20 MUN_Nome[texto], 
						   CAST(COUNT(*) as float) [valores], 
						   CAST(PRL_Logo AS VARBINARY(max)) [Logo]
					FROM DOCUMENTOFISCAL WITH(NOLOCK) 
						INNER JOIN PREFEITURAENDERECO ON (PFE_PRF_TidPrefeitura = DOF_PFE_TidPrefeituraEndereco) 
						INNER JOIN PREFEITURA ON (PRF_Tid = PFE_PRF_TidPrefeitura) 
						INNER JOIN MUNICIPIO ON (MUN_Tid = PRF_MUN_TidMunicipio) 
						INNER JOIN PREFEITURALOGO ON(PRF_PRL_TidLogoAtual = PRL_Tid)  
					WHERE (MONTH(DOF_DataEmissao) = (MONTH(DATEADD(MONTH, -1, GETDATE()))))
						AND (YEAR(DOF_DataEmissao) = (YEAR(DATEADD(YEAR, CASE WHEN (MONTH(DATEADD(MONTH, -1, GETDATE()))) = 12 THEN -1 ELSE 0 END, GETDATE()))))
						AND NOT EXISTS (SELECT *
										FROM PARAMETROPREFEITURA
										WHERE PAP_PAR_TidParametro = 17
											AND PAP_PRF_TidPrefeitura = PRF_Tid
											AND PAP_Valor = 'S')
					GROUP BY MUN_Nome, CAST(PRL_Logo AS VARBINARY(MAX)) ORDER BY valores DESC";
				var result = await db.QueryAsync<Grafico>(sql, new { });

				return result;
			}
			catch (Exception e)
			{
				throw;
			}
		}


		public async Task<IEnumerable<Grafico>> DadosGraficoProcessamentoDeLote()
		{
			try
			{
				var db = dbConnection();
				var sql = "SET NOCOUNT ON CREATE TABLE #ULTIMAS_24h ( Id INT IDENTITY(1,1), DataHora DATETIME ) CREATE TABLE #LOTES_AGUARDANDO ( DataHora DATETIME, Quantidade INT, Situacao INT ) DECLARE @Contador INT = 0, @Dia INT, @Mes INT, @Ano INT, @Hora INT, @Minutos INT, @DataHoraReferencia DATETIME SET @Dia = DAY(GETDATE()) SET @Mes = MONTH(GETDATE()) SET @Ano = YEAR(GETDATE()) SET @Hora = DATEPART(HOUR, GETDATE()) SET @Minutos = DATEPART(MINUTE, GETDATE()) INSERT INTO #ULTIMAS_24h (DataHora) SELECT DATETIMEFROMPARTS(@Ano, @Mes, @Dia, CASE WHEN @Minutos > 30 THEN @Hora + 1 ELSE @Hora END, CASE WHEN @Minutos > 30 THEN 0 ELSE 30 END, 0, 0) WHILE (@Contador < 24) BEGIN INSERT INTO #ULTIMAS_24h (DataHora) SELECT DATEADD(MINUTE, -30, MIN(DataHora)) FROM #ULTIMAS_24h SET @Contador = @Contador + 1 END DECLARE @Id INT, @DataHora1 DATETIME, @DataHora2 DATETIME SELECT @Id = MAX(Id) FROM #ULTIMAS_24h WHILE ((@id IS NOT NULL) AND (@Id - 1 >= 1)) BEGIN SELECT @DataHora1 = DataHora FROM #ULTIMAS_24h WHERE Id = @id SELECT @DataHora2 = DataHora FROM #ULTIMAS_24h WHERE Id = (@id - 1) INSERT INTO #LOTES_AGUARDANDO (DataHora, Quantidade, Situacao) SELECT @DataHora2, COUNT(*) , RPL_Situacao FROM ReciboProvisorioLote WITH (NOLOCK) WHERE RPL_DataRecebimento BETWEEN @DataHora1 AND @DataHora2 AND RPL_Sincrono = 'N' GROUP BY RPL_Situacao SELECT @Id = MAX(Id) FROM #ULTIMAS_24h WHERE (Id < @Id) END SELECT CONVERT(CHAR(5), T.DataHora, 108) Hora, ISNULL(Quantidade, 0) Quantidade, CASE Situacao WHEN 2 THEN 'Aguardando Processamento' WHEN 3 THEN 'Processados com Erro' WHEN 4 THEN 'Processados com Sucesso' ELSE 'Sem Lotes' END Situacao FROM #ULTIMAS_24h T LEFT JOIN #LOTES_AGUARDANDO L ON (L.DataHora = T.DataHora) ORDER BY T.DataHora DROP TABLE #LOTES_AGUARDANDO DROP TABLE #ULTIMAS_24h SET NOCOUNT OFF";
				var result = await db.QueryAsync<Grafico>(sql, new { });

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
