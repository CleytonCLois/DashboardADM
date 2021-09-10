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
		Task<IEnumerable<Prefeitura>> TodasPrefeituras();

		Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas();

		Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas24Horas();

		Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadas();

		Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadasMaisDeUmaSemana();
	}

    #endregion
}
