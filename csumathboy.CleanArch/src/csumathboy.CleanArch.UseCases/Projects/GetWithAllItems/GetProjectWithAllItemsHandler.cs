﻿using Ardalis.Result;
using csumathboy.SharedKernel;
using csumathboy.CleanArch.Core.ProjectAggregate;
using csumathboy.CleanArch.Core.ProjectAggregate.Specifications;

namespace csumathboy.CleanArch.UseCases.Projects.GetWithAllItems;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetProjectWithAllItemsHandler : IQueryHandler<GetProjectWithAllItemsQuery, Result<ProjectWithAllItemsDTO>>
{
  private readonly IReadRepository<Project> _repository;

  public GetProjectWithAllItemsHandler(IReadRepository<Project> repository)
  {
    _repository = repository;
  }

  public async Task<Result<ProjectWithAllItemsDTO>> Handle(GetProjectWithAllItemsQuery request, CancellationToken cancellationToken)
  {
    var spec = new ProjectByIdWithItemsSpec(request.ProjectId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    var items = entity.Items
              .Select(i => new ToDoItemDTO(i.Id, i.Title, i.Description, i.IsDone, i.ContributorId)).ToList();
    return new ProjectWithAllItemsDTO(entity.Id, entity.Name, items, entity.Status.ToString())
      ;
  }
}
