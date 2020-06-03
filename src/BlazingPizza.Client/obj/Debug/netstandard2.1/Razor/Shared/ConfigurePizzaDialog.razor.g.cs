#pragma checksum "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a8a542e09f680a7c0a880bd06c0dcaf9514d5c8"
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
    public partial class ConfigurePizzaDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialog-title");
            __builder.AddMarkupContent(2, "\n            ");
            __builder.OpenElement(3, "h2");
            __builder.AddContent(4, 
#line 5 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 Pizza.Special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n            ");
            __builder.AddContent(6, 
#line 6 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
             Pizza.Special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n        ");
            __builder.OpenElement(9, "form");
            __builder.AddAttribute(10, "class", "dialog-body");
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.AddMarkupContent(14, "<label>Size:</label>\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "range");
            __builder.AddAttribute(17, "min", 
#line 12 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                          Pizza.MinimumSize

#line default
#line hidden
            );
            __builder.AddAttribute(18, "max", 
#line 12 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                   Pizza.MaximumSize

#line default
#line hidden
            );
            __builder.AddAttribute(19, "step", "1");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                                      Pizza.Size

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pizza.Size = __value, Pizza.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "span");
            __builder.AddAttribute(24, "class", "size-label");
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.AddContent(26, 
#line 14 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                      Pizza.Size

#line default
#line hidden
            );
            __builder.AddMarkupContent(27, "\" (£");
            __builder.AddContent(28, 
#line 14 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                       Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(29, ")\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddMarkupContent(33, "\n                ");
            __builder.AddMarkupContent(34, "<label>Extra Toppings:</label>\n");
#line 19 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 if (toppings == null)
                {

#line default
#line hidden
            __builder.AddContent(35, "                    ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "class", "custom-select");
            __builder.AddAttribute(38, "disabled", true);
            __builder.AddMarkupContent(39, "\n                        ");
            __builder.OpenElement(40, "option");
            __builder.AddContent(41, "(loading...)");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#line 24 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else if (Pizza.Toppings.Count >= 6)
                {

#line default
#line hidden
            __builder.AddContent(44, "                    ");
            __builder.AddMarkupContent(45, "<div>(maximum reached)</div>\n");
#line 28 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else
                {

#line default
#line hidden
            __builder.AddContent(46, "                    ");
            __builder.OpenElement(47, "select");
            __builder.AddAttribute(48, "class", "custom-select");
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 31 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                             ToppingSelected

#line default
#line hidden
            ));
            __builder.AddMarkupContent(50, "\n                        ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "-1");
            __builder.AddAttribute(53, "disabled", true);
            __builder.AddAttribute(54, "selected", true);
            __builder.AddContent(55, "(select)");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n");
#line 33 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                         for (var i = 0; i < toppings.Count; i++)
                        {

#line default
#line hidden
            __builder.AddContent(57, "                            ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", 
#line 35 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                            i

#line default
#line hidden
            );
            __builder.AddContent(60, 
#line 35 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                toppings[i].Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(61, " - (£");
            __builder.AddContent(62, 
#line 35 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                       toppings[i].GetFormattedPrice()

#line default
#line hidden
            );
            __builder.AddContent(63, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n");
#line 36 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                        }

#line default
#line hidden
            __builder.AddContent(65, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n");
#line 38 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
            __builder.AddContent(67, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "toppings");
            __builder.AddMarkupContent(71, "\n");
#line 42 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 foreach (var topping in Pizza.Toppings)
                {

#line default
#line hidden
            __builder.AddContent(72, "                    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "topping");
            __builder.AddMarkupContent(75, "\n                        ");
            __builder.AddContent(76, 
#line 45 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                         topping.Topping.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(77, "\n                        ");
            __builder.OpenElement(78, "span");
            __builder.AddAttribute(79, "class", "topping-price");
            __builder.AddContent(80, 
#line 46 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                     topping.Topping.GetFormattedPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                        ");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "type", "button");
            __builder.AddAttribute(84, "class", "delete-topping");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 47 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                 () => RemoveTopping(topping.Topping)

#line default
#line hidden
            ));
            __builder.AddContent(86, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n");
#line 49 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
            __builder.AddContent(89, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n\n        ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "dialog-buttons");
            __builder.AddMarkupContent(94, "\n            ");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "class", "btn btn-secondary mr-auto");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 54 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                OnCancel

#line default
#line hidden
            ));
            __builder.AddContent(98, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n            ");
            __builder.OpenElement(100, "span");
            __builder.AddAttribute(101, "class", "mr-center");
            __builder.AddMarkupContent(102, "\n                Price: ");
            __builder.OpenElement(103, "span");
            __builder.AddAttribute(104, "class", "price");
            __builder.AddContent(105, 
#line 56 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                             Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n            ");
            __builder.OpenElement(108, "button");
            __builder.AddAttribute(109, "class", "btn btn-success ml-auto");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                              OnConfirm

#line default
#line hidden
            ));
            __builder.AddContent(111, "Order >");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 61 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
       
    List<Topping> toppings;

    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }

    protected async override Task OnInitializedAsync()
    {
        toppings = await HttpClient.GetFromJsonAsync<List<Topping>>("toppings");
    }

    void ToppingSelected(ChangeEventArgs e)
    {
        if (int.TryParse((string)e.Value, out var index) && index >= 0)
        {
            AddTopping(toppings[index]);
        }
    }

    void AddTopping(Topping topping)
    {
        if (Pizza.Toppings.Find(pt => pt.Topping == topping) == null)
        {
            Pizza.Toppings.Add(new PizzaTopping() { Topping = topping });
        }
    }

    void RemoveTopping(Topping topping)
    {
        Pizza.Toppings.RemoveAll(pt => pt.Topping == topping);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
