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

	#region " PessoaRepositorio "

	public class PessoaRepositorio : IPessoaRepositorio
	{
		#region " Conexão "

		private string _connectionString;

		public PessoaRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

		#endregion

		#region " Funções/Consultas "

		public async Task<IEnumerable<Pessoa>> CarregarDadosPessoa()
		{
			var db = dbConnection();
			var sql = "Select Top 5 PES_Tid[Id], dbo.FormatarCpfCnpj(PES_CpfCnpj) AS PES_CpfCnpj, PES_RazaoSocial[RazaoSocial], CASE WHEN PRF_Tid = 22 THEN 'Eunápolis (22)' ELSE SUBSTRING(PRF_RazaoSocial ,25, LEN(PRF_RazaoSocial )-1) + ' (' + CAST( PRF_Tid AS Varchar(3 )) + ')' END AS Prefeitura, PES_DataHoraInclusao[DataHoraInclusao] From Pessoa With(Nolock) Inner Join Prefeitura With(Nolock) ON (PRF_Tid = PES_PRF_TidPrefeitura) Order By PES_Tid Desc";
			var result = await db.QueryAsync<Pessoa>(sql, new { });

			return result;
		}

		#endregion
	}

	#endregion
}
