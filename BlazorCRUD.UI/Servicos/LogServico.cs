namespace BlazorCRUD.UI.Servicos
{
	#region " Usings "

	using BlazorCRUD.Data.Dapper.Repositorios;
	using BlazorCRUD.Model;
	using BlazorCRUD.UI.Data;
	using BlazorCRUD.UI.Interfaces;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " LogServico "

	public class LogServico : ILogServico
	{
		#region " Conexão "

		private readonly SqlConfiguration _configuration;

		private ILogRepositorio _LogRepositorio;

		public LogServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_LogRepositorio = new LogRepositorio(configuration.ConnectionString);
		}

		#endregion

		#region " Funções "

		public Task<IEnumerable<Log>> CarregarDadosLog()
		{
			return _LogRepositorio.CarregarDadosLog();
		}

		#endregion
	}

	#endregion
}
