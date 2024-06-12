using System.ComponentModel.DataAnnotations;

namespace csumathboy.CleanArch.Web.Projects;

public class UpdateProjectRequest
{
  public const string Route = "/Projects";
  [Required]
  public int Id { get; set; }
  [Required]
  public string? Name { get; set; }
}
