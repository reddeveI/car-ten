using CargoTender.Application.TodoLists.Queries.ExportTodos;

namespace CargoTender.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
