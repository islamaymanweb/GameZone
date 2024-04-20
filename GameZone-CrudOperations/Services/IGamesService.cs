using GameZone_CrudOperations.Models;
using GameZone_CrudOperations.ViewModels;

namespace GameZone_CrudOperations.Services
{
	public interface IGamesService
	{
		IEnumerable<Game> GetAll();
		Game? GetById(int id);
		Task Create(CreateGameFormViewModel model);
		Task<Game?> Update(EditGameFormViewModel model);
		bool Delete(int id);
	}
}
