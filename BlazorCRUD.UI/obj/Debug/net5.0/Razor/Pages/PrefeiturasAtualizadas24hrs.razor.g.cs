#pragma checksum "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d71b7cff62fff167f2c16c4222811bf6e967768"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.UI.Pages
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
#line 4 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PrefeiturasAtualizadas24hrs")]
    public partial class PrefeiturasAtualizadas24hrs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
 if (prefeituras == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "loading");
            __builder.AddMarkupContent(2, "<img src=\"imgLoading.png\" style=\"display: block; margin-left: auto; margin-right: auto\">\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenProgressBar>(3);
            __builder.AddAttribute(4, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                  100

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ProgressBarMode>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                                               ProgressBarMode.Indeterminate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Style", "margin-bottom: 20px; align-self: center;");
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<h3 style=\" align-self: center;\">Aguarde até carregar todos os dados.</h3>");
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-12");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.AddMarkupContent(16, "<h5 class=\"card-header\">Lista de prefeituras atualizadas nas últimas 24 horas</h5>\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Prefeitura>>(19);
            __builder.AddAttribute(20, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Prefeitura>>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                          filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                                             FilterMode.Simple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Style", "margin-bottom: 50px;");
            __builder.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(27);
                __builder2.AddAttribute(28, "Property", "id");
                __builder2.AddAttribute(29, "Title", "ID");
                __builder2.AddAttribute(30, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(31, "\r\n                                    Quantidade total de prefeituras: ");
                    __builder3.OpenElement(32, "b");
                    __builder3.AddContent(33, 
#nullable restore
#line 29 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
                                                                         filtro.Count()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(35);
                __builder2.AddAttribute(36, "Property", "nomePrefeitura");
                __builder2.AddAttribute(37, "Title", "Nome da Prefeitura");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(39);
                __builder2.AddAttribute(40, "Property", "ultimaAtualizacao");
                __builder2.AddAttribute(41, "Title", "Última Atualização");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasAtualizadas24hrs.razor"
       

    IEnumerable<Prefeitura> filtro;

    private IEnumerable<Prefeitura> prefeituras;

    [Inject]
    public NavigationManager navigationManager { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            prefeituras = await PrefeituraServico.ListaDePrefeituras(2);
            filtro = prefeituras;
            Task.Delay(1800000).ContinueWith(t => AtualizarPagina());
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public void AtualizarPagina()
    {
        navigationManager.NavigateTo("/PrefeiturasDesatualizadas", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguracaoServico ConfiguracaoServico { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPrefeituraServico PrefeituraServico { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGraficoServico GraficoServico { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
