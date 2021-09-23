﻿namespace BlazorCRUD.Data.Dapper.Repositorios
{
	#region " Usings "

	using BlazorCRUD.Model;
	using global::Dapper;
	using System;
	using System.Collections.Generic;
	using System.Data.SqlClient;
	using System.Threading.Tasks;

	#endregion

	#region " NotaFiscalRepositorio "

	public class NotaFiscalRepositorio : INotaFiscalRepositorio
	{
		#region " Conexão "

		private string _connectionString;

		public NotaFiscalRepositorio(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}

		#endregion

		#region " Funções/Consultas "

		public async Task<IEnumerable<NotaFiscal>> CarregarDadosNotaFiscal()
		{
			var db = dbConnection();
			var sql = "Select Top 5 DOF_Tid[Id], DOF_Numero[Numero], CASE WHEN PRF_Tid = 22 THEN 'Eunápolis (22)' ELSE SUBSTRING(PRF_RazaoSocial ,25, LEN(PRF_RazaoSocial )-1) + ' (' + CAST( PRF_Tid AS Varchar(3 )) + ')' END AS Prefeitura, DOF_DataHoraCadastro[DataHoraCadastro] From DocumentoFiscal With(Nolock) Inner Join Prefeitura With(Nolock) ON (PRF_Tid = DOF_PFE_TidPrefeituraEndereco) Order By DOF_Tid Desc";
			var result = await db.QueryAsync<NotaFiscal>(sql, new { });

			return result;
		}

		#endregion
	}

	#endregion
}
