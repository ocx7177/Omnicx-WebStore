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
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    
    #line 16 "..\..\Views\Account\Layout1\MyActivity.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Account\Layout1\MyActivity.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 18 "..\..\Views\Account\Layout1\MyActivity.cshtml"
    using Omnicx.API.SDK.Models;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 19 "..\..\Views\Account\Layout1\MyActivity.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Account\Layout1\MyActivity.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Layout1/MyActivity.cshtml")]
    public partial class _Views_Account_Layout1_MyActivity_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<List<Omnicx.API.SDK.Models.Commerce.Activity>>
    {
        public _Views_Account_Layout1_MyActivity_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\Layout1\MyActivity.cshtml"
  
/*
    Name: My Activity
    Purpose: Show All the activitis of logged in user 
    Structure: /Views/Account/Layout1/MyActivity.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_Layout.cshtml.cshtml   (For base Structure)
        b-/Views/Account/Layout1/_MobileSideNav.cshtml  (Navigatiopn For Mobile)
        c-/Views/Account/Layout1/_SideNav.cshtml        (Navigation For Desktop and Big Screen)

    Contained In (Where we Use this View):
     a-/Views/Account/Layout1/_MobileSideNav.cshtml  (Navigatiopn Link Mobile)
     b-/Views/Account/Layout1/_SideNav.cshtml        (Navigation Link Desktop and Big Screen)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 24 "..\..\Views\Account\Layout1\MyActivity.cshtml"
  
    var customerAccountForm = Html.Angular().ModelFor("am.model");
    ViewBag.Title = "MyActivity";
    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";


            
            #line default
            #line hidden
WriteLiteral("\r\n<section");

WriteLiteral(" ng-controller=\"accountCtrl as am\"");

WriteLiteral(" ng-init=\"search.currentPage =1; am.getMyActivity(search)\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                           Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n                <li>");

            
            #line 37 "..\..\Views\Account\Layout1\MyActivity.cshtml"
               Write(LT("MyAccount.Text.Name", "My Activity"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"panel-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                                      Write(LT("MyAccount.Text.Name", "My Activity"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-xs-12 margin-bottom-lg visible-xs\"");

WriteLiteral(" id=\"exTab1\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 49 "..\..\Views\Account\Layout1\MyActivity.cshtml"
       Write(Html.Partial("~/Views/Account/Layout1/_MobileSideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4 col-xs-12 hidden-xs\"");

WriteLiteral(">            \r\n");

WriteLiteral("            ");

            
            #line 52 "..\..\Views\Account\Layout1\MyActivity.cshtml"
       Write(Html.Partial("~/Views/Account/Layout1/_SideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <h4>\r\n");

WriteLiteral("                        ");

            
            #line 59 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                   Write(LT("MyAccount.Text.Total", "Total"));

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" ng-bind=\"am.activityList.totalRecord\"");

WriteLiteral("></span> ");

            
            #line 59 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                                                                                                            Write(LT("MyAccount.Text.Activities", "Activities"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <a>\r\n                            <i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral(" ng-click=\"am.deleteMyActivity()\"");

WriteLiteral("></i>\r\n                        </a>\r\n                    </h4>\r\n                <" +
"/div>\r\n            </div>\r\n            ");

WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"panel panel-default sidebar-menu\"");

WriteLiteral(" ng-repeat=\"item in am.activityList.sessions | orderBy : \'-firstActivityCreated\' " +
"\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"activity-panel panel-heading-top col-sm-12 no-padding\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                                <h4");

WriteLiteral(" class=\"panel-title panel-h4 collapsed\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#{{item.$$hashKey.split(\':\')[1]}}\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"i=!i\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"fa fa-caret-right\"");

WriteLiteral(" ng-show=\"i\"");

WriteLiteral("></i><i");

WriteLiteral(" class=\"fa fa-caret-down\"");

WriteLiteral(" ng-show=\"!i\"");

WriteLiteral("></i> <span");

WriteLiteral(" ng-bind=\"item.firstActivityCreated | date:yyyy-dd-mm\"");

WriteLiteral("></span> (<span>");

            
            #line 81 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                                                                                                                                                                                                         Write(LT("MyAccount.Text.Total", "Total"));

            
            #line default
            #line hidden
WriteLiteral(" </span> <strong");

WriteLiteral(" ng-bind=\"item.activityCount\"");

WriteLiteral("></strong> <span>");

            
            #line 81 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                                                                                                                                                                                                                                                                                                           Write(LT("MyAccount.Text.Total", "Activity"));

            
            #line default
            #line hidden
WriteLiteral("</span>)\r\n                                    </a>\r\n                             " +
"   </h4>\r\n                            </div>\r\n                        </div>\r\n  " +
"                      <div");

WriteLiteral(" class=\"panel-body panel-padding-top no-padding collapse\"");

WriteLiteral(" id=\"{{item.$$hashKey.split(\':\')[1]}}\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"activity-container\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"activity-data\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" ng-repeat=\"item1 in item.activities | orderBy: \'-created\'\"");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding activity timeline-bottom-margin-{{item1.en" +
"tityType}}\"");

WriteLiteral(">\r\n                                            <span");

WriteLiteral(" class=\"label-{{item1.entityType}}\"");

WriteLiteral(" ng-bind=\"item1.entityType\"");

WriteLiteral("></span>\r\n                                            <span");

WriteLiteral(" ng-bind=\"item1.title\"");

WriteLiteral("></span>\r\n                                            <span");

WriteLiteral(" class=\"text-right pull-right activityTime\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-clock-o\"");

WriteLiteral(@"></i> {{item1.created | ocxTime}}</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                ");

WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n<script>\r\n        var saveCustomerUrl = \'");

            
            #line 126 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                           Write(Html.BuildUrlFromExpression<AccountController>(c => c.SaveCustomerDetail(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var custGridUrl = \'");

            
            #line 127 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                       Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetCustomerAddress()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var saveCustAddrUrl = \'");

            
            #line 128 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                           Write(Html.BuildUrlFromExpression<AccountController>(c => c.SaveCustomerAddress(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var getMyActivity = \'");

            
            #line 129 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                         Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetMyActivity(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var deleteMyActivity = \'");

            
            #line 130 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                            Write(Html.BuildUrlFromExpression<AccountController>(c => c.DeleteMyActivity()));

            
            #line default
            #line hidden
WriteLiteral(@"';

        window.app.constant('accountConfig', {
            saveCustAddrUrl: saveCustAddrUrl,
            custGridUrl: custGridUrl,
            saveCustomerUrl : saveCustomerUrl,
            getMyActivity: getMyActivity,
            deleteMyActivity: deleteMyActivity
        });
        window.app.constant('model', ");

            
            #line 139 "..\..\Views\Account\Layout1\MyActivity.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n</script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
