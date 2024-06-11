 
using Ardalis.Result;

namespace csumathboy.CleanArch.UseCases.Projects.Create;
/// <summary>
/// Create a new Project.
/// </summary>
/// <param name="Name"></param>
public record CreateProjectCommand(string Name) : csumathboy.SharedKernel.ICommand<Result<int>>;
