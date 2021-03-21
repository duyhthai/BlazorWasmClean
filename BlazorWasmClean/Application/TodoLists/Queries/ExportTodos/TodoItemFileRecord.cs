using BlazorWasmClean.Application.Common.Mappings;
using BlazorWasmClean.Domain.Entities;

namespace BlazorWasmClean.Application.TodoLists.Queries.ExportTodos
{
	public class TodoItemRecord : IMapFrom<TodoItem>
	{
		public string Title { get; set; }

		public bool Done { get; set; }
	}
}
