using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
	public interface IGraficoServico
	{
		Task<List<Grafico>> PreencherDados();

		Task<List<Grafico>> PrefeiturasAtualizadas();

		Task<List<Grafico>> PrefeiturasAtualizadasUltimas24hrs();

		Task<List<Grafico>> PrefeiturasDesatualizadas();

		Task<List<Grafico>> PrefeiturasDesatualizadasMaisDeUmaSemana();
	}
}
