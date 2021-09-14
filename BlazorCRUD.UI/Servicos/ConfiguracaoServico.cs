using BlazorCRUD.Data.Dapper.Repositorios;
using BlazorCRUD.Model;
using BlazorCRUD.UI.Data;
using BlazorCRUD.UI.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Servicos
{
    public class ConfiguracaoServico : IConfiguracaoServico
	{
		private readonly SqlConfiguration _configuration;

		private IConfiguracaoRepositorio configuracaoRepositorio;

		public ConfiguracaoServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			configuracaoRepositorio = new ConfiguracaoRepositorio(configuration.ConnectionString);
		}

		public Task<IEnumerable<Configuracao>> TodasConfiguracoes()
		{
			return configuracaoRepositorio.TodasConfiguracoes();
		}

        public Task<bool> UpdateConfiguracao(Configuracao configuracao)
        {
			return configuracaoRepositorio.UpdateConfiguracao(configuracao);
        }
    }
}
