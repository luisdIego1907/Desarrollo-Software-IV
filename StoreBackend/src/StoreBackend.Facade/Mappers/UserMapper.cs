using System;
using System.Net.NetworkInformation;
using StoreBackend.Domain.Entities;
using StoreBackend.DomainService;
using StoreBackend.Dto;

namespace StoreBackend.Facade.Mappers;

public class UserMapper
{


    public static UserDto ToDto(User user)
    {
        return new UserDto
        {
            
            Username = user.Username
        };
    }

    public static List<UserDto> ToDto(List<User> users)
    {
        return users.Select(u => ToDto(u)).ToList();
    }
}
