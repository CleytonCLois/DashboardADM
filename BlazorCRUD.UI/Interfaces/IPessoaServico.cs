namespace BlazorCRUD.UI.Interfaces
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " IPessoaServico "

	public interface IPessoaServico
	{
        #region " Funções "

        Task<IEnumerable<Pessoa>> CarregarDadosPessoa();

		#endregion
	}

	#endregion
}
