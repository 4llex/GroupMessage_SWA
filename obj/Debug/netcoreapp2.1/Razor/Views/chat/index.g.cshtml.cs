#pragma checksum "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b66f8056c9b5c129c5bafa1deb7b74a0a77a441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_chat_index), @"mvc.1.0.view", @"/Views/chat/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/chat/index.cshtml", typeof(AspNetCore.Views_chat_index))]
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
#line 1 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\_ViewImports.cshtml"
using GroupMessageApplication;

#line default
#line hidden
#line 2 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
using GroupMessageApplication.Models;

#line default
#line hidden
#line 4 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\_ViewImports.cshtml"
using GroupMessageApplication.Models.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b66f8056c9b5c129c5bafa1deb7b74a0a77a441", @"/Views/chat/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1ce5643d835c0d7926fc7bb89811cc254a9a27", @"/Views/_ViewImports.cshtml")]
    public class Views_chat_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CreateGroupForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(156, 35, true);
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(191, 1306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9964d164781f4858ab4cfd6c5bba1e41", async() => {
                BeginContext(197, 1293, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.3/css/bootstrap.min.css"" integrity=""sha384-Zug+QiDoJOrZ5t4lssLdxGhVrurbmBWopoEl+M6BdEfwnCJZtKxi1KgxUyJq13dy"" crossorigin=""anonymous"">
    <title>DotNet Group Chat</title>
    <style type=""text/css"">
        .group {
            padding: 13px;
            border-radius: 12px;
            background: rgb(57, 125, 192);
            margin: 5px 0px;
            font-weight: bolder;
            color: black;
            cursor: pointer;
        }

        .chat_body {
            height: 520px;
            overflow: scroll;
        }

        .less_padding {
            padding: 2px;
        }

        .chat_message {
            padding: 13px;
            border-radius: 12px;
            width: 50%;
            background: ");
                WriteLiteral(@"#85C1E9;
            margin: 6px 4px;
        }

        .chat_main {
            background-color: #957bbe;
            height: 520;
            padding: 0px;
        }

        .group_main {
            background-color: #85C1E9;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1497, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1499, 4854, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c5d1d96143c4588a20bc07d03b8cb4c", async() => {
                BeginContext(1505, 382, true);
                WriteLiteral(@"
    <h3 class=""text-center"">Bem vindo!</h3>
    <div class=""container"" style=""background-color: grey;"">
        <div class=""row"">
            <div class=""col-md-2 less_padding"">
                <div class=""col group_main"">
                    <div class=""text-center""> Grupos </div>
                    <div clsss=""row"" style=""height: 500px;overflow: scroll;"" id=""groups"">
");
                EndContext();
#line 64 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
                         foreach (var group in (dynamic)ViewData["UserGroups"])
                        {

#line default
#line hidden
                BeginContext(1995, 62, true);
                WriteLiteral("                            <div class=\"group\" data-group_id=\"");
                EndContext();
                BeginContext(2058, 13, false);
#line 66 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
                                                         Write(group.GroupId);

#line default
#line hidden
                EndContext();
                BeginContext(2071, 3, true);
                WriteLiteral("\"> ");
                EndContext();
                BeginContext(2075, 15, false);
#line 66 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
                                                                          Write(group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(2090, 9, true);
                WriteLiteral(" </div>\r\n");
                EndContext();
#line 67 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2126, 1965, true);
                WriteLiteral(@"                    </div>
                    <div class=""text-center"">
                        <button type=""submit"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#CreateNewGroup"">Adicionar Grupo</button>
                    </div>
                </div>
            </div>
            <div class=""col-md-10 less_padding"">
                <div class=""col-md-12 chat_main"">
                    <input type=""hidden"" value="""" id=""currentGroup"">
                    <div class=""chat_body"">
                        <!-- <div class=""chat_message float-right"">Hello, </div> -->
                    </div>
                    <div class=""row container"" style=""margin-left: 3px;"">
                        <div class=""col-md-9 col-sm-9 less_padding"">
                            <textarea class=""form-control"" rows=""1"" id=""Message""></textarea>
                        </div>
                        <div class=""col-md-3 col-sm-3 less_padding"">
                            <button type=""submit"" class=""btn");
                WriteLiteral(@" btn-primary"" style="" position: absolute;"" id=""SendMessage"">Enviar Mensagem</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



    <!--  *************************   -->
    <!-- Modal -->
    <div class=""modal fade"" id=""CreateNewGroup"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Adicionar Novo Grupo</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(4091, 1164, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14b0cd06f6f5425595019790a71618ab", async() => {
                    BeginContext(4118, 499, true);
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""GroupName"">Nome do Grupo</label>
                            <input type=""text"" class=""form-control"" name=""GroupName"" id=""GroupName"" aria-describedby=""emailHelp"" placeholder=""Group Name"">
                        </div>
                        <label for=""User"">Adicionar usuários ao grupo<br></label> <br>
                        <div class=""row"">
                            <!-- List users here -->
");
                    EndContext();
#line 115 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
                             foreach (var user in (dynamic)ViewData["Users"])
                            {

#line default
#line hidden
                    BeginContext(4727, 202, true);
                    WriteLiteral("                                <div class=\"col-4\">\r\n                                    <div class=\"form-check\">\r\n                                        <input type=\"checkbox\" class=\"form-check-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 4929, "\"", 4951, 1);
#line 119 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
WriteAttributeValue("", 4937, user.UserName, 4937, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(4952, 105, true);
                    WriteLiteral(" name=\"UserName[]\">\r\n                                        <label class=\"form-check-label\" for=\"Users\">");
                    EndContext();
                    BeginContext(5058, 13, false);
#line 120 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
                                                                               Write(user.UserName);

#line default
#line hidden
                    EndContext();
                    BeginContext(5071, 94, true);
                    WriteLiteral("</label>\r\n                                    </div>\r\n                                </div>\r\n");
                    EndContext();
#line 123 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
                            }

#line default
#line hidden
                    BeginContext(5196, 52, true);
                    WriteLiteral("                        </div>\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5255, 1027, true);
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                    <button type=""button"" class=""btn btn-primary"" id=""CreateNewGroupButton"">Criar Grupo</button>
                </div>
            </div>
        </div>
    </div>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.2.1.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.3/js/bootstrap.min.js"" integrity=""sha384-a5N7Y/aK3qNeh15eJKGWxsqtnX/wWdSZSKp+81YjTmS15nvnvxKHuzaWwXHDli+4"" crossorigin=""anonymous""></script>
    <script src=""https://js.pusher.com/4.1/pusher.min.js""></script>
 ");
                WriteLiteral("   ");
                EndContext();
                BeginContext(6282, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0855b956140d4d9680cfd5d69a45a637", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 140 "C:\Users\alex_\source\repos\GroupMessageApplication\GroupMessageApplication\Views\chat\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6344, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6353, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
