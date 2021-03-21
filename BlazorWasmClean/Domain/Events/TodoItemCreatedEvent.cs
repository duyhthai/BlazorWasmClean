using BlazorWasmClean.Domain.Common;
using BlazorWasmClean.Domain.Entities;

namespace BlazorWasmClean.Domain.Events
{
	public class TodoItemCreatedEvent : DomainEvent
	{
		public TodoItemCreatedEvent(TodoItem item)
		{
			Item = item;
		}

		public TodoItem Item { get; }
	}
}
