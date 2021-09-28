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

		public async Task<IEnumerable<Grafico>> TopPrefeituras()
		{
			try
			{
				var db = dbConnection();
				var sql = "SELECT TOP 15 MUN_Nome[texto], CAST(COUNT(*) as float) [valores], CAST(PRL_Logo AS binary) [Logo] FROM DOCUMENTOFISCAL WITH(NOLOCK) INNER JOIN PREFEITURAENDERECO ON (PFE_PRF_TidPrefeitura = DOF_PFE_TidPrefeituraEndereco) INNER JOIN PREFEITURA ON (PRF_Tid = PFE_PRF_TidPrefeitura) INNER JOIN MUNICIPIO ON (MUN_Tid = PRF_MUN_TidMunicipio) INNER JOIN PREFEITURALOGO ON(PRF_PRL_TidLogoAtual = PRL_Tid) WHERE MONTH(DOF_DataEmissao) = 9 GROUP BY MUN_Nome, CAST(PRL_Logo AS BINARY) ORDER BY valores DESC";
				var result = await db.QueryAsync<Grafico>(sql, new { });

				return result;
			}
			catch (Exception e)
			{
				throw;
			}
		}

		//public string teste(byte[] teste)
		//{
		//	string imgstring = "0x424D6EB800000000000036000000280000007800000083000000010018000000000038B8000000000000000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDFDFEFCFCFFFEFEFFFFFFFFFFFFFFFEFEFFFFFFFF 1                     0xFFD8FFE112754578696600004D4D002A000000080007011200030000000100010000011A00050000000100000062011B0005000000010000006A012800030000000100020000013100020000001C0000007201320002000000140000008E8769000400000001000000A4000000D0000AFC8000002710000AFC800000271041";
		//	return "data:image/jpg; base64," + base64String;
		//}

		#endregion
	}

	#endregion
}
