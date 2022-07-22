using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;
using System;

/// <summary>
/// Поток управления жизненым циклом обьектов сеанса
/// </summary>
public class AuthorizationBackgroundService : BackgroundService, IDisposable
{

    private readonly ILogger<AuthorizationBackgroundService> _logger;

    private readonly AuthorizationOptions _options;
    private readonly AuthorizationContext _context;
 


    /// <param name="options"> Параметры </param>
    /// <param name="users"> Коллекция авторизованных пользователей </param>
    /// <param name="services"> Коллекция авторизованных служб </param>
    public AuthorizationBackgroundService(
            ILogger<AuthorizationBackgroundService> logger,                   
            AuthorizationOptions options,
            AuthorizationContext context )
    {
        _logger = logger;       
        _options = options;
        _context = context;      
      
    }


    /// <summary>
    /// Выполнение фоновой задачи до тех пор пока не получен запрос на прерывание
    /// </summary>
    /// <param name="stoppingToken"> токен управления потоком </param>
    /// <returns></returns>
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation(DateTime.Now.ToString());
            Thread.Sleep(_options.CheckTimeout);
            await this.DoCheck();                
        }
    }


    /// <summary>
    /// Выполнение проверки активности обьектов 
    /// </summary>        
    private async Task DoCheck()
    {
        _context.DoCheck();
              
    }



    /// <summary>
    /// Уничтожение сервиса
    /// </summary>
    public override void Dispose()
    {
        _logger.LogInformation("Dispose()");
        base.Dispose();
    }
}