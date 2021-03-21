using System.Threading;
using System.Threading.Tasks;
using BlazorWasmClean.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasmClean.Application.Common.Interfaces
{
	public interface IApplicationDbContext
	{
		DbSet<TodoList> TodoLists { get; set; }

		DbSet<TodoItem> TodoItems { get; set; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
