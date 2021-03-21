using System.Threading.Tasks;
using BlazorWasmClean.Application.Common.Models;

namespace BlazorWasmClean.Application.Common.Interfaces
{
	public interface IIdentityService
	{
		Task<string> GetUserNameAsync(string userId);

		Task<bool> IsInRoleAsync(string userId, string role);

		Task<bool> AuthorizeAsync(string userId, string policyName);

		Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

		Task<Result> DeleteUserAsync(string userId);
	}
}
