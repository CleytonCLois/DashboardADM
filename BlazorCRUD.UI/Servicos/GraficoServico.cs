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

    #region " GraficoServico "

    public class GraficoServico : IGraficoServico
	{
        #region " Conexão "

        private readonly SqlConfiguration _configuration;

		private IGraficoRepositorio _GraficoRepositorio;

		public GraficoServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_GraficoRepositorio = new GraficoRepositorio(configuration.ConnectionString);
		}

		#endregion

		#region " Funções "

		public Task<IEnumerable<Grafico>> DadosGraficoMaioresEmissoresDeNFE()
		{
			return _GraficoRepositorio.DadosGraficoMaioresEmissoresDeNFE();
		}

		public Task<IEnumerable<Grafico>> DadosGraficoProcessamentoDeLote()
		{
			return _GraficoRepositorio.DadosGraficoProcessamentoDeLote();
		}

		#endregion
	}

	#endregion
}
