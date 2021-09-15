using BlazorCRUD.Data.Dapper.Repositorios;
using BlazorCRUD.Model;
using BlazorCRUD.UI.Data;
using BlazorCRUD.UI.Interfaces;
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

		public int ConfiguracaoAtual()
		{
			return configuracaoRepositorio.ConfiguracaoAtual();
		}

        public Task<bool> UpdateConfiguracao(Configuracao configuracao)
        {
			return configuracaoRepositorio.UpdateConfiguracao(configuracao);
        }
    }
}
