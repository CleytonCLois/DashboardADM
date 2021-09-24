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

	#region " NotaFiscalServico "

	public class NotaFiscalServico : INotaFiscalServico
	{
		#region " Conexão "

		private readonly SqlConfiguration _configuration;

		private INotaFiscalRepositorio _NotaFiscalRepositorio;

		public NotaFiscalServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_NotaFiscalRepositorio = new NotaFiscalRepositorio(configuration.ConnectionString);
		}

		#endregion

		#region " Funções "

		public Task<IEnumerable<NotaFiscal>> CarregarDadosNotaFiscalADSIS01()
		{
			return _NotaFiscalRepositorio.CarregarDadosNotaFiscalADSIS01();
		}
			
		public Task<IEnumerable<NotaFiscal>> CarregarDadosNotaFiscalADSIS02()
		{
			return _NotaFiscalRepositorio.CarregarDadosNotaFiscalADSIS02();
		}

		#endregion
	}

	#endregion
}
