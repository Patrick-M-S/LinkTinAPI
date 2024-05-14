public interface IUserRepository
{
    Task<UserModel> GetUserAsync(long id);
}