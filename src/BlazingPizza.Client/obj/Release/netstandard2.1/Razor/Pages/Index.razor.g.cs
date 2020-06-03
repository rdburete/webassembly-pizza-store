#pragma checksum "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e41cf65dc5db50dde1ce1cff40b128000c4fd2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 3 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 4 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 5 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 7 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 8 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 9 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#line 10 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 11 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 12 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 13 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 14 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#line 15 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pizza-cards");
            __builder.AddMarkupContent(5, "\n");
#line 9 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
         if (specials != null)
        {

#line default
#line hidden
#line 11 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
 foreach (var special in specials)
{

#line default
#line hidden
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                () => OrderState.ShowConfigurePizzaDialog(special)

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "style", "background-image:" + " url(\'" + (
#line 13 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                                                                                    special.ImageUrl

#line default
#line hidden
            ) + "\')");
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "pizza-info");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "title");
            __builder.AddContent(15, 
#line 15 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                             special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.AddContent(17, 
#line 16 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
         special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "price");
            __builder.AddContent(21, 
#line 17 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                             special.GetFormattedBasePrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#line 20 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
}

#line default
#line hidden
#line 20 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
 }

#line default
#line hidden
            __builder.AddContent(25, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "sidebar");
            __builder.AddMarkupContent(30, "\n");
#line 25 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
     if (Order.Pizzas.Any())
    {

#line default
#line hidden
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "order-contents");
            __builder.AddMarkupContent(33, "\n    ");
            __builder.AddMarkupContent(34, "<h2>Your order</h2>\n\n");
#line 30 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
     foreach (var configuredPizza in Order.Pizzas)
    {

#line default
#line hidden
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfiguredPizzaItem>(35);
            __builder.AddAttribute(36, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 32 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                            configuredPizza

#line default
#line hidden
            ));
            __builder.AddAttribute(37, "OnRemoved", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 32 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                                          () => RemovePizza(configuredPizza)

#line default
#line hidden
            )));
            __builder.CloseComponent();
#line 32 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                                                                                 }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddContent(38, " ");
#line 33 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
       }
else
{

#line default
#line hidden
            __builder.AddMarkupContent(39, "<div class=\"empty-cart\">Choose a pizza<br>to get started</div>");
#line 36 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                                              }

#line default
#line hidden
            __builder.AddMarkupContent(40, "\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "order-total" + " " + (
#line 38 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                              Order.Pizzas.Any() ? "" : "hidden"

#line default
#line hidden
            ));
            __builder.AddMarkupContent(43, "\n        Total:\n        ");
            __builder.OpenElement(44, "span");
            __builder.AddAttribute(45, "class", "total-price");
            __builder.AddContent(46, 
#line 40 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                   Order.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n        ");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "href", "checkout");
            __builder.AddAttribute(50, "class", 
#line 41 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                    Order.Pizzas.Count == 0 ? "btn btn-warning disabled" : "btn btn-warning"

#line default
#line hidden
            );
            __builder.AddMarkupContent(51, "\n            Order >\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n\n");
            __builder.OpenComponent<BlazingComponents.TemplatedDialog>(55);
            __builder.AddAttribute(56, "Show", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 47 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                       OrderState.ShowingConfigureDialog

#line default
#line hidden
            ));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "\n    ");
                __builder2.OpenComponent<BlazingPizza.Client.Shared.ConfigurePizzaDialog>(59);
                __builder2.AddAttribute(60, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 48 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                 OrderState.ConfiguringPizza

#line default
#line hidden
                ));
                __builder2.AddAttribute(61, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 49 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                    OrderState.CancelConfigurePizzaDialog

#line default
#line hidden
                )));
                __builder2.AddAttribute(62, "OnConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 50 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
                                     OrderState.ConfirmConfigurePizzaDialog

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 53 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Pages\Index.razor"
        List<PizzaSpecial> specials;
    Order Order => OrderState.Order;

    protected override async Task OnInitializedAsync()
    {
        specials = await HttpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials");
    }

    async Task RemovePizza(Pizza configuredPizza)
    {
        if (await JS.Confirm($"Remove {configuredPizza.Special.Name} pizza from the order?"))
        {
            OrderState.RemoveConfiguredPizza(configuredPizza);
        }
    } 

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
