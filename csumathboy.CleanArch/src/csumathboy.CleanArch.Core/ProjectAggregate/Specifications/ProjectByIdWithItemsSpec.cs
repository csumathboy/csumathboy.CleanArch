using Ardalis.Specification;

namespace csumathboy.CleanArch.Core.ProjectAggregate.Specifications;

public class ProjectByIdWithItemsSpec : Specification<Project>
{
  public ProjectByIdWithItemsSpec(int projectId)
  {
    Query
        .Where(project => project.Id == projectId)
        .Include(project => project.Items);
  }
}
