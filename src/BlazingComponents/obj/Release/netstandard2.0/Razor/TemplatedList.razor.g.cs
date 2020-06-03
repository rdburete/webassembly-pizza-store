#pragma checksum "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cfc790ad73309830e453aa1f0946e3b60cc3db5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class TemplatedList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
 if (items == null)
{
    

#line default
#line hidden
            __builder.AddContent(0, 
#line 5 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
     Loading

#line default
#line hidden
            );
#line 5 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
            
}
else if (!items.Any())
{
    

#line default
#line hidden
            __builder.AddContent(1, 
#line 9 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
     Empty

#line default
#line hidden
            );
#line 9 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
          
}
else
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "list-group");
            __builder.AddMarkupContent(5, "\r\n");
#line 14 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
         foreach (var item in items)
        {

#line default
#line hidden
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "list-group-item" + " " + (
#line 16 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
                                     ListGroupClass

#line default
#line hidden
            ));
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddContent(10, 
#line 17 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
             Item(item)

#line default
#line hidden
            );
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#line 19 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
        }

#line default
#line hidden
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#line 21 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 23 "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor"
       
    IEnumerable<TItem> items;

    [Parameter] public Func<Task<IEnumerable<TItem>>> Loader { get; set; }
    [Parameter] public RenderFragment Loading { get; set; }
    [Parameter] public RenderFragment Empty { get; set; }
    [Parameter] public RenderFragment<TItem> Item { get; set; }
    [Parameter] public string ListGroupClass { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        items = await Loader();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
