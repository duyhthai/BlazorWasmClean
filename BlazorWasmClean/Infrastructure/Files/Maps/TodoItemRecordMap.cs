using System.Globalization;
using BlazorWasmClean.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace BlazorWasmClean.Infrastructure.Files.Maps
{
	public class TodoItemRecordMap : ClassMap<TodoItemRecord>
	{
		public TodoItemRecordMap()
		{
			AutoMap(CultureInfo.InvariantCulture);
			////Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
		}
	}
}
