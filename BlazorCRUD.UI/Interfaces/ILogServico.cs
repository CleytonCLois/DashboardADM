namespace BlazorCRUD.UI.Interfaces
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " ILogServico "

	public interface ILogServico
	{
        #region " Funções "

        Task<IEnumerable<Log>> CarregarDadosLog();

		#endregion
	}

	#endregion
}
