public interface IUserService
{
    Task<UserModel> GetUserAsync (long id);
}