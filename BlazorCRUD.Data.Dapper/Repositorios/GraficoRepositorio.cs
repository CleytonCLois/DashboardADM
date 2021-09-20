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

		#endregion
	}

	#endregion
}
