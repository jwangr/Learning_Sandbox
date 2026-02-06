// Creating DTO model (i.e. secret fields, only admin can uncover)
// Update controller to use DTO

namespace TodoApi.Models;

public class TodoItemDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}