namespace BlazorCRUD.UI.Interfaces
{
    #region " Usings "

    using BlazorCRUD.Model;
    using System.Threading.Tasks;

    #endregion

    #region " IConfiguracaoServico "

    public interface IConfiguracaoServico
	{
        #region " Funções "

        int ConfiguracaoAtual();
		
		Task<bool> UpdateConfiguracao(Configuracao configuracao);

        #endregion
    }

    #endregion
}
