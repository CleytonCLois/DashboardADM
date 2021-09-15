namespace BlazorCRUD.UI.Interfaces
{
    #region " Usings "

    using BlazorCRUD.Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #endregion

    #region " IGraficoServico "

    public interface IGraficoServico
	{

        #region " Funções "

        Task<List<Grafico>> PreencherDados();

		Task<List<Grafico>> PrefeiturasAtualizadas();

		Task<List<Grafico>> PrefeiturasAtualizadasUltimas24hrs();

		Task<List<Grafico>> PrefeiturasDesatualizadas();

		Task<List<Grafico>> PrefeiturasDesatualizadasMaisDeUmaSemana();
        
		#endregion
    }

    #endregion
}
