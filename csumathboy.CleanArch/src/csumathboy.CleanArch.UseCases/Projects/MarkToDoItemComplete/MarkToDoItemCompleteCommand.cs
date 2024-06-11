using Ardalis.Result;

namespace csumathboy.CleanArch.UseCases.Projects.MarkToDoItemComplete;

/// <summary>
/// Create a new Project.
/// </summary>
/// <param name="Name"></param>
public record MarkToDoItemCompleteCommand(int ProjectId, int ToDoItemId) : csumathboy.SharedKernel.ICommand<Result>;
