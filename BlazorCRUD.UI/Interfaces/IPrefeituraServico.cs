namespace BlazorCRUD.UI.Interfaces
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

    #endregion

    #region " IPrefeituraServico "

    public interface IPrefeituraServico
	{
        #region " Funções "

        Task<IEnumerable<Prefeitura>> TodasPrefeituras();

		Task<IEnumerable<Prefeitura>> ListaDePrefeituras(int situacao);

		#endregion
	}

	#endregion
}
