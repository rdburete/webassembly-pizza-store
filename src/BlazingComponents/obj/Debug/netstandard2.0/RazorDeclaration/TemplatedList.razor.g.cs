#pragma checksum "D:\Radu's Files\Blazor\Github Pages\webassembly-pizza-store\src\BlazingComponents\TemplatedList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cfc790ad73309830e453aa1f0946e3b60cc3db5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
