#pragma checksum "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "056c19b573204b12de98e904c27420b385c4f91f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planilha_Index), @"mvc.1.0.view", @"/Views/Planilha/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\_ViewImports.cshtml"
using FocusHealthSolutionsTeste1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\_ViewImports.cshtml"
using FocusHealthSolutionsTeste1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056c19b573204b12de98e904c27420b385c4f91f", @"/Views/Planilha/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed91fc61cad6097c6fdbb6eb2f95a1a7dab63be", @"/Views/_ViewImports.cshtml")]
    public class Views_Planilha_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlanilhaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
  
    ViewData["Title"] = "Planilha de Controle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-primary text-left"" style=""padding-left: 10px"">
    <a>Planilha de Controle</a>
</div>
<br />
<div class=""d-grid gap-2"">
    <button class=""btn"" style="" background-color: #F1F1F1"" type=""submit"">Exportar para Excel</button>
</div>
<br />
<table class=""table"" id=""table-planilha"">

    <thead>
        <tr style="" background-color: #F1F1F1"">
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Agendado em</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Ficha</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Parceiro</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Colaborador</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px ");
            WriteLiteral(@"solid grey"">Natureza</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Agendado para</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Conf.</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Pres.</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">ASO Up.</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">ASO Prot.</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Pend.</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Tem Av.</th>
            <th scope=""col"" class=""font-weight-nor");
            WriteLiteral(@"mal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Tem Res.</th>
            <th scope=""col"" class=""font-weight-normal"" style=""border-left: 1px solid grey; border-right: 1px solid grey"">Editar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
         if (Model != null && Model.Any())
        {
            foreach (PlanilhaModel dado in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\" style=\"border-left: 1px solid grey; border-right: 1px solid grey\">");
#nullable restore
#line 39 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                                                                                                 Write(dado.Agendado_Em);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">");
#nullable restore
#line 40 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                                                                                     Write(dado.Ficha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">");
#nullable restore
#line 41 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                                                                                     Write(dado.Parceiro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">");
#nullable restore
#line 42 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                                                                                     Write(dado.Colaborador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">");
#nullable restore
#line 43 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                                                                                     Write(dado.Natureza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">");
#nullable restore
#line 44 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                                                                                     Write(dado.Agendado_Para);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n");
#nullable restore
#line 46 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                         if (dado.Conf)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check\"></i>\r\n");
#nullable restore
#line 50 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-x-lg\"></i>\r\n");
#nullable restore
#line 54 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n");
#nullable restore
#line 57 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                         if (dado.Pres)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check\"></i>\r\n");
#nullable restore
#line 60 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-x-lg\"></i>\r\n");
#nullable restore
#line 64 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n");
#nullable restore
#line 67 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                         if (dado.ASO_Up)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check\"></i>\r\n");
#nullable restore
#line 70 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-x-lg\"></i>\r\n");
#nullable restore
#line 74 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n");
#nullable restore
#line 77 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                         if (dado.ASO_Prot)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check\"></i>\r\n");
#nullable restore
#line 80 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-x-lg\"></i>\r\n");
#nullable restore
#line 84 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n");
#nullable restore
#line 87 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                         if (dado.Pend)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check\"></i>\r\n");
#nullable restore
#line 90 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-x-lg\"></i>\r\n");
#nullable restore
#line 94 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n");
#nullable restore
#line 97 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                         if (dado.Tem_Av)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check\"></i>\r\n");
#nullable restore
#line 100 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-x-lg\"></i>\r\n");
#nullable restore
#line 104 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n");
#nullable restore
#line 107 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                         if (dado.Tem_Res)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check\"></i>\r\n");
#nullable restore
#line 110 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-x-lg\"></i>\r\n");
#nullable restore
#line 114 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"border-left: 1px solid grey; border-right: 1px solid grey\">\r\n                        <a type=\"submit\" class=\"btn\" style=\" background-color: #F1F1F1\"");
            BeginWriteAttribute("href", " href=\"", 6292, "\"", 6333, 2);
            WriteAttributeValue("", 6299, "/Planilha/Editar?ficha=", 6299, 23, true);
#nullable restore
#line 117 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
WriteAttributeValue("", 6322, dado.Ficha, 6322, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Confirmar</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 120 "C:\Users\Trabalho\Documents\focusEstudos\FocusHealthSolutionsTeste1\FocusHealthSolutionsTeste1\Views\Planilha\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PlanilhaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591