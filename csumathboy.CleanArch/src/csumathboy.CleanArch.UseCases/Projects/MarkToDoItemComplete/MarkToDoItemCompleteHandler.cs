﻿using Ardalis.Result;
using csumathboy.SharedKernel;
using csumathboy.CleanArch.Core.ProjectAggregate;
using csumathboy.CleanArch.Core.ProjectAggregate.Specifications;

namespace csumathboy.CleanArch.UseCases.Projects.MarkToDoItemComplete;

public class MarkToDoItemCompleteHandler : ICommandHandler<MarkToDoItemCompleteCommand, Result>
{
  private readonly IRepository<Project> _repository;

  public MarkToDoItemCompleteHandler(IRepository<Project> repository)
  {
    _repository = repository;
  }

  public async Task<Result> Handle(MarkToDoItemCompleteCommand request,
    CancellationToken cancellationToken)
  {
    var spec = new ProjectByIdWithItemsSpec(request.ProjectId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound("Project not found.");

    var item = entity.Items.FirstOrDefault(i => i.Id == request.ToDoItemId);
    if (item == null) return Result.NotFound("Item not found.");

    item.MarkComplete();
    await _repository.UpdateAsync(entity);

    return Result.Success();
  }
}
