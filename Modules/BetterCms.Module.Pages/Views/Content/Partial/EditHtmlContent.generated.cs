﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.UI;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Partial/EditHtmlContent.cshtml")]
    public partial class _Views_Content_Partial_EditHtmlContent_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public _Views_Content_Partial_EditHtmlContent_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.HiddenFor(model => model.EditInSourceMode, new { @id = "bcms-edit-in-source-mode" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.HiddenFor(model => model.ContentTextMode, new { @id = "bcms-content-text-mode" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-newcontent-top\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_ContentName_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
   Write(Html.Tooltip(PagesGlobalization.AddPageContent_RegularContentTab_ContentName_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.TextBoxFor(model => model.ContentName, new { @class = "bcms-field-text"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.ContentName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_LiveFrom_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.DateTextBoxFor(model => model.LiveFrom, Model.LiveFrom, new Dictionary<string, object> { { "class", "bcms-field-text bcms-datepicker" }, { "style", "width: 127px;" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.LiveFrom));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 28 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_LiveTo_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.DateTextBoxFor(model => model.LiveTo, Model.LiveTo, new Dictionary<string, object> { { "class", "bcms-field-text bcms-datepicker" }, { "style", "width: 127px;" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.LiveTo));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-text-editor-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 37 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.TextAreaFor(model => model.PageContent, new { @class = "bcms-contenthtml", @id = Guid.NewGuid() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
