#pragma checksum "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7caa53139320eae32d8a01855207a494c0641532"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Delete), @"mvc.1.0.view", @"/Views/Pessoa/Delete.cshtml")]
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
#line 1 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\_ViewImports.cshtml"
using VSoftware.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\_ViewImports.cshtml"
using VSoftware.IO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7caa53139320eae32d8a01855207a494c0641532", @"/Views/Pessoa/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d30db3aa4ed5aa71848bc3f363d04b4093d0c7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VSoftware.IO.ViewModels.PessoaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
  
    ViewData["Title"] = "Excluir " + Model.Nome;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 style=\"padding-top: 50px;\">");
#nullable restore
#line 7 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<h5>Você tem certeza disso?</h5>\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-6\">\r\n        <dl>\r\n            <dt>\r\n                ");
#nullable restore
#line 16 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 19 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 22 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 25 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 28 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dt>\r\n                ");
#nullable restore
#line 31 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dt>\r\n                ");
#nullable restore
#line 34 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.OpcaoSexual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                <input type=\"radio\" value=\"1\" disabled");
            BeginWriteAttribute("checked", " checked=\"", 1017, "\"", 1052, 1);
#nullable restore
#line 37 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
WriteAttributeValue("", 1027, Model.OpcaoSexual == 1, 1027, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />  Masculino<br />\r\n                <input type=\"radio\" value=\"2\" disabled");
            BeginWriteAttribute("checked", " checked=\"", 1129, "\"", 1164, 1);
#nullable restore
#line 38 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
WriteAttributeValue("", 1139, Model.OpcaoSexual == 2, 1139, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />  Feminino <br />\r\n                <input type=\"radio\" value=\"3\" disabled");
            BeginWriteAttribute("checked", " checked=\"", 1241, "\"", 1276, 1);
#nullable restore
#line 39 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
WriteAttributeValue("", 1251, Model.OpcaoSexual == 3, 1251, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />  Outros\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 42 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 45 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 48 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Profissao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 51 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Profissao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7caa53139320eae32d8a01855207a494c064153210259", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7caa53139320eae32d8a01855207a494c064153210534", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 58 "C:\Users\Prodwin\Desktop\VSoftware_Mediator_01\Projeto_CadastroPessoa\src\VSFoftware.IO\Views\Pessoa\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger\" />\r\n                <a class=\"btn btn-info\" href=\"javascript:window.history.back();\">Voltar</a>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VSoftware.IO.ViewModels.PessoaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
