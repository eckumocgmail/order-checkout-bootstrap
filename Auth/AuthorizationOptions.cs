/// <summary>
/// Параметры жизненого цикла обьектов сеанса
/// </summary>
public class AuthorizationOptions   
{
    public long SessionTimeout { get; set; }
    public int KeyLength { get; set; }
    public string UserCookie { get; set; }
    public string ServiceCookie { get; set; }
    public int CheckTimeout { get; set; }

    public string ApplicationUrl { get; set; }

    /// <summary>
    /// Роль пользователя по умолчанию,
    /// присваивается пользователям после 
    /// проведеня процедуры регистрации
    /// </summary>
    public string PublicRole { get; set; }
    public string PublicGroup { get; set; }
    

    public AuthorizationOptions()
    {
        this.SessionTimeout = 1000 * 60*60;
        this.KeyLength = 32;
        this.UserCookie = "UserKey";
        this.ServiceCookie = "ServiceKey";
        this.CheckTimeout = 1000;
        this.PublicRole = "Reader";
        this.PublicGroup = "Reader";
        this.ApplicationUrl = "https://localhost:44392";
    }
}