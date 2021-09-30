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

        Task<IEnumerable<Grafico>> TopPrefeituras();

        Task<IEnumerable<Grafico>> Teste();

        #endregion
    }

    #endregion
}
