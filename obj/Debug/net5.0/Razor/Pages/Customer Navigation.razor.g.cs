#pragma checksum "D:\Projects\Blazor_OrderCheckout\Pages\Customer Navigation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43c2f215ff3f19ac9974eb9eb71f0374a8e5a92a"
// <auto-generated/>
#pragma warning disable 1591
namespace OrderCheckout.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer-navigation")]
    public partial class Customer_Navigation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h3>Order_Checkout</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Pages.Order_Checkout>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n    ");
            __builder.AddMarkupContent(4, "<h3>Account_Registration</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Auth.Account_Registration>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n    ");
            __builder.AddMarkupContent(7, "<h3>User_Login</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Auth.User_Login>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n\n    ");
            __builder.AddMarkupContent(10, "<h3>Select_Payment_Method</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Pages.Select_Payment_Method>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n\n    ");
            __builder.AddMarkupContent(13, "<h3>Purchase_History</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Pages.Purchase_History>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n\n    ");
            __builder.AddMarkupContent(16, "<h3>Purchase_Order</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Pages.Purchase_Order>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n\n    ");
            __builder.AddMarkupContent(19, "<h3>Order_Status_Tracing</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Pages.Order_Status_Tracing>(20);
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\n\n    ");
            __builder.AddMarkupContent(22, "<h3>Order_Checkout</h3>\n    ");
            __builder.OpenComponent<OrderCheckout.Pages.Order_Checkout>(23);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
