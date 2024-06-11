using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using csumathboy.CleanArch.Core.ProjectAggregate;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.UseCases.Projects.Create;

public class CreateProjectHandler : ICommandHandler<CreateProjectCommand, Result<int>>
{
  private readonly IRepository<Project> _repository;

  public CreateProjectHandler(IRepository<Project> repository)
  {
    _repository = repository;
  }

  public async Task<Result<int>> Handle(CreateProjectCommand request,
    CancellationToken cancellationToken)
  {
    var newProject = new Project(request.Name, PriorityStatus.Backlog);
    var createdItem = await _repository.AddAsync(newProject, cancellationToken);

    return createdItem.Id;
  }
}
