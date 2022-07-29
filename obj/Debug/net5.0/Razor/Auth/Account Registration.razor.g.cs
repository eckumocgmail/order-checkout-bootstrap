#pragma checksum "D:\Projects\Blazor_OrderCheckout\Auth\Account Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe8f1abf2c49f59801da1fe9720ff6384dfeee9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/account-registration")]
    public partial class Account_Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "align", "center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width: 640px;");
            __builder.AddAttribute(4, "align", "left");
            __builder.AddMarkupContent(5, "<h3>Регистрация учетной записи</h3>\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "text text-info");
#nullable restore
#line 33 "D:\Projects\Blazor_OrderCheckout\Auth\Account Registration.razor"
__builder.AddContent(8, Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "form");
            __builder.AddAttribute(11, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 34 "D:\Projects\Blazor_OrderCheckout\Auth\Account Registration.razor"
                          OnRegistrationSubmited

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, @"<div class=""col-12""><label for=""username"" class=""form-label""> Имя пользователя </label>
                <div class=""input-group has-validation""><span class=""input-group-text"">@</span>
                    <input type=""email"" asp-for=""Email"" class=""form-control"" id=""username"" placeholder=""Электронная почта"" required>
                    <div class=""invalid-feedback"">
                        Необходимо ввести имя пользователя
                    </div></div></div><hr>
            ");
            __builder.AddMarkupContent(13, @"<div class=""col-12""><label for=""password"" class=""form-label""> Пароль </label>
                <div class=""input-group has-validation""><span class=""input-group-text"">@</span>
                    <input type=""password"" asp-for=""Password"" class=""form-control"" id=""password"" placeholder=""Пароль"" required>
                    <div class=""invalid-feedback"">
                        Необходимо ввести пароль
                    </div></div></div><hr>
            ");
            __builder.AddMarkupContent(14, @"<div class=""col-12""><label for=""password"" class=""form-label""> Подтверждение </label>
                <div class=""input-group has-validation""><span class=""input-group-text"">@</span>
                    <input type=""password"" asp-for=""Confirmation"" class=""form-control"" id=""confirmation"" placeholder=""Подтверждение"" required>
                    <div class=""invalid-feedback"">
                        Необходимо ввести подтверждение пароля
                    </div></div></div><hr>
            ");
            __builder.AddMarkupContent(15, "<div class=\"col-12\" align=\"right\" style=\"padding: 10px;\"><button class=\"btn btn-primary btn-sm\"> Выполнить </button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "align", "center");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "class", "nav-link");
            __builder.AddAttribute(21, "href", "user-login");
            __builder.AddAttribute(22, "style", "width: 100%; margin-left: 20px;");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-account-login\" aria-hidden=\"true\"></span> Авторизация пользователя\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Projects\Blazor_OrderCheckout\Auth\Account Registration.razor"
      
    public string Message { get; set; } = "";
    public string Email { get; set; } = "eckumoc@gmail.com";
    public string Password { get; set; } = "eckumoc@gmail.com";
    public string Confirmation { get; set; } = "eckumoc@gmail.com";

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Blazor_OrderCheckout\Auth\Account Registration.razor"
      
    public void OnRegistrationSubmited()
    {
        Console.WriteLine($"{Email} {Password} {Confirmation}");
        if(Password==Confirmation){
            if(registration.Signup(Email, Password)){
                this.Message = "Регистрация выполнена";
                nav.NavigateTo("/user-login");
            }else{
                this.Message = "Регистрация не выполнена";
            }
        }else{
            this.Message = "Пароль отличается от потверждения";
        }        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountRegistration registration { get; set; }
    }
}
#pragma warning restore 1591
