#pragma checksum "C:\Users\1\source\repos\NacharEkz\NacharEkz\Pages\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec4fdef473bea1ec6227a9c516edb52da8d8cd5"
// <auto-generated/>
#pragma warning disable 1591
namespace NacharEkz.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using NacharEkz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\1\source\repos\NacharEkz\NacharEkz\_Imports.razor"
using NacharEkz.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/table")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/table/{value}")]
    public partial class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Table</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 13 "C:\Users\1\source\repos\NacharEkz\NacharEkz\Pages\Table.razor"
             foreach (var name in names)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 16 "C:\Users\1\source\repos\NacharEkz\NacharEkz\Pages\Table.razor"
__builder.AddContent(11, name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, " \r\n");
#nullable restore
#line 18 "C:\Users\1\source\repos\NacharEkz\NacharEkz\Pages\Table.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\1\source\repos\NacharEkz\NacharEkz\Pages\Table.razor"
       
    [Parameter]
    public string value { get; set; }

    public static List<string> names { get; set; } = new List<string>();

    protected override void OnParametersSet() 
    {
        if (value != null)
            names.Add(value); 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
