#pragma checksum "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98c74d7d858c8e2fea0de2337303bdaaade23379"
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
#line 11 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
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
#line 15 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                  100

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ProgressBarMode>(
#nullable restore
#line 15 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
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
#line 18 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddAttribute(12, "style", "border: 15px solid transparent; text-align: center; padding: 0px 0px;");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "cpanel cpanel-blue");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "icon-part");
            __builder.AddMarkupContent(17, "<i class=\"fas fa-check\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(18, "<small>Prefeituras atualizadas</small>\r\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, 
#nullable restore
#line 26 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    prefeiturasAtualizadasCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<div class=\"card-content-part\"><a href=\"PrefeiturasAtualizadas\">Mais Detalhes +</a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "cpanel cpanel-green");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "icon-part");
            __builder.AddMarkupContent(28, "<i class=\"fas fa-clock\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(29, "<small>Prefeituras atualizadas nas últimas 24hrs</small>\r\n                ");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, 
#nullable restore
#line 36 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    prefeiturasAtualizadasUltimas24hrsCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<div class=\"card-content-part\"><a href=\"PrefeiturasAtualizadas24hrs\">Mais Detalhes +</a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "cpanel cpanel-orange");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "icon-part");
            __builder.AddMarkupContent(39, "<i class=\"fas fa-exclamation-circle\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(40, "<small>Prefeituras desatualizadas</small>\r\n                ");
            __builder.OpenElement(41, "p");
            __builder.AddContent(42, 
#nullable restore
#line 46 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    prefeiturasDesatualizadasCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.AddMarkupContent(44, "<div class=\"card-content-part\"><a href=\"PrefeiturasDesatualizadas\">Mais Detalhes + </a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "cpanel cpanel-red");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "icon-part");
            __builder.AddMarkupContent(50, "<i class=\"fas fa-times-circle\" aria-hidden=\"true\"></i><br>\r\n                ");
            __builder.AddMarkupContent(51, "<small>Prefeituras desatualizadas a mais de 24Hrs</small>\r\n                ");
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, 
#nullable restore
#line 56 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                    prefeiturasDesatualizadasMaisDeUmaSemanaCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.AddMarkupContent(55, "<div class=\"card-content-part\"><a href=\"PrefeiturasDesatualizadasMaisDeUmaSemana\">Mais Detalhes + </a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-md-7");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "card");
            __builder.OpenElement(63, "h5");
            __builder.AddAttribute(64, "class", "card-header");
            __builder.AddContent(65, "Lista de Prefeituras ");
            __builder.AddContent(66, 
#nullable restore
#line 66 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                              teste

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "card-body");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Prefeitura>>(70);
            __builder.AddAttribute(71, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Prefeitura>>(
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                          filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                             FilterMode.Simple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                                                                                                                                          6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(78);
                __builder2.AddAttribute(79, "Property", "id");
                __builder2.AddAttribute(80, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(82);
                __builder2.AddAttribute(83, "Property", "nomePrefeitura");
                __builder2.AddAttribute(84, "Title", "Nome da Prefeitura");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Prefeitura>>(86);
                __builder2.AddAttribute(87, "Property", "ultimaAtualizacao");
                __builder2.AddAttribute(88, "Title", "Última Atualização");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-md-5");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "card");
            __builder.AddMarkupContent(94, "<h5 class=\"card-header\">Gráfico de Status da Sincronização</h5>\r\n                ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "card-body");
            __builder.AddAttribute(97, "style", "height:406px");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(98);
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.BlazorCRUD.UI.Pages.Index.TypeInference.CreateRadzenPieSeries_0(__builder2, 100, 101, 
#nullable restore
#line 83 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
                                                graficoCircularPrefeiturasDesatualizadas

#line default
#line hidden
#nullable disable
                , 102, "Quantidade", 103, "texto", 104, "valores");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\Marcelo\Desktop\Pastas\Dashboard-AdmSistemas\DashboardADM\BlazorCRUD.UI\Pages\Index.razor"
       

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

    string teste;

    IEnumerable<Prefeitura> filtro;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            prefeituras = await PrefeituraServico.TodasPrefeituras();
            InserirDados(prefeituras);

            filtro = await PreencherTabelaPrincipalPrefeituras(prefeituras);
            Task.Delay(1800000).ContinueWith(t => AtualizarPagina());
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
            if (item.situacao == "4")
            {
                listaPrefeituras.Add(item);
                teste = "Desatualizadas a mais de uma semana";
            }
            if (item.situacao == "3" && prefeiturasDesatualizadasMaisDeUmaSemanaCount == 0)
            {
                listaPrefeituras.Add(item);
                teste = "Desatualizadas";
            }
            if (item.situacao == "2" && prefeiturasDesatualizadasCount == 0 && prefeiturasDesatualizadasMaisDeUmaSemanaCount == 0)
            {
                listaPrefeituras.Add(item);
                teste = "Atualizadas nas últimas 24Hrs";
            }
            if (item.situacao == "1" && prefeiturasAtualizadasUltimas24hrsCount == 0 && prefeiturasDesatualizadasMaisDeUmaSemanaCount == 0)
            {
                listaPrefeituras.Add(item);
                teste = "Atualizadas";
            }
        }

        return listaPrefeituras;
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
        prefeiturasDesatualizadasMaisDeUmaSemana.Add(new Grafico() { texto = "Prefeituras a mais de Uma Semana", valores = prefeiturasDesatualizadasMaisDeUmaSemanaCount });

        graficoCircularPrefeiturasDesatualizadas.Add(new Grafico() { texto = "Atualizadas", valores = prefeiturasAtualizadasCount });
        graficoCircularPrefeiturasDesatualizadas.Add(new Grafico() { texto = "Atualizadas Últimas 24hrs", valores = prefeiturasAtualizadasUltimas24hrsCount });
        graficoCircularPrefeiturasDesatualizadas.Add(new Grafico() { texto = "Desatualizadas", valores = prefeiturasDesatualizadasCount });
        graficoCircularPrefeiturasDesatualizadas.Add(new Grafico() { texto = "Desatualizadas a mais de uma semana", valores = prefeiturasDesatualizadasMaisDeUmaSemanaCount });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
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
        public static void CreateRadzenPieSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenPieSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
