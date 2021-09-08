using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
	public interface IPrefeituraServico
	{
		Task<IEnumerable<Prefeitura>> TodasPrefeituras();
		Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas();
		Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas24Horas();
		Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadas();
		Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadasMaisDeUmaSemana();

	}
}
