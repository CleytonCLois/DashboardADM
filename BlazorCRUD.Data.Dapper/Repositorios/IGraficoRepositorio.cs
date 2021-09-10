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

		Task<List<Grafico>> PreencherDados();

		Task<List<Grafico>> PrefeiturasAtualizadas();

		Task<List<Grafico>> PrefeiturasAtualizadasUltimas24hrs();

		Task<List<Grafico>> PrefeiturasDesatualizadas();

		Task<List<Grafico>> PrefeiturasDesatualizadasMaisDeUmaSemana();

		#endregion
	}

    #endregion
}
