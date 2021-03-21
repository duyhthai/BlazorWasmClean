using BlazorWasmClean.Domain.Common;
using MediatR;

namespace BlazorWasmClean.Application.Common.Models
{
	public class DomainEventNotification<TDomainEvent> : INotification where TDomainEvent : DomainEvent
	{
		public DomainEventNotification(TDomainEvent domainEvent)
		{
			DomainEvent = domainEvent;
		}

		public TDomainEvent DomainEvent { get; }
	}
}
