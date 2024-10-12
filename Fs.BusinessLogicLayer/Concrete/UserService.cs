using AutoMapper;
using FluentValidation;
using Fs.BusinessLogicLayer.Abstract;
using Fs.BusinessLogicLayer.Dtos;
using Fs.DataAccessLayer.EntityFrameworkCore.Abstract;
using Fs.Entity.Accounts;
using FS.CoreLayer.Enums;
using FS.CoreLayer.Extentions;
using FS.CoreLayer.Helper;
using FS.CoreLayer.Wrappers.Implementations;
using FS.CoreLayer.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.BusinessLogicLayer.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserDetailRepository _userDetailRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateUserDto> _createUserDtoValidator;

        public UserService(IUserRepository userRepository, IUserDetailRepository userDetailRepository, IMapper mapper, IValidator<CreateUserDto> createUserDtoValidator)
        {
            _userRepository = userRepository;
            _userDetailRepository = userDetailRepository;
            _mapper = mapper;
            _createUserDtoValidator = createUserDtoValidator;
        }
        public async Task<IResponseDataResult<RegisterUserDto>> CreateUserAsync(CreateUserDto userDto)
        {
          var validitionResult= await _createUserDtoValidator.ValidateAsync(userDto);
            if (validitionResult.IsValid is false) 
            {
                return new ResponseDataResult<RegisterUserDto>(validitionResult.ToResponseValidationResults());
            }
            var user = _userRepository
                .GetWhereAsync(x => x.Email == userDto.Email)
                .Any();
          if(user is true)
            {
                return new ResponseDataResult<RegisterUserDto>([
                    new(){
                        ErrorMessage="Email is registered in the system",
                        PropertyName="Email"
                    }
                    ]);
            }


            byte[] passwordHash;
            byte[] PasswordSalt;

            var userEntity = _mapper.Map<User>(userDto);
            userEntity.UserDetail = _mapper.Map<UserDetail>(userDto);


            HasHelper.CreatePasswordHash(userDto.Password, out passwordHash, out PasswordSalt);
            userEntity.PassworHash=passwordHash.ByteToString();
            userEntity.PasswordSalt=PasswordSalt.ByteToString();

            userEntity.UserDetail.ConfirmCode = GeneratorHelper.GeneratorConfirmCode();
            userEntity.UserDetail.StatusId = (int)RegisterStatusEnam.RegisterUser;
            userEntity.UserRoles =
            [
                new() { RoleId=1}
            ];
            await _userRepository.AddAsync(userEntity);
           try
            {
                await _userRepository.SaveChangesAsync();
            }
            catch (Exception E)
            {
                var ex = E;
            }

            return new ResponseDataResult<RegisterUserDto>( new RegisterUserDto()
            {
                Id = userEntity.Id,
                Email = userEntity.Email,
                FirstName = userEntity.UserDetail.FirstName,
                LastName = userEntity.UserDetail.LastName,
                ConfirmCode = userEntity.UserDetail.ConfirmCode
            });
        }
    }
}
