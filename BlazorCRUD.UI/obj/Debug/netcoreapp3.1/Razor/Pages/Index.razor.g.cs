#pragma checksum "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b0cee3014b1479797dea0c93b44a12e4c4fb2b"
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
                    prefeiturasAtualizadasCount

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
                    prefeiturasAtualizadasUltimas24hrsCount

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
                    prefeiturasDesatualizadasCount

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
                    prefeiturasDesatualizadasMaisDeUmaSemanaCount

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
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row");
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-md-6");
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "card");
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.AddMarkupContent(79, "<h5 class=\"card-header\">Gráfico Barra Prefeituras</h5>\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "card-body");
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(83);
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_0(__builder2, 86, 87, 
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasAtualizadas

#line default
#line hidden
#nullable disable
                , 88, "Atualizadas hoje", 89, 
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                              LineType.Dashed

#line default
#line hidden
#nullable disable
                , 90, "valores");
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_1(__builder2, 92, 93, 
#nullable restore
#line 69 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasAtualizadas24hrs

#line default
#line hidden
#nullable disable
                , 94, "Atualizadas nas últimas 24hrs", 95, "valores");
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_2(__builder2, 97, 98, 
#nullable restore
#line 70 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasDesatualizadas

#line default
#line hidden
#nullable disable
                , 99, "Desatualizadas", 100, "valores");
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenColumnSeries_3(__builder2, 102, 103, 
#nullable restore
#line 71 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                   prefeiturasDesatualizadasMaisDeUmaSemana

#line default
#line hidden
#nullable disable
                , 104, "Desatualizadas a mais De 1 semana", 105, "valores");
                __builder2.AddMarkupContent(106, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(107);
                __builder2.AddAttribute(108, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 72 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                     5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(110);
                __builder2.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(112, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(113);
                    __builder3.AddAttribute(114, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(116);
                    __builder3.AddAttribute(117, "Text", "Prefeituras");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "col-md-6");
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "card");
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.AddMarkupContent(130, "<h5 class=\"card-header\">Gráfico Circular Prefeituras</h5>\r\n                ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "card-body");
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(134);
            __builder.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(136, "\r\n                        ");
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenDonutSeries_4(__builder2, 137, 138, 
#nullable restore
#line 86 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                  graficoCircularPrefeiturasDesatualizadas

#line default
#line hidden
#nullable disable
                , 139, "texto", 140, "Quantidade de Prefeituras", 141, "valores", 142, (__builder3) => {
                    __builder3.AddMarkupContent(143, "\r\n                                ");
                    __builder3.AddMarkupContent(144, "<div class=\"rz-donut-content\">\r\n                                    <div>Prefeituras</div>\r\n                                    <div>Desatualizadas</div>\r\n                                </div>\r\n                            ");
                }
                );
                __builder2.AddMarkupContent(145, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(146, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n    ");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "row");
            __builder.AddMarkupContent(153, "\r\n        ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "col-md-12");
            __builder.AddMarkupContent(156, "\r\n            ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "card");
            __builder.AddMarkupContent(159, "\r\n                ");
            __builder.AddMarkupContent(160, "<h5 class=\"card-header\">Lista de Prefeituras</h5>\r\n                ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "card-body");
            __builder.AddMarkupContent(163, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Prefeitura>>(164);
            __builder.AddAttribute(165, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Prefeitura>>(
#nullable restore
#line 104 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                          filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(166, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 104 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                             FilterMode.Simple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(167, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 104 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(168, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 104 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 104 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "Style", "margin-bottom: 50px; color:red;");
            __builder.AddAttribute(171, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(172, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(173);
                __builder2.AddAttribute(174, "Property", "id");
                __builder2.AddAttribute(175, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(176, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(177);
                __builder2.AddAttribute(178, "Property", "nomePrefeitura");
                __builder2.AddAttribute(179, "Title", "Nome da Prefeitura");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(180, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(181);
                __builder2.AddAttribute(182, "Property", "ultimaAtualizacao");
                __builder2.AddAttribute(183, "Title", "Última Atualização");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(184, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(185);
                __builder2.AddAttribute(186, "Property", "situacao");
                __builder2.AddAttribute(187, "Title", "Situação da Prefeitura");
                __builder2.AddAttribute(188, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Prefeitura>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(189, "\r\n");
#nullable restore
#line 111 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                     if (data.situacao == "Desatualizada por mais de uma semana")
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(190, "                                        ");
                    __builder3.OpenElement(191, "span");
                    __builder3.AddAttribute(192, "style", "color:red");
                    __builder3.AddContent(193, 
#nullable restore
#line 113 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                 data.situacao

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(194, "\r\n");
#nullable restore
#line 114 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                    }
                                    else if (data.situacao == "Desatualizada")
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(195, "                                        ");
                    __builder3.OpenElement(196, "span");
                    __builder3.AddAttribute(197, "style", "color: #ff6d41");
                    __builder3.AddContent(198, 
#nullable restore
#line 117 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                      data.situacao

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(199, "\r\n");
#nullable restore
#line 118 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(200, "                                        ");
                    __builder3.OpenElement(201, "span");
                    __builder3.AddAttribute(202, "style", "color:#5b707b");
                    __builder3.AddContent(203, 
#nullable restore
#line 121 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                     data.situacao

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(204, "\r\n");
#nullable restore
#line 122 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(205, "                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(206, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(207, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n");
#nullable restore
#line 131 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
       

    GraficoBarra atualizados = new GraficoBarra();
    GraficoBarra atualizados24hrs = new GraficoBarra();
    GraficoBarra desatualizados = new GraficoBarra();
    GraficoBarra desatualizadosMaisDeUmaSemana = new GraficoBarra();

    private IEnumerable<Prefeitura> prefeituras;
    List<Grafico> graficoCircularPrefeiturasDesatualizadas = new List<Grafico>();
    List<Grafico> prefeiturasAtualizadas = new List<Grafico>();
    List<Grafico> prefeiturasAtualizadas24hrs = new List<Grafico>();
    List<Grafico> prefeiturasDesatualizadas = new List<Grafico>();
    List<Grafico> prefeiturasDesatualizadasMaisDeUmaSemana = new List<Grafico>();

    double prefeiturasAtualizadasCount = 0,
    prefeiturasAtualizadasUltimas24hrsCount = 0,
    prefeiturasDesatualizadasCount = 0,
    prefeiturasDesatualizadasMaisDeUmaSemanaCount = 0;

    IEnumerable<Prefeitura> filtro;

    [Inject]
    public NavigationManager navigationManager { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            prefeituras = await PrefeituraServico.TodasPrefeituras();
            InserirDados(prefeituras);

            filtro = await PreencherTabelaPrincipalPrefeituras(prefeituras);
            //Task.Delay(ConfiguracaoServico.ConfiguracaoAtual()).ContinueWith(t => AtualizarPagina());
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void AtualizarPagina()
    {
        navigationManager.NavigateTo("/PrefeiturasAtualizadas", true);
    }

    public async Task<IEnumerable<Prefeitura>> PreencherTabelaPrincipalPrefeituras(IEnumerable<Prefeitura> prefeituras)
    {
        List<Prefeitura> listaPrefeituras = new List<Prefeitura>();

        foreach (var item in prefeituras)
        {
            if(item.situacao == "4") {
                item.situacao = "Desatualizada por mais de uma semana";
                listaPrefeituras.Add(item);
            }
            if (item.situacao == "3" && prefeiturasDesatualizadasMaisDeUmaSemanaCount == 0) {
                item.situacao = "Desatualizada";
                listaPrefeituras.Add(item);
            }
            if (item.situacao == "2" && prefeiturasDesatualizadasCount == 0 && prefeiturasDesatualizadasMaisDeUmaSemanaCount == 0) {
                item.situacao = "Atualizada nas últimas 24hrs";
                listaPrefeituras.Add(item);
            }
            if(item.situacao == "1" && prefeiturasAtualizadasUltimas24hrsCount == 0 && prefeiturasDesatualizadasMaisDeUmaSemanaCount == 0) {
                item.situacao = "Atualizada";
                listaPrefeituras.Add(item);
            }
        }

        return listaPrefeituras;
    }

    public async Task<IEnumerable<Prefeitura>> PreencherTabelaPrefeituras()
    {
        return await PrefeituraServico.ListaDePrefeituras(4);
    }

    public void InserirDados(IEnumerable<Prefeitura> prefeituras)
    {
        foreach (var item in prefeituras)
        {
            switch (item.situacao)
            {
                case "1":
                    prefeiturasAtualizadasCount++;
                    break;
                case "2":
                    prefeiturasAtualizadasUltimas24hrsCount++;
                    break;
                case "3":
                    prefeiturasDesatualizadasCount++;
                    break;
                case "4":
                    prefeiturasDesatualizadasMaisDeUmaSemanaCount++;
                    break;
            }
        }

        prefeiturasAtualizadas.Add(new Grafico() { texto = "Prefeituras Atualizadas", valores = prefeiturasAtualizadasCount });
        prefeiturasAtualizadas24hrs.Add(new Grafico() { texto = "Prefeituras Atualizadas Últimas 24hrs", valores = prefeiturasAtualizadasUltimas24hrsCount });
        prefeiturasDesatualizadas.Add(new Grafico() { texto = "Prefeituras Desatualizadas", valores = prefeiturasDesatualizadasCount });
        prefeiturasDesatualizadasMaisDeUmaSemana.Add(new Grafico() { texto = "Prefeituras Por mais de Uma Semana", valores = prefeiturasDesatualizadasMaisDeUmaSemanaCount });

        graficoCircularPrefeiturasDesatualizadas.Add(new Grafico() { texto = "Prefeituras Desatualizadas", valores = prefeiturasDesatualizadasCount });
        graficoCircularPrefeiturasDesatualizadas.Add(new Grafico() { texto = "Prefeituras Por mais de Uma Semana", valores = prefeiturasDesatualizadasMaisDeUmaSemanaCount });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguracaoServico ConfiguracaoServico { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPrefeituraServico PrefeituraServico { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGraficoServico GraficoServico { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient https { get; set; }
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
