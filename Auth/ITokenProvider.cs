using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

public interface ITokenProvider
{
    public string Get();
    public Task Set(string token);

}
public class TokenProvider : ITokenProvider
{
    private readonly IJSRuntime _js;

    public TokenProvider(IJSRuntime js)
    {
        _js = js;
    }

    public string Get()
        => _js.InvokeAsync<string>("localStorage.getItem", "token").Result;
    public async Task Set(string token)
    {
        await _js.InvokeVoidAsync("localStorage.setItem", "token", token);
    }

  
}