namespace BlazorCRUD.Data.Dapper.Repositorios
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Threading.Tasks;

    #endregion

    #region " IPrefeituraRepositorio "

    public interface IPrefeituraRepositorio
	{
        #region " Funções "

        Task<IEnumerable<Prefeitura>> TodasPrefeituras();

		Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas();

		Task<IEnumerable<Prefeitura>> ListaDePrefeituras(int situacao);

		#endregion
	}

    #endregion
}
