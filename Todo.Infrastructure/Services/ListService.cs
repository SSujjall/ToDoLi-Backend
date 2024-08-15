using Microsoft.AspNetCore.Identity;
using Todo.Application.DTOs;
using Todo.Application.Interface.IRepositories;
using Todo.Application.Interface.IServices;
using Todo.Domain.Entities;

namespace Todo.Infrastructure.Services
{
    public class ListService : IListService
    {
        private readonly IListRepository _listRepository;
        private readonly UserManager<User> _userManager;

        public ListService(IListRepository listRepository, UserManager<User> userManager)
        {
            _listRepository = listRepository;
            _userManager = userManager;
        }

        public Task<string> AddList(AddListDTO addListDto, List<string> errors)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteList(int id, List<string> errors)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateList(UpdateListDTO updateListDto, List<string> errors)
        {
            throw new NotImplementedException();
        }
    }
}