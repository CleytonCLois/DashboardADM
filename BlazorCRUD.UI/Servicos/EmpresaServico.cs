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

	#region " EmpresaServico "

	public class EmpresaServico : IEmpresaServico
	{
		#region " Conexão "

		private readonly SqlConfiguration _configuration;

		private IEmpresaRepositorio _EmpresaRepositorio;

		public EmpresaServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_EmpresaRepositorio = new EmpresaRepositorio(configuration.ConnectionString);
		}

		#endregion

		#region " Funções "

		public Task<IEnumerable<Empresa>> CarregarDadosEmpresa()
		{
			return _EmpresaRepositorio.CarregarDadosEmpresa();
		}

		#endregion
	}

	#endregion
}
