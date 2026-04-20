using System;
using StoreBackend.Domain.Entities;
using StoreBackend.Dto;
using StoreBackend.Exceptions;
using StoreBackend.Infrastructure.Repositories;

namespace StoreBackend.DomainService;

public class UserService : IUserService
{
    private readonly IUserRepository _userRespository;
    
    public UserService(IUserRepository userRepository)
    {
        _userRespository = userRepository;
    }
    public Task<List<User>> GetAllAsync()
    {
        return _userRespository.GetAllAsync();
    } 
}
