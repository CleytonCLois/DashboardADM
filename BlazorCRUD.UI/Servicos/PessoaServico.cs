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

	#region " PessoaServico "

	public class PessoaServico : IPessoaServico
	{
		#region " Conexão "

		private readonly SqlConfiguration _configuration;

		private IPessoaRepositorio _PessoaRepositorio;

		public PessoaServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_PessoaRepositorio = new PessoaRepositorio(configuration.ConnectionString);
		}

		#endregion

		#region " Funções "

		public Task<IEnumerable<Pessoa>> CarregarDadosPessoa()
		{
			return _PessoaRepositorio.CarregarDadosPessoa();
		}

		#endregion
	}

	#endregion
}
