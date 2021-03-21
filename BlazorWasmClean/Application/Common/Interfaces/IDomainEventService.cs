using System.Threading.Tasks;
using BlazorWasmClean.Domain.Common;

namespace BlazorWasmClean.Application.Common.Interfaces
{
	public interface IDomainEventService
	{
		Task Publish(DomainEvent domainEvent);
	}
}
