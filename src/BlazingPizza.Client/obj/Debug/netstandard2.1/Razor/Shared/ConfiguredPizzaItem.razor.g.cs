#pragma checksum "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f7e9967c29b60f8fddc90932a7eb7a63a609410"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
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
    public partial class ConfiguredPizzaItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cart-item");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 2 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                 OnRemoved

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "class", "delete-item");
            __builder.AddContent(6, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "title");
            __builder.AddContent(10, 
#line 3 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                         Pizza.Size

#line default
#line hidden
            );
            __builder.AddContent(11, "\" ");
            __builder.AddContent(12, 
#line 3 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                                       Pizza.Special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddMarkupContent(15, "\n");
#line 5 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
         foreach (var topping in Pizza.Toppings)
        {

#line default
#line hidden
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "li");
            __builder.AddContent(18, "+ ");
            __builder.AddContent(19, 
#line 7 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                   topping.Topping.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#line 8 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
        }

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "item-price");
            __builder.AddMarkupContent(25, "\n        ");
            __builder.AddContent(26, 
#line 11 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
         Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(27, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 15 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
       
    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnRemoved { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
