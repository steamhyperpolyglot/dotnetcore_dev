#pragma checksum "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20458bb9a423492824527762a6f1ff1c1378e22a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\RnD\dotnetcore_dev\v3\Pro ASP.NET Core 3\Chapter10\SportsSln\SportsStore\Pages\Admin\OrderTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";

    [Parameter]
    public IEnumerable<Order> Orders { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";

    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
