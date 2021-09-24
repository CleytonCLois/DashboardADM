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

        Task<IEnumerable<Pessoa>> CarregarDadosPessoaADSIS01();

		Task<IEnumerable<Pessoa>> CarregarDadosPessoaADSIS02();

		#endregion
	}

	#endregion
}
