using Ardalis.Result;

namespace csumathboy.CleanArch.UseCases.Contributors.Create;
/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateContributorCommand(string Name, string? PhoneNumber) : csumathboy.SharedKernel.ICommand<Result<int>>;
