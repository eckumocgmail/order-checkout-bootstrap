public class AuthorizationContext
{
    private readonly AuthorizationUsers _users; 

    public AuthorizationContext(AuthorizationUsers users)
    {
        this._users = users;
    }

    public void DoCheck(){
        _users.DoCheck();
    }
}