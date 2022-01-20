#pragma checksum "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Controls\VisibilityComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d48197343233efdf5f1cc09dedde5055fed4e8fe"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlazorApp.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.UseCases.SearchMovieScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Store.CounterStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.CoreBusiness.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class VisibilityComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Controls\VisibilityComponent.razor"
 if (this.isVisible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3>VisibilityComponent</h3>\r\n");
#nullable restore
#line 6 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Controls\VisibilityComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Controls\VisibilityComponent.razor"
       
    private bool isVisible = true;

    public void SetVisibility()
    {
        this.isVisible = !this.isVisible;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
