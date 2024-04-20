using GameZone_CrudOperations.Attributes;
using GameZone_CrudOperations.Settings;

namespace GameZone_CrudOperations.ViewModels
{
	public class CreateGameFormViewModel: GameFormViewModel
	{
		[AllowedExtensions(FileSettings.AllowedExtensions),
	MaxFileSize(FileSettings.MaxFileSizeInBytes)]
		public IFormFile Cover { get; set; } = default!;
	}
}
