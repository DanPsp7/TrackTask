using TaskTracker.DTO;

namespace TaskTracker.Services;

public interface IUserService
{
    Task<List<UserDTO>> GetUser();
    //Task GetProjectById(int id);
    Task CreateUser(UserDTO UserDto);
    Task UpdateUser(int id, UserDTO userDto);
    Task DeleteUser(int id);
}