namespace BlazorCRUD.UI.Servicos
{
	#region " Usings "

	using BlazorCRUD.Data.Dapper.Repositorios;
	using BlazorCRUD.Model;
	using BlazorCRUD.UI.Data;
	using BlazorCRUD.UI.Interfaces;
	using System.Threading.Tasks;

    #endregion

    #region " ConfiguracaoServico "

    public class ConfiguracaoServico : IConfiguracaoServico
	{
        #region " Conexão "

        private readonly SqlConfiguration _configuration;

		private IConfiguracaoRepositorio configuracaoRepositorio;

		public ConfiguracaoServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			configuracaoRepositorio = new ConfiguracaoRepositorio(configuration.ConnectionString);
		}

        #endregion

        #region " Funções "

        public int ConfiguracaoAtual()
		{
			return configuracaoRepositorio.ConfiguracaoAtual();
		}

        public Task<bool> UpdateConfiguracao(Configuracao configuracao)
        {
			return configuracaoRepositorio.UpdateConfiguracao(configuracao);
        }

        #endregion
    }

    #endregion
}
