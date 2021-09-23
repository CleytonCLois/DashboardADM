namespace BlazorCRUD.Data.Dapper.Repositorios
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " IPessoaRepositorio "

	public interface IPessoaRepositorio
	{
		#region " Funções "
		Task<IEnumerable<Pessoa>> CarregarDadosPessoa();

		#endregion
	}

    #endregion
}
