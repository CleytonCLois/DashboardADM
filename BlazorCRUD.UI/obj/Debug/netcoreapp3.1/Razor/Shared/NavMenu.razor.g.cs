#pragma checksum "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e79dacca3814e360a7294d5207f2e9230fb85382"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"top-row pl-4 navbar navbar-dark\">\r\n    <img src=\"logo.png\" style=\"display: block; margin-left: auto; margin-right: auto\">\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 5 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "nav flex-column");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "nav-item px-3");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "class", "nav-link");
            __builder.AddAttribute(13, "href", "Prefeituras");
            __builder.AddAttribute(14, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenIcon>(17);
                __builder2.AddAttribute(18, "Icon", "account_balance");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.AddMarkupContent(20, "<span aria-hidden=\"true\">Prefeituras</span>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
       
	private bool collapseNavMenu = true;

	private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

	private void ToggleNavMenu()
	{
		collapseNavMenu = !collapseNavMenu;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
