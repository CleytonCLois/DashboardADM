namespace BlazorCRUD.Data.Dapper.Repositorios
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " ILogRepositorio "

	public interface ILogRepositorio
	{
		#region " Funções "
		Task<IEnumerable<Log>> CarregarDadosLog();

		#endregion
	}

    #endregion
}
