using FluentValidation;

namespace BlazorWasmClean.Application.TodoItems.Commands.CreateTodoItem
{
	public class CreateTodoItemCommandValidator : AbstractValidator<CreateTodoItemCommand>
	{
		public CreateTodoItemCommandValidator()
		{
			RuleFor(v => v.Title)
				.MaximumLength(200)
				.NotEmpty();
		}
	}
}
