public class UserManager
{
    private User[] users;
    public UserManager()
    {
        users = new User[1]
        {
            new User(){Id=1, Name="Ahmed"}
        };
    }
    public User[] Get()
    {
        return users;
    }
}