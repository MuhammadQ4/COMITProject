#pragma checksum "F:\ComIT\MyProject\Views\Home\Living.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27b9f65647b9e0bf179b74efc2945af6ab179ab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Living), @"mvc.1.0.view", @"/Views/Home/Living.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Living.cshtml", typeof(AspNetCore.Views_Home_Living))]
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
#line 1 "F:\ComIT\MyProject\Views\_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#line 2 "F:\ComIT\MyProject\Views\_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b9f65647b9e0bf179b74efc2945af6ab179ab5", @"/Views/Home/Living.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Living : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "PerMonth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Retail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("sortProds"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
  
    List<Products> prodList = (List<Products>)ViewData["prods"];
    List<subCategory> optionsList = (List<subCategory>)ViewData["options"];

#line default
#line hidden
            BeginContext(150, 538, true);
            WriteLiteral(@"
<style>
div.a {
  position: relative;
  width: 400px;
  height: 200px;
  border: 3px solid red;
}

div.b {
  position: absolute;
  left: -10px;
  width: 100px;
  height: 120px;
  border: 3px solid blue;
} 

div.c {
  position: absolute;
  right: 250px;
} 
</style>

<div class=""row"">
    <div class = ""container pull-right"" style = ""margin-top: 20px"">
        <span class=""input-group-addon"" style=""width:0px; padding-left:0px; padding-right:0px; border:none;""></span>
        <div class = ""col-md-6"">
        ");
            EndContext();
            BeginContext(688, 493, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d08a1138686b41648e9b96eb3c2ed332", async() => {
                BeginContext(723, 34, true);
                WriteLiteral("\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 757, "\"", 788, 1);
#line 33 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
WriteAttributeValue("", 765, ViewData["categoryId"], 765, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(789, 137, true);
                WriteLiteral(" name=\"catID\">\r\n            <select  name=\"subcatID\" id = \"subcatID\" size=\"1\" onchange=\"this.form.submit();\" value=\" \">\r\n                ");
                EndContext();
                BeginContext(926, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c44d1739cda24957b9cfc896986c4ad3", async() => {
                    BeginContext(943, 17, true);
                    WriteLiteral("Select a Category");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(969, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 36 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                 foreach (var item in optionsList)
                {

#line default
#line hidden
                BeginContext(1042, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1062, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "670c0c12b0944e648d5434961c379f88", async() => {
                    BeginContext(1094, 15, false);
#line 38 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                                              Write(item.subcatName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 38 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                       WriteLiteral(item.subcatID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1118, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                }

#line default
#line hidden
                BeginContext(1139, 35, true);
                WriteLiteral("            </select>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1181, 70, true);
            WriteLiteral("\r\n        </div>\r\n        \r\n        <div class = \"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(1251, 506, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dabf91d85c17467ba987ab3e847f2944", async() => {
                BeginContext(1289, 34, true);
                WriteLiteral("\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1323, "\"", 1354, 1);
#line 46 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
WriteAttributeValue("", 1331, ViewData["categoryId"], 1331, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1355, 48, true);
                WriteLiteral(" name=\"catID\">\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1403, "\"", 1437, 1);
#line 47 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
WriteAttributeValue("", 1411, ViewData["subCategoryId"], 1411, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1438, 111, true);
                WriteLiteral(" name=\"subcatID\">\r\n            <select name = \"sort\" size=\"1\" onchange=\"this.form.submit();\">\r\n                ");
                EndContext();
                BeginContext(1549, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6c3aec7bf8b4ffda1fc4923eb1dd785", async() => {
                    BeginContext(1566, 10, true);
                    WriteLiteral("---Sort---");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1585, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1603, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87fceffc3154e13b4cfc23f1a23491d", async() => {
                    BeginContext(1628, 16, true);
                    WriteLiteral("Sort by PerMonth");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1653, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1671, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0e1299f863747d6bd2d3797eddd027e", async() => {
                    BeginContext(1694, 14, true);
                    WriteLiteral("Sort by Retail");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1717, 33, true);
                WriteLiteral("\r\n            </select>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1757, 360, true);
            WriteLiteral(@"
        </div>

        <span class=""input-group-addon"" style=""width:0px; padding-left:0px; padding-right:0px; border:none;""></span>
    </div>  
</div>





<!-- </div> 
            <div class = ""col-md-6"">
            <select size=""1"" onchange=""this.form.submit();"" name=""subcatID"">
                <option value="""">Select an option</option>
");
            EndContext();
#line 68 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                 foreach (var item in optionsList)
                {

#line default
#line hidden
            BeginContext(2188, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2208, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0a712defeb940e281bee355e4f25faa", async() => {
                BeginContext(2240, 15, false);
#line 70 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                                              Write(item.subcatName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 70 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                       WriteLiteral(item.subcatID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2264, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 71 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
                }

#line default
#line hidden
            BeginContext(2285, 48, true);
            WriteLiteral("            </select>\r\n            </div>  -->\r\n");
            EndContext();
#line 74 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
 if(prodList.Count()==0)
{

#line default
#line hidden
            BeginContext(2362, 29, true);
            WriteLiteral("    <h3>No item found.</h3>\r\n");
            EndContext();
#line 77 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
}

#line default
#line hidden
            BeginContext(2394, 24, true);
            WriteLiteral("\r\n\r\n<div class=\"row\" >\r\n");
            EndContext();
#line 81 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
     foreach(var item in prodList)
    {

#line default
#line hidden
            BeginContext(2461, 68, true);
            WriteLiteral("        <div class=\"col-md-4 panel panel-default\">\r\n            <h3>");
            EndContext();
            BeginContext(2530, 13, false);
#line 84 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
           Write(item.prodName);

#line default
#line hidden
            EndContext();
            BeginContext(2543, 98, true);
            WriteLiteral("</h3>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(2642, 15, false);
#line 87 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
               Write(item.prodRetail);

#line default
#line hidden
            EndContext();
            BeginContext(2657, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(2744, 17, false);
#line 90 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
               Write(item.prodPerMonth);

#line default
#line hidden
            EndContext();
            BeginContext(2761, 171, true);
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <button class=\"btn btn-success\">Buy</button>\r\n                </div>\r\n            </div>\r\n    </div>\r\n");
            EndContext();
#line 97 "F:\ComIT\MyProject\Views\Home\Living.cshtml"
}

#line default
#line hidden
            BeginContext(2935, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
