#pragma checksum "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62694d346e5cd256177b6665bc33875a5f3fd353"
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
#nullable restore
#line 4 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PrefeiturasDesatualizadas")]
    public partial class PrefeiturasDesatualizadas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
 if (prefeituras == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "loading");
            __builder.AddMarkupContent(3, "\r\n        <img src=\"imgLoading.png\" style=\"display: block; margin-left: auto; margin-right: auto\">\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenProgressBar>(4);
            __builder.AddAttribute(5, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                  100

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ProgressBarMode>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                                               ProgressBarMode.Indeterminate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Style", "margin-bottom: 20px; align-self: center;");
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<h3 style=\" align-self: center;\">Aguarde até carregar todos os dados.</h3>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 17 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-12");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<h5 class=\"card-header\">Lista de prefeituras desatualizadas</h5>\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Prefeitura>>(26);
            __builder.AddAttribute(27, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Prefeitura>>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                          filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                                             FilterMode.Simple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "Style", "margin-bottom: 50px;");
            __builder.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(35);
                __builder2.AddAttribute(36, "Property", "id");
                __builder2.AddAttribute(37, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(39);
                __builder2.AddAttribute(40, "Property", "nomePrefeitura");
                __builder2.AddAttribute(41, "Title", "Nome da Prefeitura");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(43);
                __builder2.AddAttribute(44, "Property", "ultimaAtualizacao");
                __builder2.AddAttribute(45, "Title", "Última Atualização");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(47);
                __builder2.AddAttribute(48, "Property", "situacao");
                __builder2.AddAttribute(49, "Title", "Situação da Prefeitura");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 39 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\PrefeiturasDesatualizadas.razor"
       

    IEnumerable<Prefeitura> filtro;

    private IEnumerable<Prefeitura> prefeituras;

    [Inject]
    public NavigationManager navigationManager { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            prefeituras = await PrefeituraServico.PrefeiturasDesatualizadas();
            filtro = prefeituras;
            Task.Delay(ConfiguracaoServico.ConfiguracaoAtual()).ContinueWith(t => AtualizarPagina());
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public void AtualizarPagina()
    {
        navigationManager.NavigateTo("/PrefeiturasDesatualizadasMaisDeUmaSemana", true);
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
