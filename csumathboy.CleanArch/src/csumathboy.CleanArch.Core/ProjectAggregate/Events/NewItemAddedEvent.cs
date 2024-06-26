﻿using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.Core.ProjectAggregate.Events;
public class NewItemAddedEvent : DomainEventBase
{
  public ToDoItem NewItem { get; set; }
  public Project Project { get; set; }

  public NewItemAddedEvent(Project project,
      ToDoItem newItem)
  {
    Project = project;
    NewItem = newItem;
  }
}
