using BlazorCRUD.Data.Dapper.Repositorios;
using BlazorCRUD.Model;
using BlazorCRUD.UI.Data;
using BlazorCRUD.UI.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Servicos
{
    public class ExemploService : IExemploService
	{
		private readonly SqlConfiguration _configuration;
		private IExemploRepository _filmRepository;
		public ExemploService(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_filmRepository = new ExemploRepository(configuration.ConnectionString);
		}
		//public Task<bool> DeleteExemplo(int id)
		//{
		//	return _filmRepository.DeleteExemplo(id);
		//}

		public Task<IEnumerable<Exemplo>> GetAllExemplos()
		{
			return _filmRepository.GetAllExemplos();
		}

		//public Task<Exemplo> GetDetails(int id)
		//{
		//	return _filmRepository.GetExemploDetail(id);
		//}

		//public Task<bool> SaveExemplo(Exemplo film)
		//{
		//	if (film.Id == 0)
		//		return _filmRepository.InsertExemplo(film);
		//	else
		//		return _filmRepository.UpdateExemplo(film);
		//}
	}
}
