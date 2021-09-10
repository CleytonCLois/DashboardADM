using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
	public interface IExemploService
	{
		Task<IEnumerable<Exemplo>> GetAllExemplos();
		//Task<Exemplo> GetDetails(int id);
		//Task<bool> DeleteExemplo(int id);
		//Task<bool> SaveExemplo(Exemplo film);
	}
}
