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

		public async Task<IEnumerable<Grafico>> TopPrefeituras()
		{
			var db = dbConnection();
			var sql = "SELECT TOP 10 MUN_Nome[texto], CAST(COUNT(*) as float) [valores] FROM DOCUMENTOFISCAL WITH(NOLOCK) INNER JOIN PREFEITURAENDERECO ON (PFE_PRF_TidPrefeitura = DOF_PFE_TidPrefeituraEndereco) INNER JOIN PREFEITURA ON (PRF_Tid = PFE_PRF_TidPrefeitura) INNEr JOIN MUNICIPIO ON (MUN_Tid = PRF_MUN_TidMunicipio) WHERE MONTH(DOF_DataEmissao) = 9 GROUP BY MUN_Nome ORDER BY valores DESC";
			var result = await db.QueryAsync<Grafico>(sql, new { });

			return result;
		}

		#endregion
	}

	#endregion
}
