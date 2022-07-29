#pragma checksum "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1802891f1bcccbdfa0550bdef2f6b2fb05db25"
// <auto-generated/>
#pragma warning disable 1591
namespace OrderCheckout.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using OrderCheckout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using OrderCheckout.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using OrderCheckout.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Blazor_OrderCheckout\_Imports.razor"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user-login")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class User_Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "align", "center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width: 640px;");
            __builder.AddAttribute(4, "align", "left");
            __builder.AddMarkupContent(5, "<h3 class=\"text-center\">Авторизация пользователя</h3>\n        <img src=\"/apple.png\" style=\"width: 640px; height: 480px; padding: 20px; border: 1px solid black;\">\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "text text-info");
#nullable restore
#line 34 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
__builder.AddContent(8, Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "text text-info");
#nullable restore
#line 35 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
__builder.AddContent(12, Token);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "form");
            __builder.AddAttribute(15, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 36 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
                          OnLoginSubmited

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-12");
            __builder.AddMarkupContent(18, "<label for=\"username\" class=\"form-label\"> Имя пользователя </label>\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "input-group has-validation");
            __builder.AddMarkupContent(21, "<span class=\"input-group-text\">@</span>\n                    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "email");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "id", "username");
            __builder.AddAttribute(26, "placeholder", "Электронная почта");
            __builder.AddAttribute(27, "required");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
                                               Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                    ");
            __builder.AddMarkupContent(31, "<div class=\"invalid-feedback\">\n                        Необходимо ввести имя пользователя\n                    </div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "<hr>\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-12");
            __builder.AddMarkupContent(35, "<label for=\"password\" class=\"form-label\"> Пароль </label>\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "input-group has-validation");
            __builder.AddMarkupContent(38, "<span class=\"input-group-text\">@</span>\n                    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "password");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "id", "password");
            __builder.AddAttribute(43, "placeholder", "Пароль");
            __builder.AddAttribute(44, "required");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
                                                  Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.AddMarkupContent(48, "<div class=\"invalid-feedback\">\n                        Необходимо ввести пароль\n                    </div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "<hr>\n           \n            ");
            __builder.AddMarkupContent(50, "<div class=\"col-12\" align=\"right\" style=\"padding: 10px;\"><button class=\"btn btn-primary btn-sm\"> Выполнить </button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "align", "center");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "nav-link");
            __builder.AddAttribute(56, "href", "account-registration");
            __builder.AddAttribute(57, "style", "width: 100%; margin-left: 20px;");
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "<span class=\"oi oi-person\" aria-hidden=\"true\"></span> Регистрация пользователя\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n    ");
            __builder.OpenElement(61, "div");
            __builder.OpenElement(62, "table");
#nullable restore
#line 70 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
             foreach (var user in users.GetAll())
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "tr");
            __builder.OpenElement(64, "td");
#nullable restore
#line 73 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
__builder.AddContent(65, user.Account.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
      
    public string Message { get; set; } = "";
    public string Email { get; set; } = "eckumoc@gmail.com";
    public string Token { get; set; } = null;
    public string Password { get; set; } = "eckumoc@gmail.com";

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\Blazor_OrderCheckout\Auth\User Login.razor"
      
    public void OnLoginSubmited()
    {
        if((Token=login.Signin(Email,Password))!=null)
        {
            this.Message = "Авторизация выполнена";
            nav.NavigateTo("/user-home");
        }
        else
        {
            this.Message = "Авторизация не выполнена";
        }        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorizationUsers users { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserLogin login { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591