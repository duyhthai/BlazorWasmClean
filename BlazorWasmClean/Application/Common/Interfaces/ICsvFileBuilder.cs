using System.Collections.Generic;
using BlazorWasmClean.Application.TodoLists.Queries.ExportTodos;

namespace BlazorWasmClean.Application.Common.Interfaces
{
	public interface ICsvFileBuilder
	{
		byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
	}
}
