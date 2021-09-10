using BlazorCRUD.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public class ExemploRepository : IExemploRepository
	{
		private string _connectionString;
		public ExemploRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}
		//public async Task<bool> DeleteExemplo(int id)
		//{
		//	var db = dbConnection();
		//	var sql = "DELETE FROM Exemplos WHERE Id = @Id";

		//	var result = await db.ExecuteAsync(sql, new { Id = id });

		//	return result > 0;
		//}

		public async Task<IEnumerable<Exemplo>> GetAllExemplos()
		{
			var db = dbConnection();

			var sql = "SELECT Id, SituacaoAlmoxarifadoId, ControlarRequisicao FROM Almoxarifado.Almoxarifado";

			return await db.QueryAsync<Exemplo>(sql, new { });
		}

		//public async Task<Exemplo> GetExemploDetail(int id)
		//{
		//	var db = dbConnection();
		//	var sql = "SELECT Id, Title, Director, ReleaseDate " +
		//		"FROM [dbo].[Exemplos] WHERE Id = @Id";

		//	return await db.QueryFirstOrDefaultAsync<Exemplo>(sql, new { Id = id });
		//}

		//public async Task<bool> InsertExemplo(Exemplo film)
		//{
		//	var db = dbConnection();
		//	var sql = "INSERT INTO Exemplos (Title, Director, ReleaseDate)" +
		//		"VALUES(@Title, @Director, @ReleaseDate)";

		//	var result = await db.ExecuteAsync(sql, new { film.Title, 
		//		film.Director, film.ReleaseDate });

		//	return result > 0;
		//}

		//public async Task<bool> UpdateExemplo(Exemplo film)
		//{
		//	var db = dbConnection();
		//	var sql = "UPDATE Exemplos SET Title = @Title, " +
		//		"Director = @Director, ReleaseDate = @ReleaseDate " +
		//		"WHERE Id = @Id";

		//	var result = await db.ExecuteAsync(sql, 
		//		new { film.Title, film.Director, film.ReleaseDate, film.Id });

		//	return result > 0;
		//}
	}
}
