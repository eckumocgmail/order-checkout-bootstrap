public interface IUserLogout
{

    public bool Signout();


}

public class UserLogout : IUserLogout
{
    public UserLogout()
    {
    }

    public bool Signout()
    {
        return false;
    }
}