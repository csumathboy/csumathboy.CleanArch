using Ardalis.Result;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.UseCases.Projects.Delete;

public record DeleteProjectCommand(int ProjectId) : ICommand<Result>;
