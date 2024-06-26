﻿using DatingLoveApp.Business.Dtos;
using DatingLoveApp.Business.Dtos.LocalUserDtos;
using FluentResults;

namespace DatingLoveApp.Business.Interfaces;

public interface IUserService
{
    Task<PagedList<AppUserDto>> GetAllAsync(string id, UserParams userParams);

    Task<Result<AppUserDetailDto>> GetByIdAsync(string id);

    Task<Result<AppUserDetailDto>> GetByUsernameAsync(string username);

    Task<Result> UpdateAsync(UpdateAppUserDto userDto);

    Task<Result> RemoveAsync(string id);
}
