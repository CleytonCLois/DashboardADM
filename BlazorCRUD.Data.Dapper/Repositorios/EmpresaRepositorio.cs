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

	#region " EmpresaRepositorio "

	public class EmpresaRepositorio : IEmpresaRepositorio
	{
		#region " Conexão "

		private string _connectionString;

		public EmpresaRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

		#endregion

		#region " Funções/Consultas "

		public async Task<IEnumerable<Empresa>> CarregarDadosEmpresaADSIS01()
		{
			var db = dbConnection();
			var sql = "Select Top 5 EMP_Tid[Id], EMP_Inscricao[Inscricao], CASE WHEN PRF_Tid = 22 THEN 'Eunápolis (22)' ELSE SUBSTRING(PRF_RazaoSocial ,25, LEN(PRF_RazaoSocial )-1) + ' (' + CAST( PRF_Tid AS Varchar(3 )) + ')' END AS Prefeitura, EMP_DataHoraInclusao [DataHoraInclusao] From Empresa With(Nolock) Inner Join Prefeitura With(Nolock) ON (PRF_Tid = EMP_PRF_TidPrefeitura) Order By EMP_Tid Desc";
			var result = await db.QueryAsync<Empresa>(sql, new { });

			return result;
		}

		public async Task<IEnumerable<Empresa>> CarregarDadosEmpresaADSIS02()
		{
			var db = new SqlConnection("Data Source=192.168.30.13; database=ADM_SAATRI; uid=saatri; pwd=nfe3464241A; Pooling=true; Min Pool Size=10; Max Pool Size=100; Connect Timeout=60");
			var sql = "Select Top 5 EMP_Tid[Id], EMP_Inscricao[Inscricao], CASE WHEN PRF_Tid = 22 THEN 'Eunápolis (22)' ELSE SUBSTRING(PRF_RazaoSocial ,25, LEN(PRF_RazaoSocial )-1) + ' (' + CAST( PRF_Tid AS Varchar(3 )) + ')' END AS Prefeitura, EMP_DataHoraInclusao [DataHoraInclusao] From Empresa With(Nolock) Inner Join Prefeitura With(Nolock) ON (PRF_Tid = EMP_PRF_TidPrefeitura) Order By EMP_Tid Desc";
			var result = await db.QueryAsync<Empresa>(sql, new { });

			return result;
		}

		#endregion
	}

	#endregion
}
