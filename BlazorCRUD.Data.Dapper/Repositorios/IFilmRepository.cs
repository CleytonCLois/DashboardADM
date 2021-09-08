using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public interface IFilmRepository
	{
		Task<IEnumerable<Film>> GetAllFilms();
		//Task<Film> GetFilmDetail(int id);
		//Task<bool> InsertFilm(Film film);
		//Task<bool> UpdateFilm(Film film);
		//Task<bool> DeleteFilm(int id);
	}
}
