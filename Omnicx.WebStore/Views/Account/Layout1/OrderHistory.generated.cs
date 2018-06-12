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
    
    #line 16 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
    using Omnicx.API.SDK.Models;
    
    #line default
    #line hidden
    
    #line 22 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
    using Omnicx.API.SDK.Models.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 20 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Layout1/OrderHistory.cshtml")]
    public partial class _Views_Account_Layout1_OrderHistory_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Commerce.OrderModel>
    {
        public _Views_Account_Layout1_OrderHistory_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
  
/*
    Name: Order List
    Purpose: Show All Orders listing
    Structure: /Views/Account/Layout1/OrderHistory.cshtml
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

            
            #line 24 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
  
    ViewBag.Title = "Orders";
    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";
    var userRole = SessionContext.CurrentUserRole;


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n            <li>\r\n                <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                       Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li>");

            
            #line 37 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
           Write(LT("MyAccount.Links.MyOrders", "My orders"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <h3");

WriteLiteral(" class=\"panel-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                                  Write(LT("MyAccount.Text.UpdateDetails", "My Orders"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-xs-12 margin-bottom-lg visible-xs\"");

WriteLiteral(" id=\"exTab1\"");

WriteLiteral(">\r\n        \r\n");

WriteLiteral("        ");

            
            #line 49 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
   Write(Html.Partial("~/Views/Account/Layout1/_MobileSideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-3 col-sm-4 col-xs-12 hidden-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 52 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
   Write(Html.Partial("~/Views/Account/Layout1/_SideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-md-9 col-sm-8 col-xs-12\"");

WriteLiteral(" id=\"customer-orders\"");

WriteLiteral(" ng-controller=\"accountCtrl as am\"");

WriteLiteral(" ng-init=\"am.getOrderHistory()\"");

WriteLiteral(">    \r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger orderError\"");

WriteLiteral(" ng-show=\"am.orderError\"");

WriteLiteral(">\r\n                        <strong>");

            
            #line 60 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                           Write(LT("YourBag.Message.basketMessage", "There is an error adding some stock(s) - "));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" ng-bind=\"am.orderError\"");

WriteLiteral("></span></strong>\r\n                    </div>\r\n                    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger orderUnavailable\"");

WriteLiteral(" ng-show=\"am.orderUnavailable\"");

WriteLiteral(">\r\n                        <strong>");

            
            #line 63 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                           Write(LT("YourBag.Message.stockUnavailable", "Stock Code(s) not available."));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                    </div>\r\n                    <div ng-cloak");

WriteLiteral(" class=\"alert alert-success orderSuccess\"");

WriteLiteral(" ng-show=\"am.orderSuccess\"");

WriteLiteral(">\r\n                        <strong>");

            
            #line 66 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                           Write(LT("YourBag.Message.OrderSuccess", "Item(s) added successfully"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                    </div>\r\n                </p>\r\n            </div>\r\n" +
"        </div>    \r\n        <div");

WriteLiteral(" class=\"box no-padding col-sm-12 col-xs-12 no-border-bottom\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"table-responsive max-history\"");

WriteLiteral(" ng-show=\"am.ordersList.length!=0\"");

WriteLiteral(">\r\n                <table");

WriteLiteral(" class=\"table table-hover table-striped\"");

WriteLiteral(">\r\n                    <thead>\r\n                        <tr>\r\n                   " +
"         <th>");

            
            #line 76 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                           Write(LT("MyAccount.Text.OrderNumber", "Order #"));

            
            #line default
            #line hidden
WriteLiteral("</th>                            \r\n                            <th>");

            
            #line 77 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                           Write(LT("MyAccount.Text.Status", "Status"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th>");

            
            #line 78 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                           Write(LT("MyAccount.Text.OrderDate", "Order Date"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 79 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                                              Write(LT("MyAccount.Text.Amount", "Order Total"));

            
            #line default
            #line hidden
WriteLiteral("</th>                                                        \r\n                  " +
"          <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                                              Write(LT("MyAccount.Text.Status", "Action"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                                              Write(LT("MyAccount.Text.ReOrder", "Reorder"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n             " +
"       <tbody>\r\n                        <tr");

WriteLiteral(" ng-repeat=\"orders in am.ordersList\"");

WriteLiteral(">\r\n                            <th><span");

WriteLiteral(" ng-bind=\"orders.orderNo\"");

WriteLiteral("></span></th>                            \r\n                            <td><span");

WriteLiteral(" class=\"label label-{{orders.orderStatus}}\"");

WriteLiteral(" ng-bind=\"orders.orderStatus\"");

WriteLiteral("></span></td>\r\n                            <td><span");

WriteLiteral(" ng-bind=\"orders.orderDate | ocxDateTime\"");

WriteLiteral("></span></td>\r\n                            <td");

WriteLiteral(" align=\"right\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"orders.grandTotal.formatted.withTax\"");

WriteLiteral("></span></td>                                                     \r\n             " +
"               <td");

WriteLiteral(" align=\"right\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 4640), Tuple.Create("\"", 4682)
, Tuple.Create(Tuple.Create("", 4647), Tuple.Create<System.Object, System.Int32>(Href("~/Account/OrderDetail/{{orders.id}}")
, 4647), false)
);

WriteLiteral(" title=\"View Order\"");

WriteLiteral(" ><i");

WriteLiteral(" class=\"fa fa-eye color-black\"");

WriteLiteral("></i></a></td>\r\n                            <td");

WriteLiteral(" align=\"right\"");

WriteLiteral("><a");

WriteLiteral(" ng-click=\"am.reOrder(orders.id)\"");

WriteLiteral(" href=\"\"");

WriteLiteral(" title=\"Re-Order\"");

WriteLiteral(" class=\"animate-sm btn-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-cart no-margin-left\"");

WriteLiteral("></i>");

            
            #line 91 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                                                                                                                                                                                       Write(LT("MyAccount.Text.ReOrder", "Reorder"));

            
            #line default
            #line hidden
WriteLiteral("</a></td>  \r\n                        </tr>\r\n                    </tbody>\r\n       " +
"         </table>\r\n            </div>\r\n            <!-- /.table-responsive -->\r\n" +
"            <div");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" ng-show=\"am.ordersList.length==0\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-12 nodata-customer\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-shopping-cart\"");

WriteLiteral("></i>\r\n                    <h1>");

            
            #line 100 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                   Write(LT("MyAccount.Text.NoOrderHistoryAvailable", "No Order History Available"));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</" +
"div>\r\n\r\n<!-- *** RIGHT COLUMN END *** -->\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script>\r\n\r\n        var getOrderHistoryUrl = \'");

            
            #line 111 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                              Write(Html.BuildUrlFromExpression<AccountController>(c => c.Getorders()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var reOrderUrl = \'");

            
            #line 112 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                      Write(Html.BuildUrlFromExpression<BasketController>(c => c.ReOrder("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        window.app.constant(\'accountConfig\', {\r\n            getOrderHistoryUr" +
"l : getOrderHistoryUrl,\r\n            reOrderUrl : reOrderUrl\r\n        });\r\n     " +
"   window.app.constant(\'model\', ");

            
            #line 117 "..\..\Views\Account\Layout1\OrderHistory.cshtml"
                                Write(Html.Json(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
