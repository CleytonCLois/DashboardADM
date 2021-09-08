using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
	public interface IPrefeituraRepositorio
	{
		Task<IEnumerable<Prefeitura>> TodasPrefeituras();
		Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas();
		Task<IEnumerable<Prefeitura>> PrefeiturasAtualizadas24Horas();
		Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadas();
		Task<IEnumerable<Prefeitura>> PrefeiturasDesatualizadasMaisDeUmaSemana();
	}
}
