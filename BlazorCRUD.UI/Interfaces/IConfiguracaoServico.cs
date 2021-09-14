﻿using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
    public interface IConfiguracaoServico
	{
		Task<IEnumerable<Configuracao>> TodasConfiguracoes();
		
		Task<bool> UpdateConfiguracao(Configuracao configuracao);
	}
}
