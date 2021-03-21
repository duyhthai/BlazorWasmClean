using System;
using BlazorWasmClean.Application.Common.Interfaces;

namespace BlazorWasmClean.Infrastructure.Services
{
	public class DateTimeService : IDateTime
	{
		public DateTime Now => DateTime.Now;
	}
}
