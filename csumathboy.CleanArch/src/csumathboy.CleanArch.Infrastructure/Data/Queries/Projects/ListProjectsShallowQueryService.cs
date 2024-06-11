﻿using Microsoft.EntityFrameworkCore;
using csumathboy.CleanArch.UseCases.Projects.ListShallow;
using csumathboy.CleanArch.UseCases.Projects;

namespace csumathboy.CleanArch.Infrastructure.Data.Queries;

public class ListProjectsShallowQueryService(AppDbContext db) : 
  IListProjectsShallowQueryService
{
  private readonly AppDbContext _db = db;

  public async Task<IEnumerable<ProjectDTO>> ListAsync()
  {
    var result = await _db.Projects.FromSqlRaw("SELECT Id, Name FROM Projects") // don't fetch other big columns
      .Select(x => new ProjectDTO(x.Id, x.Name, x.Status.ToString()))
      .ToListAsync();

    return result;
  }
}
