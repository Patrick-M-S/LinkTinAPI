public class UserRepository : IUserRepository
{
    private readonly MyDbContext _context;

    public UserRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task<UserModel> GetUserAsync(long id)
    {
        return await _context.UserRegister.FindAsync(id);
    }
}