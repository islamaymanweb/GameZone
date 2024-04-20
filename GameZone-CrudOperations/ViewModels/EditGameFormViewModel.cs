using GameZone_CrudOperations.Attributes;
using GameZone_CrudOperations.Settings;

namespace GameZone_CrudOperations.ViewModels
{
	public class EditGameFormViewModel:GameFormViewModel
	{
		public int Id { get; set; }

		public string? CurrentCover { get; set; }

		[AllowedExtensions(FileSettings.AllowedExtensions),
			MaxFileSize(FileSettings.MaxFileSizeInBytes)]
		public IFormFile? Cover { get; set; } = default!;
	}
}
