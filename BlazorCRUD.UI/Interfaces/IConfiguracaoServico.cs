using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
    public interface IConfiguracaoServico
	{
		int ConfiguracaoAtual();
		
		Task<bool> UpdateConfiguracao(Configuracao configuracao);
	}
}
