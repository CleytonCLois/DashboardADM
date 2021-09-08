using BlazorCRUD.Data.Dapper.Repositorios;
using BlazorCRUD.Model;
using BlazorCRUD.UI.Data;
using BlazorCRUD.UI.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Servicos
{
    public class PrefeituraServico : IPrefeituraServico
	{
		private readonly SqlConfiguration _configuration;
		private IPrefeituraRepositorio _PrefeituraRepositorio;
		public PrefeituraServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_PrefeituraRepositorio = new PrefeituraRepositorio(configuration.ConnectionString);
		}

		public Task<IEnumerable<Prefeitura>> TodasPrefeituras()
		{
			return _PrefeituraRepositorio.TodasPrefeituras();
		}

		public Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas()
		{
			return _PrefeituraRepositorio.PrefeiturasAtualizadas();
		}

		public Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas24Horas()
		{
			return _PrefeituraRepositorio.PrefeiturasAtualizadas24Horas();
		}

		public Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadas()
		{
			return _PrefeituraRepositorio.PrefeiturasDesatualizadas();
		}

		public Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadasMaisDeUmaSemana()
		{
			return _PrefeituraRepositorio.PrefeiturasDesatualizadasMaisDeUmaSemana();
		}
	}
}
