using Ardalis.Result;
using csumathboy.CleanArch.Core.ProjectAggregate;

namespace csumathboy.CleanArch.Core.Interfaces;
public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
