#pragma checksum "D:\Projects\Blazor_OrderCheckout\PageLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90d067dc088d15480db93395f155d80b8dfba78"
// <auto-generated/>
#pragma warning disable 1591
namespace OrderCheckout
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
    public partial class PageLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width: 100%; height: 100%; position: fixed;");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width: 100%; height: 100%; overflow-y: auto;  display: flex; flex-direction: column; flex-wrap: nowrap;");
            __builder.AddMarkupContent(4, "<div style=\"width: 100%;\"></div>\r\n       \r\n        \r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "width: 100%; height: 100%; overflow-y: auto; ");
#nullable restore
#line 12 "D:\Projects\Blazor_OrderCheckout\PageLayout.razor"
__builder.AddContent(7, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n        \r\n        <div style=\"width: 100%;\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591