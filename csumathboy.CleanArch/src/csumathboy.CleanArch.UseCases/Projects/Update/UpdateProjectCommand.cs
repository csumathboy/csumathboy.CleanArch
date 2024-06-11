using Ardalis.Result;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.UseCases.Projects.Update;

public record UpdateProjectCommand(int ProjectId, string NewName) : ICommand<Result<ProjectDTO>>;
