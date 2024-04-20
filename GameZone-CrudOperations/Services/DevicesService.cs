﻿using GameZone_CrudOperations.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GameZone_CrudOperations.Services
{
	public class DevicesService : IDevicesService
	{
		private readonly ApplicationDbContext _context;

		public DevicesService(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<SelectListItem> GetSelectList()
		{
			return _context.Devices
			.Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name })
			.OrderBy(d => d.Text)
			.AsNoTracking()
			.ToList();
		}
	}
}
