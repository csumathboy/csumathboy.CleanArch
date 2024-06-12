using FastEndpoints;
using FluentValidation;
using csumathboy.CleanArch.Infrastructure.Data.Config;

namespace csumathboy.CleanArch.Web.Projects;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class CreateToDoItemValidator : Validator<CreateToDoItemRequest>
{
  public CreateToDoItemValidator()
  {
    RuleFor(x => x.ProjectId)
      .GreaterThan(0);
    RuleFor(x => x.Title)
      .NotEmpty()
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
    RuleFor(x => x.Description)
      .NotEmpty();
  }
}
