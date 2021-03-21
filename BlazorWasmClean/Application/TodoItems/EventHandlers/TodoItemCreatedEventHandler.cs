using System.Threading;
using System.Threading.Tasks;
using BlazorWasmClean.Application.Common.Models;
using BlazorWasmClean.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BlazorWasmClean.Application.TodoItems.EventHandlers
{
	public class TodoItemCreatedEventHandler : INotificationHandler<DomainEventNotification<TodoItemCreatedEvent>>
	{
		private readonly ILogger<TodoItemCompletedEventHandler> _logger;

		public TodoItemCreatedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
		{
			_logger = logger;
		}

		public Task Handle(DomainEventNotification<TodoItemCreatedEvent> notification, CancellationToken cancellationToken)
		{
			var domainEvent = notification.DomainEvent;

			_logger.LogInformation("BlazorWasmClean Domain Event: {DomainEvent}", domainEvent.GetType().Name);

			return Task.CompletedTask;
		}
	}
}
