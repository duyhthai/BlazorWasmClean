using BlazorWasmClean.Domain.Common;
using BlazorWasmClean.Domain.Entities;

namespace BlazorWasmClean.Domain.Events
{
	public class TodoItemCompletedEvent : DomainEvent
	{
		public TodoItemCompletedEvent(TodoItem item)
		{
			Item = item;
		}

		public TodoItem Item { get; }
	}
}
