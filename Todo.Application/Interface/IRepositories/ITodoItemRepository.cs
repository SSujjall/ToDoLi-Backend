using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.DTOs;
using Todo.Domain.Entities;

namespace Todo.Application.Interface.IRepositories
{
    public interface ITodoItemRepository
    {
        Task<IEnumerable<TodoItem>> GetAll();
        Task<TodoItem> GetById(Guid id);
        Task Add(TodoItemDTO todoDto);
        Task Update(TodoItemDTO todoDto);
        Task Delete(Guid id);
    }
}
