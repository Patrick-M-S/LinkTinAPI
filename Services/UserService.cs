public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserModel> GetUserAsync(long id)
    {
        return await _userRepository.GetUserAsync(id);
    }
}