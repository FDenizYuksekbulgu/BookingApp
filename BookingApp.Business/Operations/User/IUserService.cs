using BookingApp.Business.Operations.User.Dtos;
using BookingApp.Business.Types;

namespace BookingApp.Business.Operations.User
{
    public interface IUserService
    {
        // bool / string / T?
        Task<ServiceMessage> AddUser(AddUserDto user); // async çünkü UnitOfWork kullanılacak.
        
        ServiceMessage<UserInfoDto> LoginUser(LoginUserDto user);
    }
}