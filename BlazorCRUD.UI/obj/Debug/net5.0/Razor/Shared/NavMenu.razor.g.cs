#pragma checksum "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a1989328eac559055ef3da876a0dd6f370ad5a"
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
#line 2 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"top-row pl-4 navbar navbar-dark\"><img src=\"logo.png\" style=\"display: block; margin-left: auto; margin-right: auto\"></div>\r\n\r\n");
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
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "nav flex-column");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "class", "nav-link");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                ()=> expandSubMenuEstatistica = !expandSubMenuEstatistica

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "<span class=\"oi oi-pie-chart\" aria-hidden=\"true\"></span> Estatística\r\n            ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
             if (expandSubMenuEstatistica)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "nav flex-column");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "class", "nav-link");
            __builder.AddAttribute(19, "href", "EmissaoNFE");
            __builder.AddAttribute(20, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 15 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "<span class=\"oi oi-graph\" aria-hidden=\"true\"></span> Emissão de NF-e\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                ()=> expandSubMenuReplicacao = !expandSubMenuReplicacao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-loop-circular\" aria-hidden=\"true\"></span> Sincronização\r\n            ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 26 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
             if (expandSubMenuReplicacao)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "nav flex-column");
            __builder.OpenElement(33, "li");
            __builder.AddAttribute(34, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "/");
            __builder.AddAttribute(38, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 30 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Prefeituras\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "li");
            __builder.AddAttribute(43, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                ()=> expandSubMenuSincronizacao = !expandSubMenuSincronizacao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<span class=\"oi oi-transfer\" aria-hidden=\"true\"></span> Replicação\r\n            ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 61 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
             if (expandSubMenuSincronizacao)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "ul");
            __builder.AddAttribute(50, "class", "nav flex-column");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "NotasFiscais");
            __builder.AddAttribute(56, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 65 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "<span class=\"oi oi-file\" aria-hidden=\"true\"></span> Notas Fiscais\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "li");
            __builder.AddAttribute(61, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(62);
            __builder.AddAttribute(63, "class", "nav-link");
            __builder.AddAttribute(64, "href", "Pessoas");
            __builder.AddAttribute(65, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 70 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(67, "<span class=\"oi oi-people\" aria-hidden=\"true\"></span> Pessoas\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "li");
            __builder.AddAttribute(70, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(71);
            __builder.AddAttribute(72, "class", "nav-link");
            __builder.AddAttribute(73, "href", "Empresas");
            __builder.AddAttribute(74, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 75 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "<span class=\"oi oi-briefcase\" aria-hidden=\"true\"></span> Empresas\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "li");
            __builder.AddAttribute(79, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(80);
            __builder.AddAttribute(81, "class", "nav-link");
            __builder.AddAttribute(82, "href", "Logs");
            __builder.AddAttribute(83, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 80 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
                                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(85, "<span class=\"oi oi-terminal\" aria-hidden=\"true\"></span> Logs\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.AddMarkupContent(87, "<div style=\"position: absolute; bottom: 10px; width: 100%; display: flex; align-items: center; color: #d7d7d7\"><span type=\"text\" id=\"rel\" style=\"text-align: center; width: 100%; font-size: 1.5rem\"></span></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private bool expandSubMenuReplicacao;
    private bool expandSubMenuEstatistica;
    private bool expandSubMenuSincronizacao;

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
