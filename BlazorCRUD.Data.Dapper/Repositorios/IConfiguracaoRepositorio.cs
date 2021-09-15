using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public interface IConfiguracaoRepositorio
	{
		int ConfiguracaoAtual();
	
		Task<bool> UpdateConfiguracao(Configuracao configuracao);
	}
}
