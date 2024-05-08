public class UserModel
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }

    public UserModel(long id
                        , string name
                        , string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }
}

