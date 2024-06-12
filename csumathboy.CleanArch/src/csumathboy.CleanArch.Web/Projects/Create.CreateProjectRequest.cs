using System.ComponentModel.DataAnnotations;

namespace csumathboy.CleanArch.Web.Projects;

public class CreateProjectRequest
{
  public const string Route = "/Projects";

  [Required]
  public string? Name { get; set; }
}
