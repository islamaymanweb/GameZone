using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone_CrudOperations.Services
{
	public interface ICategoriesService
	{
		IEnumerable<SelectListItem> GetSelectList();
	}
}

