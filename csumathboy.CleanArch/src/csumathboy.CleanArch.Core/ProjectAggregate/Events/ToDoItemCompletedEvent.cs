using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csumathboy.SharedKernel;

namespace csumathboy.CleanArch.Core.ProjectAggregate.Events;
public class ToDoItemCompletedEvent : DomainEventBase
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
