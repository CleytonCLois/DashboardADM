namespace BlazorCRUD.Data.Dapper.Repositorios
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

    #endregion

    #region " IGraficoRepositorio "

    public interface IGraficoRepositorio
	{
		#region " Funções "

		Task<IEnumerable<Grafico>> TopPrefeituras();

		Task<IEnumerable<Grafico>> Teste();

		#endregion
	}

	#endregion
}
