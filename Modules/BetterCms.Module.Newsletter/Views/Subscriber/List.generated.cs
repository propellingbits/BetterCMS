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
    
    #line 1 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Newsletter.Content.Resources;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Subscriber\List.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Subscriber/List.cshtml")]
    public partial class _Views_Subscriber_List_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Subscriber_List_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-window-settings\"");

WriteLiteral(">\r\n");

            
            #line 8 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Subscriber\List.cshtml"
      
        var gridViewModel = new EditableGridViewModel { ShowMessages = true, TopBlockTitle = NewsletterGlobalization.SiteSettings_NewsletterSubscribers_Title, Columns = new List<EditableGridColumn> { new EditableGridColumn(NewsletterGlobalization.SiteSettings_NewsletterSubscribers_Email_Title, "Email", "email") { AutoFocus = true, FocusIdentifier = "hasFocus" } } };
    
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 665), Tuple.Create("\"", 701)
            
            #line 11 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 673), Tuple.Create<System.Object, System.Int32>(gridViewModel.TopBlockClass
            
            #line default
            #line hidden
, 673), false)
);

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-top-controls-btn-holder\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Views\Subscriber\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Subscriber\List.cshtml"
             if (gridViewModel.CanAddNewItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" data-bind=\"click: addNewItem\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Subscriber\List.cshtml"
                                                                    Write(gridViewModel.AddNewTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-opener\"");

WriteLiteral("> </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-opener-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-opener-link\"");

WriteLiteral(" id=\"download-subscribers-in-csv\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Subscriber\List.cshtml"
                                                                                  Write(NewsletterGlobalization.Download_NewsletterSubscribers_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n");

            
            #line 20 "..\..\Views\Subscriber\List.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 22 "..\..\Views\Subscriber\List.cshtml"
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Subscriber\List.cshtml"
         if (gridViewModel.ShowSearch)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(" data-bind=\"css: { \'bcms-active-search\' : searchEnabled }\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" data-bind=\"click: toggleSearch\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Subscriber\List.cshtml"
                                                                        Write(RootGlobalization.Button_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" class=\"bcms-search-field-box\"");

WriteLiteral(" data-bind=\"value: options().searchQuery, valueUpdate: \'afterkeydown\', enterPress" +
": searchItems, hasfocus: options().hasFocus\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1762), Tuple.Create("\"", 1811)
            
            #line 27 "..\..\Views\Subscriber\List.cshtml"
                                                                                                                               , Tuple.Create(Tuple.Create("", 1776), Tuple.Create<System.Object, System.Int32>(RootGlobalization.WaterMark_Search
            
            #line default
            #line hidden
, 1776), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n");

            
            #line 30 "..\..\Views\Subscriber\List.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 31 "..\..\Views\Subscriber\List.cshtml"
         if (gridViewModel.AddPaging)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n                <!-- ko with: options().paging -->\r\n                <div");

WriteLiteral(" class=\"bcms-featured-grid bcms-clearfix\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\Views\Subscriber\List.cshtml"
               Write(Html.Partial(gridViewModel.PagingView, gridViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <!-- /ko -->\r\n            </div>\r\n");

            
            #line 40 "..\..\Views\Subscriber\List.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n");

            
            #line 43 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\Subscriber\List.cshtml"
     if (gridViewModel.ShowMessages)
    {
        
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Subscriber\List.cshtml"
   Write(Html.MessagesBox(null, new Dictionary<string, string> { { "data-bind", "attr: { id: messagesDomId() }" } }));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Subscriber\List.cshtml"
                                                                                                                    
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 48 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Subscriber\List.cshtml"
      
        var visibleColumns = gridViewModel.Columns.Where(c => c.IsRendered).ToList();
        var visibleColumnsCount = visibleColumns.Count;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <table");

WriteLiteral(" class=\"bcms-tables\"");

WriteLiteral(">\r\n        <thead>\r\n        <tr>\r\n            <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</th>\r\n");

            
            #line 57 "..\..\Views\Subscriber\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Subscriber\List.cshtml"
             foreach (var column in visibleColumns)
            {
                
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Subscriber\List.cshtml"
           Write(Html.Partial(column.HeaderView, column));

            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Subscriber\List.cshtml"
                                                        
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(" style=\"width: 145px;\"");

WriteLiteral(">&nbsp;</th>\r\n        </tr>\r\n        </thead>\r\n        <tbody>\r\n        <!-- ko f" +
"oreach: items -->\r\n        <tr");

WriteLiteral(" data-bind=\"click: onOpen, css: {\'bcms-table-row-active\' : isActive() || isSelect" +
"edForInsert()}, attr: {id: getRowId()}\"");

WriteLiteral(">\r\n            <!-- ko if: saving() || deleting() -->\r\n");

            
            #line 68 "..\..\Views\Subscriber\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Subscriber\List.cshtml"
             if (gridViewModel.CanEditItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</td>\r\n");

WriteLiteral("                <!-- ko if: saving() -->\r\n");

WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 3418), Tuple.Create("\"", 3448)
            
            #line 72 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 3428), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount
            
            #line default
            #line hidden
, 3428), false)
);

WriteLiteral(">");

            
            #line 72 "..\..\Views\Subscriber\List.cshtml"
                                                                          Write(RootGlobalization.Message_Saving);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                <!-- /ko -->\r\n");

            
            #line 74 "..\..\Views\Subscriber\List.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 75 "..\..\Views\Subscriber\List.cshtml"
             if (gridViewModel.CanEditItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(" style=\"width: 145px;\"");

WriteLiteral(">&nbsp;</td>\r\n");

WriteLiteral("                <!-- ko if: deleting() -->\r\n");

WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 3770), Tuple.Create("\"", 3800)
            
            #line 79 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 3780), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount
            
            #line default
            #line hidden
, 3780), false)
);

WriteLiteral(">");

            
            #line 79 "..\..\Views\Subscriber\List.cshtml"
                                                                          Write(RootGlobalization.Message_Deleting);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                <!-- /ko -->\r\n");

            
            #line 81 "..\..\Views\Subscriber\List.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <!-- /ko -->\r\n            <!-- ko ifnot: saving() || deleting() -->\r\n" +
"");

            
            #line 84 "..\..\Views\Subscriber\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Subscriber\List.cshtml"
             if (gridViewModel.CanEditItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td>\r\n                    <!-- ko if: !editingIsDisabled() -->\r\n " +
"                   <a");

WriteLiteral(" class=\"bcms-icn-edit\"");

WriteLiteral(" data-bind=\"click: onEdit\"");

WriteLiteral(">");

            
            #line 88 "..\..\Views\Subscriber\List.cshtml"
                                                                  Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    <!-- /ko -->\r\n                </td>\r\n");

            
            #line 91 "..\..\Views\Subscriber\List.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td>&nbsp;</td>\r\n");

            
            #line 95 "..\..\Views\Subscriber\List.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 96 "..\..\Views\Subscriber\List.cshtml"
             foreach (var column in visibleColumns)
            {
                
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Subscriber\List.cshtml"
           Write(Html.Partial(column.CellView, column));

            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Subscriber\List.cshtml"
                                                      
            }

            
            #line default
            #line hidden
WriteLiteral("            <td>\r\n");

            
            #line 101 "..\..\Views\Subscriber\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\Subscriber\List.cshtml"
                 if (gridViewModel.CanDeleteItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <!-- ko if: !isActive() && !deletingIsDisabled() -->\r\n");

WriteLiteral("                    <a");

WriteLiteral(" class=\"bcms-icn-delete\"");

WriteLiteral(" data-bind=\"click: onDelete\"");

WriteLiteral(">");

            
            #line 104 "..\..\Views\Subscriber\List.cshtml"
                                                                      Write(RootGlobalization.Button_Delete);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                    <!-- /ko -->\r\n");

            
            #line 106 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 107 "..\..\Views\Subscriber\List.cshtml"
                 if (gridViewModel.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <!-- ko if: isActive() -->\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"click: onSave\"");

WriteLiteral(">");

            
            #line 110 "..\..\Views\Subscriber\List.cshtml"
                                                                     Write(gridViewModel.SaveButtonTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-btn-links-small\"");

WriteLiteral(" data-bind=\"click: onCancelEdit\"");

WriteLiteral(">");

            
            #line 111 "..\..\Views\Subscriber\List.cshtml"
                                                                                 Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    <!-- /ko -->\r\n");

            
            #line 113 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 114 "..\..\Views\Subscriber\List.cshtml"
                 if (!gridViewModel.CanDeleteItems && !gridViewModel.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("&nbsp;\r\n");

            
            #line 117 "..\..\Views\Subscriber\List.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <!-- /ko -->\r\n        </tr>\r\n        <!-- /ko --" +
">\r\n        <!-- ko if: items().length == 0 -->\r\n        <tr>\r\n            <td");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 5557), Tuple.Create("\"", 5593)
            
            #line 125 "..\..\Views\Subscriber\List.cshtml"
, Tuple.Create(Tuple.Create("", 5567), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount + 2
            
            #line default
            #line hidden
, 5567), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"bcms-table-no-data\"");

WriteLiteral(">");

            
            #line 125 "..\..\Views\Subscriber\List.cshtml"
                                                                                 Write(RootGlobalization.Grid_NoDataAvailable_Message);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n        </tr>\r\n        <!-- /ko -->\r\n        </tbody>\r\n    </table>" +
"\r\n\r\n");

            
            #line 131 "..\..\Views\Subscriber\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\Subscriber\List.cshtml"
     if (gridViewModel.AddHiddenFields)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- ko foreach: items -->\r\n");

            
            #line 134 "..\..\Views\Subscriber\List.cshtml"
        foreach (var column in gridViewModel.Columns)
        {
            if (!string.IsNullOrWhiteSpace(column.HiddenFieldName))
            {

            
            #line default
            #line hidden
WriteLiteral("                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" data-bind=\"valueBinder: ");

            
            #line 138 "..\..\Views\Subscriber\List.cshtml"
                                                                          Write(column.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("\r\n                   , attr {name hiddenfieldname(\'");

            
            #line 139 "..\..\Views\Subscriber\List.cshtml"
                                             Write(column.HiddenFieldName);

            
            #line default
            #line hidden
WriteLiteral("\', $index()) }\"");

WriteLiteral(">\r\n");

            
            #line 140 "..\..\Views\Subscriber\List.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("        <!-- /ko -->\r\n");

            
            #line 143 "..\..\Views\Subscriber\List.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
