using CargoTender.Application.Common.Mappings;
using CargoTender.Domain.Entities;

namespace CargoTender.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
