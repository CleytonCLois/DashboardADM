using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public interface IConfiguracaoRepositorio
	{
		Task<IEnumerable<Configuracao>> TodasConfiguracoes();
	
		Task<bool> UpdateConfiguracao(Configuracao configuracao);
	}
}
