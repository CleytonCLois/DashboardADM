namespace BlazorCRUD.Data.Dapper.Repositorios
{
    #region " Usings "

    using BlazorCRUD.Model;
    using System.Threading.Tasks;

    #endregion

    #region " IConfiguracaoRepositorio "

    public interface IConfiguracaoRepositorio
	{
        #region " Funções "

        int ConfiguracaoAtual();
	
		Task<bool> UpdateConfiguracao(Configuracao configuracao);

        #endregion
    }

    #endregion
}
