using System;
using StoreBackend.Domain.Entities;
using StoreBackend.DomainService;
using StoreBackend.Dto;
using StoreBackend.Exceptions;
using StoreBackend.Facade.Mappers;
using StoreBackend.Infrastructure;

namespace StoreBackend.Facade;

public class UserFacade : IUserFacade
{
    private readonly IUserService userService;
    private readonly AppDbContext context;

    public UserFacade(IUserService userService, AppDbContext contex)
    {
        this.userService = userService;
        this.context = contex;
    }
    public async Task<List<UserDto>> GetAllAsync()
    {
        var entities = await userService.GetAllAsync();
        return UserMapper.ToDto(entities);
    }
}
