using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public interface IGraficoRepositorio
	{
		Task<List<Grafico>> PreencherDados();

		Task<List<Grafico>> PrefeiturasAtualizadas();

		Task<List<Grafico>> PrefeiturasAtualizadasUltimas24hrs();

		Task<List<Grafico>> PrefeiturasDesatualizadas();

		Task<List<Grafico>> PrefeiturasDesatualizadasMaisDeUmaSemana();
	}
}
