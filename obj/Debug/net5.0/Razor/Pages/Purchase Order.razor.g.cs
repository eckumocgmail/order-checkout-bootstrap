#pragma checksum "D:\Projects\order-checkout-bootstrap\Pages\Purchase Order.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c874197243311078fcbe0c7c97eb2fa362e511"
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
#line 1 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using OrderCheckout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using OrderCheckout.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\order-checkout-bootstrap\_Imports.razor"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchase-order")]
    public partial class Purchase_Order : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\"><main><div class=\"py-5 text-center\"><h2>Выберите товары</h2>\r\n        <form class=\"card p-2\" style=\"width: 100%;\"><div class=\"input-group\"><input type=\"text\" class=\"form-control\" placeholder=\"Поиск по каталогу\">\r\n              <button type=\"submit\" class=\"btn btn-secondary\">Поиск</button></div></form></div>\r\n    <div class=\"row g-5\"><div class=\"col-md-5 col-lg-4 order-md-last\"><h4 class=\"d-flex justify-content-between align-items-center mb-3\"><span class=\"text-primary\"> Покупки </span>\r\n          <span class=\"badge bg-primary rounded-pill\"> 3 </span></h4>\r\n        <ul class=\"list-group mb-3\"><li class=\"list-group-item d-flex justify-content-between lh-sm\"><div><h6 class=\"my-0\"> Продукт </h6>\r\n              <small class=\"text-muted\"> Краткое описание </small></div>\r\n            <span class=\"text-muted\">$12</span></li>\r\n           \r\n          <li class=\"list-group-item d-flex justify-content-between\"><span>Всего (USD)</span>\r\n            <strong>$20</strong></li></ul>\r\n\r\n        <form class=\"card p-2\"><div class=\"input-group\"><input type=\"text\" class=\"form-control\" placeholder=\"Исп. промо код\">\r\n            <button type=\"submit\" class=\"btn btn-secondary\">Применить</button></div></form></div>\r\n\r\n     \r\n      <div class=\"col-md-7 col-lg-8\"><div class=\"card\"><div class=\"card-header\">\r\n                  Товар 1\r\n              </div>\r\n              <div class=\"card-body\"><h5 class=\"card-title\"> Наименование товара </h5>\r\n                  <p class=\"card-text\"> Краткое описание товара его приемущетва. </p>\r\n                  <a href=\"#\" class=\"btn btn-primary btn-sm\"> Добавить в корзину </a></div></div> \r\n          <div class=\"card\"><div class=\"card-header\">\r\n                  Товар 2\r\n              </div>\r\n              <div class=\"card-body\"><h5 class=\"card-title\"> Наименование товара </h5>\r\n                  <p class=\"card-text\"> Краткое описание товара его приемущетва. </p>\r\n                  <a href=\"#\" class=\"btn btn-primary btn-sm\"> Добавить в корзину </a></div></div></div></div></main>\r\n\r\n  <footer class=\"my-5 pt-5 text-muted text-center text-small\"><p class=\"mb-1\">&copy; 2022</p>\r\n    <ul class=\"list-inline\"><li class=\"list-inline-item\"><a href=\"#\"> Политика </a></li>\r\n      <li class=\"list-inline-item\"><a href=\"#\"> Терминология </a></li>\r\n      <li class=\"list-inline-item\"><a href=\"#\"> Поддержка </a></li></ul></footer></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591