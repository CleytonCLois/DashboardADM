#pragma checksum "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39869a33a3a8eb56386d420a0d193eb9a7141cff"
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
#line 3 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
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
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                  100

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ProgressBarMode>(
#nullable restore
#line 14 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
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
#line 17 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddAttribute(15, "style", "border: 15px solid transparent; text-align: center; padding: 0px 0px;");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "cpanel cpanel-blue");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "icon-part");
            __builder.AddMarkupContent(22, "\r\n                <i class=\"fas fa-check\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(23, "<small>Prefeituras atualizadas</small>\r\n                ");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 25 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    atualizados.valores.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.AddMarkupContent(28, "<div class=\"card-content-part\">\r\n                <a href=\"PrefeiturasAtualizadas\">Mais Detalhes +</a>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "cpanel cpanel-green");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "icon-part");
            __builder.AddMarkupContent(35, "\r\n                <i class=\"fas fa-clock\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(36, "<small>Prefeituras atualizadas nas últimas 24hrs</small>\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, 
#nullable restore
#line 35 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    atualizados24hrs.valores.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<div class=\"card-content-part\">\r\n                <a href=\"PrefeiturasAtualizadas24hrs\">Mais Detalhes +</a>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "cpanel cpanel-orange");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "icon-part");
            __builder.AddMarkupContent(48, "\r\n                <i class=\"fas fa-exclamation-circle\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(49, "<small>Prefeituras desatualizadas</small>\r\n                ");
            __builder.OpenElement(50, "p");
            __builder.AddContent(51, 
#nullable restore
#line 45 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    desatualizados.valores.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.AddMarkupContent(54, "<div class=\"card-content-part\">\r\n                <a href=\"PrefeiturasDesatualizadas\">Mais Detalhes + </a>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "cpanel cpanel-red");
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "icon-part");
            __builder.AddMarkupContent(61, "\r\n                <i class=\"fas fa-times-circle\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(62, "<small>Prefeituras desatualizadas por mais de 24Hrs</small>\r\n                ");
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, 
#nullable restore
#line 55 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    desatualizadosMaisDeUmaSemana.valores.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.AddMarkupContent(67, "<div class=\"card-content-part\">\r\n                <a href=\"PrefeiturasDesatualizadasMaisDeUmaSemana\">Mais Detalhes + </a>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.AddContent(70, "    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row");
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-md-6");
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card");
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.AddMarkupContent(80, "<h5 class=\"card-header\">Gráfico Barra Prefeituras</h5>\r\n                ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "card-body");
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(84);
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_0(__builder2, 87, 88, 
#nullable restore
#line 69 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasAtualizadas

#line default
#line hidden
#nullable disable
                , 89, "Atualizadas hoje", 90, 
#nullable restore
#line 69 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                              LineType.Dashed

#line default
#line hidden
#nullable disable
                , 91, "valores");
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_1(__builder2, 93, 94, 
#nullable restore
#line 70 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasAtualizadas24hrs

#line default
#line hidden
#nullable disable
                , 95, "Atualizadas nas últimas 24hrs", 96, "valores");
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_2(__builder2, 98, 99, 
#nullable restore
#line 71 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasDesatualizadas

#line default
#line hidden
#nullable disable
                , 100, "Desatualizadas", 101, "valores");
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_3(__builder2, 103, 104, 
#nullable restore
#line 72 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasDesatualizadasMaisDeUmaSemana

#line default
#line hidden
#nullable disable
                , 105, "Desatualizadas a mais De 1 semana", 106, "valores");
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(108);
                __builder2.AddAttribute(109, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 73 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                     5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(111);
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(113, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(114);
                    __builder3.AddAttribute(115, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(117);
                    __builder3.AddAttribute(118, "Text", "Prefeituras");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(121, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "col-md-6");
            __builder.AddMarkupContent(127, "\r\n            ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "card");
            __builder.AddMarkupContent(130, "\r\n                ");
            __builder.AddMarkupContent(131, "<h5 class=\"card-header\">Gráfico Circular Prefeituras</h5>\r\n                ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "card-body");
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(135);
            __builder.AddAttribute(136, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(137, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenDonutSeries_4(__builder2, 138, 139, 
#nullable restore
#line 87 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                  grafico

#line default
#line hidden
#nullable disable
                , 140, "texto", 141, "Quantidade de Prefeituras", 142, "valores", 143, (__builder3) => {
                    __builder3.AddMarkupContent(144, "\r\n                                ");
                    __builder3.AddMarkupContent(145, "<div class=\"rz-donut-content\">\r\n                                    <div>Prefeituras</div>\r\n                                    <div>Desatualizadas</div>\r\n                                </div>\r\n                            ");
                }
                );
                __builder2.AddMarkupContent(146, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(147, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n");
            __builder.AddContent(152, "    ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "row");
            __builder.AddMarkupContent(155, "\r\n        ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "col-md-12");
            __builder.AddMarkupContent(158, "\r\n            ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "card");
            __builder.AddMarkupContent(161, "\r\n                ");
            __builder.AddMarkupContent(162, "<h5 class=\"card-header\">Lista de Prefeituras</h5>\r\n                ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "class", "card-body");
            __builder.AddMarkupContent(165, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Prefeitura>>(166);
            __builder.AddAttribute(167, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Prefeitura>>(
#nullable restore
#line 106 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                          filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(168, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 106 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                             FilterMode.Simple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 106 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 106 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(171, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 106 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(172, "Style", "margin-bottom: 50px;");
            __builder.AddAttribute(173, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(174, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(175);
                __builder2.AddAttribute(176, "Property", "id");
                __builder2.AddAttribute(177, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(178, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(179);
                __builder2.AddAttribute(180, "Property", "nomePrefeitura");
                __builder2.AddAttribute(181, "Title", "Nome da Prefeitura");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(182, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(183);
                __builder2.AddAttribute(184, "Property", "ultimaAtualizacao");
                __builder2.AddAttribute(185, "Title", "Última Atualização");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(186, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(187);
                __builder2.AddAttribute(188, "Property", "situacao");
                __builder2.AddAttribute(189, "Title", "Situação da Prefeitura");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(190, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(191, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n");
#nullable restore
#line 120 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
       

    GraficoBarra atualizados = new GraficoBarra();
    GraficoBarra atualizados24hrs = new GraficoBarra();
    GraficoBarra desatualizados = new GraficoBarra();
    GraficoBarra desatualizadosMaisDeUmaSemana = new GraficoBarra();

    IEnumerable<Prefeitura> filtro;

    private IEnumerable<Prefeitura> prefeituras;
    private IEnumerable<Grafico> grafico;
    private IEnumerable<Grafico> prefeiturasAtualizadas;
    private IEnumerable<Grafico> prefeiturasAtualizadas24hrs;
    private IEnumerable<Grafico> prefeiturasDesatualizadas;
    private IEnumerable<Grafico> prefeiturasDesatualizadasMaisDeUmaSemana;

    [Inject]
    public NavigationManager navigationManager { get; set; }

    protected override async Task OnInitializedAsync()
    {

        try
        {
            prefeituras = await PrefeituraServico.TodasPrefeituras();
            grafico = await GraficoServico.PreencherDados();
            prefeiturasAtualizadas = await GraficoServico.DadosPrefeituraGrafico(1);
            prefeiturasAtualizadas24hrs = await GraficoServico.DadosPrefeituraGrafico(2);
            prefeiturasDesatualizadas = await GraficoServico.DadosPrefeituraGrafico(3);
            prefeiturasDesatualizadasMaisDeUmaSemana = await GraficoServico.DadosPrefeituraGrafico(4);

            inserirDadosCards(prefeituras);
            filtro = await VerificarDados();
            Task.Delay(ConfiguracaoServico.ConfiguracaoAtual()).ContinueWith(t => AtualizarPagina());
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public void AtualizarPagina()
    {
        navigationManager.NavigateTo("/PrefeiturasAtualizadas", true);
    }

    public async Task<IEnumerable<Prefeitura>> VerificarDados() {

        var teste = PrefeituraServico.ListaDePrefeituras(1);

        var teste2 = await PrefeituraServico.PrefeiturasAtualizadas();

        return teste2;
    }

    public void inserirDadosCards(IEnumerable<Prefeitura> prefeituras)
    {
        double prefeiturasAtualizadas = 0,
            prefeiturasAtualizadasUltimas24hrs = 0,
            prefeiturasDesatualizadas = 0,
            prefeiturasDesatualizadasMaisDeUmaSemana = 0;

        foreach (var item in prefeituras)
        {
            switch (item.situacao)
            {
                case "1":
                    prefeiturasAtualizadas++;
                    item.situacao = "Atualizada";
                    break;
                case "2":
                    prefeiturasAtualizadasUltimas24hrs++;
                    item.situacao = "Atualizada nas últimas 24 horas";
                    break;
                case "3":
                    prefeiturasDesatualizadas++;
                    item.situacao = "Desatualizada";
                    break;
                case "4":
                    prefeiturasDesatualizadasMaisDeUmaSemana++;
                    item.situacao = "Desatualizada a mais de uma semana";
                    break;
            }
        }

        atualizados.valores = prefeiturasAtualizadas;
        atualizados24hrs.valores = prefeiturasAtualizadasUltimas24hrs;
        desatualizados.valores = prefeiturasDesatualizadas;
        desatualizadosMaisDeUmaSemana.valores = prefeiturasDesatualizadasMaisDeUmaSemana;
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
namespace __Blazor.BlazorCRUD.UI.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenColumnSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Radzen.Blazor.LineType __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "LineType", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenColumnSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateRadzenColumnSeries_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateRadzenColumnSeries_3<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDonutSeries_4<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDonutSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.AddAttribute(__seq4, "TitleTemplate", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
