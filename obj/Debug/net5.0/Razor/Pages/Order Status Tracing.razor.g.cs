#pragma checksum "D:\Projects\Blazor_OrderCheckout\Pages\Order Status Tracing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd72d0e1daa240ccaf7aa663ca07fd6790ef1980"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/order-status-tracking")]
    public partial class Order_Status_Tracing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div align=\"center\"><h2> Остеживание заказа </h2>\n\n    <div class=\"card\" style=\"margin: 20px;\" align=\"left\"><div class=\"card-header\">\n                Покупка 1\n            </div>\n            <div class=\"card-body\"><h5 class=\"card-title\"> Список товаров </h5>\n                <div class=\"card-text\"><p>Дата 01.01.2020</p>\n                    <p>Сумма 200</p>                    \n                    <p>Статус Ожидается оплата</p>                    \n                    <div class=\"card\" style=\"margin: 5px;\"><div class=\"card-header\">\n                                Товар 1\n                            </div>\n                            <div class=\"card-body\"><h5 class=\"card-title\"> Наименование товара </h5>\n                                <div class=\"card-text\"><p>Кол-во 1</p>\n                                    <p>Цена 100</p>\n                                    <p>Итого 100</p></div></div></div>    \n                    <div class=\"card\" style=\"margin: 5px;\"><div class=\"card-header\">\n                                Товар 2\n                            </div>\n                            <div class=\"card-body\"><h5 class=\"card-title\"> Наименование товара </h5>\n                                <div class=\"card-text\"><p>Кол-во 1</p>\n                                    <p>Цена 100</p>\n                                    <p>Итого 100</p></div></div></div></div>\n                <div align=\"right\" style=\"margin: 10px;\"><a href=\"#\" class=\"btn btn-primary btn-sm\"> Просмотреть подробную информацию </a></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
