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

        Task<IEnumerable<Grafico>> DadosPrefeituraGrafico(int situacao);

        #endregion
    }

    #endregion
}
