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
    
    #line 12 "..\..\Views\Shared\Layout1\_Login.cshtml"
    using Omnicx.API.SDK.Models.Commerce;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 13 "..\..\Views\Shared\Layout1\_Login.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layout1/_Login.cshtml")]
    public partial class _Views_Shared_Layout1__Login_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<LoginViewModel>
    {
        public _Views_Shared_Layout1__Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\Layout1\_Login.cshtml"
  
/*
    Name: Login Modal
    Purpose: login Modal
    Structure: /Views/Shared/Layout1/_Login.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_Alerts.cshtml

    Contained In (Where we Use this View):
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Shared\Layout1\_Login.cshtml"
  
    var loginForm = Html.Angular().ModelFor("gm.model");

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"modal fade modal-absolute\"");

WriteLiteral(" id=\"login-modal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"Login\"");

WriteLiteral(" aria-hidden=\"false\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-sm\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"Login\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Shared\Layout1\_Login.cshtml"
                                               Write(LT("Header.Text.UserLogin", "User Login"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</button>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" ng-submit=\"gm.globalLogin(gm.model)\"");

WriteLiteral(" novalidate>\r\n                    <div");

WriteLiteral(" ng-show=\"gm.errorMessage != null && global_login\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Views\Shared\Layout1\_Login.cshtml"
                   Write(Html.Partial("~/Views/Shared/Layout1/_Alerts.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 32 "..\..\Views\Shared\Layout1\_Login.cshtml"
                   Write(loginForm.FormGroupFor(x => x.Username));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Views\Shared\Layout1\_Login.cshtml"
                   Write(loginForm.FormGroupFor(x => x.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <p");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sign-in\"");

WriteLiteral("></i>");

            
            #line 38 "..\..\Views\Shared\Layout1\_Login.cshtml"
                                                                                              Write(LT("Global.Buttons.Login", "Login"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                    </p>\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding text-center\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1891), Tuple.Create("\"", 1938)
            
            #line 41 "..\..\Views\Shared\Layout1\_Login.cshtml"
, Tuple.Create(Tuple.Create("", 1898), Tuple.Create<System.Object, System.Int32>(Url.Action("forgotpassword", "account")
            
            #line default
            #line hidden
, 1898), false)
);

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">Forgot Password</a>\r\n                    </div>\r\n                </form>\r\n      " +
"          <p");

WriteLiteral(" class=\"text-center text-muted\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Shared\Layout1\_Login.cshtml"
                                             Write(LT("Footer.Text.NoAccount", "Not registered yet?"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <p");

WriteLiteral(" class=\"text-center text-muted\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#register-modal\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" ng-click=\"gm.model={}\"");

WriteLiteral(" class=\"text-black\"");

WriteLiteral("><strong>");

            
            #line 45 "..\..\Views\Shared\Layout1\_Login.cshtml"
                                                                                                                                                                                                     Write(LT("Footer.Text.RegisterNow", "Register now"));

            
            #line default
            #line hidden
WriteLiteral("</strong></a>!");

            
            #line 45 "..\..\Views\Shared\Layout1\_Login.cshtml"
                                                                                                                                                                                                                                                                 Write(LT("MyAccount.Text.EasyRegister", " It is easy and done in 1 minute and gives you access to special discounts and much more"));

            
            #line default
            #line hidden
WriteLiteral("!</p>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
