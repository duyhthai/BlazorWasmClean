using System;

namespace BlazorWasmClean.Application.Common.Exceptions
{
	public class ForbiddenAccessException : Exception
	{
		public ForbiddenAccessException() : base() { }
	}
}
