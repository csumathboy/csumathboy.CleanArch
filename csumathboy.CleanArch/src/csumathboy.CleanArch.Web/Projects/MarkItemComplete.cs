﻿using FastEndpoints;
using MediatR;
using csumathboy.CleanArch.UseCases.Projects.MarkToDoItemComplete;

namespace csumathboy.CleanArch.Web.ProjectEndpoints;

/// <summary>
/// Mark an item as complete
/// </summary>
public class MarkItemComplete : Endpoint<MarkItemCompleteRequest>
{
  private readonly IMediator _mediator;

  public MarkItemComplete(IMediator mediator)
  {
    _mediator = mediator;
  }

  public override void Configure()
  {
    Post(MarkItemCompleteRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new MarkItemCompleteRequest
      {
        ProjectId = 1,
        ToDoItemId = 1
      };
    });
  }

  public override async Task HandleAsync(
    MarkItemCompleteRequest request,
    CancellationToken cancellationToken)
  {
    var command = new MarkToDoItemCompleteCommand(request.ProjectId, request.ToDoItemId);
    var result = await _mediator.Send(command);

    if (result.Status == Ardalis.Result.ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      await SendNoContentAsync(cancellationToken);
    };
    // TODO: Handle other issues as needed
  }

}
