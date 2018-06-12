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
    
    #line 16 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
    using Omnicx.API.SDK.Models.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 18 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Layout1/ReturnRequest.cshtml")]
    public partial class _Views_Account_Layout1_ReturnRequest_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Commerce.ReturnModel>
    {
        public _Views_Account_Layout1_ReturnRequest_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
  
/*
    Name: Return Request
    Purpose: Return Request Detail View
    Structure: /Views/Account/Layout1/ReturnRequest.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_Layout.cshtml.cshtml   (For base Structure)
        b-/Views/Account/Layout1/_MobileSideNav.cshtml  (Navigatiopn For Mobile)

    Contained In (Where we Use this View):
        a-/Views/Shared/Layout1/_HeaderLayout.cshtml        (Link in Top Header Bar)
        b-/Views/Shared/Layout1/_MobileHeaderLayout.cshtml  (Link in Mobile Header)
        c-/Views/Account/Layout1/ReturnHistory.cshtml       (Link for detail view)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 23 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
  
    ViewBag.Title = "Return Request";
    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";
    var userRole = SessionContext.CurrentUserRole;


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<section");

WriteLiteral(" ng-controller=\"accountCtrl as am\"");

WriteLiteral(" ng-init=\"selectedQty=0\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                           Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n                <li>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1459), Tuple.Create("\"", 1504)
            
            #line 38 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
, Tuple.Create(Tuple.Create("", 1466), Tuple.Create<System.Object, System.Int32>(Url.Action("OrderHistory", "Account")
            
            #line default
            #line hidden
, 1466), false)
);

WriteLiteral(">");

            
            #line 38 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                Write(LT("MyAccount.Links.MyOrders", "My orders"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1601), Tuple.Create("\"", 1665)
            
            #line 40 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
, Tuple.Create(Tuple.Create("", 1608), Tuple.Create<System.Object, System.Int32>(Url.Action("OrderDetail", "Account", new {id=Model.Id })
            
            #line default
            #line hidden
, 1608), false)
);

WriteLiteral(">");

            
            #line 40 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                   Write(Model.OrderNumber);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 42 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
               Write(LT("MyAccount.Text.Return Request", "Return Request"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n            <div ng-cloak");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" ng-show=\"am.success\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"fa fa-check\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                ");

            
            #line 51 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
           Write(LT("Return.Message.ReturnRequestProcessed", "Your return request has been processed"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"am.readyToReturn\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                ");

            
            #line 55 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
           Write(LT("Return.Message.SelectQty", "Please select quantity"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"basket-h1\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                             Write(Model.OrderNumber);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n            <p");

WriteLiteral(" class=\"text-muted basket-text\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                         Write(string.Format(LT("MyAccount.Text.OrderInformation", "Order {0} was placed on {1} and is currently {2}"), Model.OrderNumber, Model.OrderDate, ""));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <p");

WriteLiteral(" class=\"text-muted basket-text\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                         Write(LT("MyAccount.Text.FeelFree", "If you have any questions, please feel free to "));

            
            #line default
            #line hidden
WriteLiteral("<a");

WriteAttribute("href", Tuple.Create(" href=\"", 2845), Tuple.Create("\"", 2883)
            
            #line 61 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 2852), Tuple.Create<System.Object, System.Int32>(Url.Action("Contact", "pages")
            
            #line default
            #line hidden
, 2852), false)
);

WriteLiteral(">");

            
            #line 61 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                                                                                                    Write(LT("MyAccount.Text.ContactUs", "Contact Us"));

            
            #line default
            #line hidden
WriteLiteral(",</a> ");

            
            #line 61 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                                                                                                                                                       Write(LT("MyAccount.Text.Support", " our customer service center is working for you 24/7 ."));

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-xs-12 margin-bottom-lg visible-xs\"");

WriteLiteral(" id=\"exTab1\"");

WriteLiteral(">\r\n");

WriteLiteral("           ");

            
            #line 66 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
      Write(Html.Partial("~/Views/Account/Layout1/_MobileSideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4 col-xs-12 hidden-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 69 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
       Write(Html.Partial("~/Views/Account/Layout1/_SideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <ul>\r\n                    <li>\r\n                        <h4><s" +
"pan>");

            
            #line 75 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                             Write(LT("MyAccount.Text.OrderNumber", "Order Number"));

            
            #line default
            #line hidden
WriteLiteral("</span> ");

            
            #line 75 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                      Write(Model.OrderNumber);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                        <h5><span> ");

            
            #line 76 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                              Write(LT("MyAccount.Text.OrderDate", "Order Date"));

            
            #line default
            #line hidden
WriteLiteral("</span> ");

            
            #line 76 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                   Write(Model.OrderDate);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                        <h5><span>");

            
            #line 77 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                             Write(LT("MyAccount.Text.OrderStatus", "Order Status"));

            
            #line default
            #line hidden
WriteLiteral("</span> ");

            
            #line 77 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                      Write(Model.StatusLabel);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n    " +
"        <h3");

WriteLiteral(" class=\"panel-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                      Write(LT("MyAccount.Text.ProductOrdered", "Product Ordered"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <div");

WriteLiteral(" class=\"box no-padding col-sm-12 col-xs-12 no-border-bottom\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-8 no-padding\"");

WriteLiteral(" id=\"customer-order\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table no-margin-bottom basket-table\"");

WriteLiteral(">\r\n                                    <thead>\r\n                                 " +
"       <tr>\r\n                                            <th>");

            
            #line 90 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                           Write(LT("MyAccount.Text.Product", "Product"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                            <th>");

            
            #line 91 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                           Write(LT("MyAccount.Text.Qty", "Quantity"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                            <th>");

            
            #line 92 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                           Write(LT("MyAccount.Text.Price", "Unit price"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                            <th");

WriteLiteral(" class=\"col-lg-3\"");

WriteLiteral(">");

            
            #line 93 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                            Write(LT("MyAccount.Text.AvailableReturn", "Qty Available to Return"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                            <th>");

            
            #line 94 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                           Write(LT("MyAccount.Text.RetrunQty", "Return Qty"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                            <th>");

            
            #line 95 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                           Write(LT("MyAccount.Text.LineTotal", "Line Total"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        </tr>\r\n                           " +
"         </thead>\r\n                                    <tbody");

WriteLiteral(" id=\"cart\"");

WriteLiteral(">\r\n");

            
            #line 99 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 99 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                         foreach (var item in @Model.LineItems)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <tr>\r\n                               " +
"                 <td>\r\n                                                    <a");

WriteAttribute("ng-href", Tuple.Create(" ng-href=\"", 5587), Tuple.Create("\"", 5608)
, Tuple.Create(Tuple.Create("", 5597), Tuple.Create("/", 5597), true)
            
            #line 103 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
, Tuple.Create(Tuple.Create("", 5598), Tuple.Create<System.Object, System.Int32>(item.Slug
            
            #line default
            #line hidden
, 5598), false)
);

WriteLiteral(">");

            
            #line 103 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                        Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                                                </td>\r\n                    " +
"                            <td>");

            
            #line 105 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                               Write(item.ShippedQty);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                                <td>");

            
            #line 106 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                               Write(item.Price.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                                <td>");

            
            #line 107 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                               Write(item.AvailableQty);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                                <td>\r\n                    " +
"                                <span");

WriteAttribute("ng-if", Tuple.Create(" ng-if=\"", 6032), Tuple.Create("\"", 6061)
            
            #line 109 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
, Tuple.Create(Tuple.Create("", 6040), Tuple.Create<System.Object, System.Int32>(item.AvailableQty
            
            #line default
            #line hidden
, 6040), false)
, Tuple.Create(Tuple.Create("", 6058), Tuple.Create("<=0", 6058), true)
);

WriteLiteral(">");

            
            #line 109 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                   Write(item.AvailableQty);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                                    <select");

WriteAttribute("ng-if", Tuple.Create(" ng-if=\"", 6149), Tuple.Create("\"", 6177)
            
            #line 110 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
, Tuple.Create(Tuple.Create("", 6157), Tuple.Create<System.Object, System.Int32>(item.AvailableQty
            
            #line default
            #line hidden
, 6157), false)
, Tuple.Create(Tuple.Create("", 6175), Tuple.Create(">0", 6175), true)
);

WriteLiteral(" ng-model=\"selectedQty\"");

WriteAttribute("ng-change", Tuple.Create(" ng-change=\"", 6201), Tuple.Create("\"", 6260)
, Tuple.Create(Tuple.Create("", 6213), Tuple.Create("am.returnProduct(\'", 6213), true)
            
            #line 110 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                             , Tuple.Create(Tuple.Create("", 6231), Tuple.Create<System.Object, System.Int32>(item.ProductId
            
            #line default
            #line hidden
, 6231), false)
, Tuple.Create(Tuple.Create("", 6246), Tuple.Create("\',selectedQty)", 6246), true)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                                                        <option");

WriteLiteral(" value=\"{{$index}}\"");

WriteAttribute("ng-repeat", Tuple.Create(" ng-repeat=\"", 6367), Tuple.Create("\"", 6421)
, Tuple.Create(Tuple.Create("", 6379), Tuple.Create("item", 6379), true)
, Tuple.Create(Tuple.Create(" ", 6383), Tuple.Create("in", 6384), true)
, Tuple.Create(Tuple.Create(" ", 6386), Tuple.Create("am.setQuantity(", 6387), true)
            
            #line 111 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                     , Tuple.Create(Tuple.Create("", 6402), Tuple.Create<System.Object, System.Int32>(item.AvailableQty
            
            #line default
            #line hidden
, 6402), false)
, Tuple.Create(Tuple.Create("", 6420), Tuple.Create(")", 6420), true)
);

WriteLiteral(" ng-bind=\"$index\"");

WriteLiteral("></option>\r\n                                                    </select>\r\n      " +
"                                          </td>\r\n                               " +
"                 <td>");

            
            #line 114 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                               Write(Model.CurrencySymbol);

            
            #line default
            #line hidden
            
            #line 114 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                    Write(item.TotalPrice.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                            </tr>\r\n");

            
            #line 116 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </tbody>\r\n                                </t" +
"able>\r\n                            </div>\r\n                        </div>\r\n\r\n   " +
"                     <div");

WriteLiteral(" class=\"col-md-4 no-padding-right\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"summery-border\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"summery-box\"");

WriteLiteral(" id=\"order-summary\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral(">\r\n                                        <h3><i");

WriteLiteral(" class=\"fa fa-shopping-basket\"");

WriteLiteral("></i> ");

            
            #line 126 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                             Write(LT("Checkout.Label.OrderSummary", "Order Summary"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                    </div>\r\n                              " +
"      <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n                                        <table");

WriteLiteral(" class=\"table no-margin-top\"");

WriteLiteral(">\r\n                                            <tbody>\r\n                         " +
"                       <tr>\r\n                                                   " +
" <td>");

            
            #line 132 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                   Write(LT("MyAccount.Text.OrderSubtotal", "OrderSubtotal"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                                    <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 133 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                      Write(Model.SubTotal.Formatted.WithoutTax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                                </tr>\r\n                   " +
"                             <tr>\r\n                                             " +
"       <td>");

            
            #line 136 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                   Write(LT("Myaccount.Text.ShippingCharge", "Shipping and handling"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                                    <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 137 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                      Write(Model.ShippingCharge.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                                </tr>\r\n                   " +
"                             <tr>\r\n                                             " +
"       <td>");

            
            #line 140 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                   Write(LT("MyAccount.Text.Tax", "Tax"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                                    <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 141 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                      Write(Model.GrandTotal.Formatted.Tax);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                                </tr>\r\n                   " +
"                             <tr");

WriteLiteral(" class=\"total\"");

WriteLiteral(">\r\n                                                    <td>");

            
            #line 144 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                   Write(LT("MyAccount.Text.Amount", "Total"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                                    <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 145 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                      Write(Model.GrandTotal.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral(@"</th>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <!-- /.col-md-3 -->
                        </div>
                        ");

WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-6 col-xs-12 padding-sm\"");

WriteLiteral(">\r\n                    <form");

WriteLiteral(" ng-submit=\"am.createReturn(am.model);\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                            <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" ng-show=\"am.errorMessage\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" ng-show=\"reasonForReturnId\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span> ");

            
            #line 184 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                  Write(LT("MyAccount.Text.ReasonForReturn", "Select reason for return"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </div>\r\n\r\n                              " +
"  <div");

WriteLiteral(" ng-show=\"requiredActionId\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span> ");

            
            #line 188 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                  Write(LT("MyAccount.Text.RequiredAction", "Select required action"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </div>\r\n                                " +
"<div");

WriteLiteral(" ng-show=\"comment\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i><span> ");

            
            #line 191 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                  Write(LT("MyAccount.Text.Comment", "Enter comment"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </div>\r\n                            </di" +
"v>\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 195 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                           Write(LT("MyAccount.Text.ReasonForReturn", "Reason For Return"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                <select");

WriteLiteral(" ng-model=\"am.model.reasonForReturnId\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                                    <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">Select</option>\r\n                                    <option");

WriteLiteral(" value=\"Cusomer Right To Cancel\"");

WriteLiteral(">Cusomer Right To Cancel</option>\r\n                                    <option");

WriteLiteral(" value=\"Damaged\"");

WriteLiteral(">Damaged</option>\r\n                                    <option");

WriteLiteral(" value=\"Faulty Product\"");

WriteLiteral(">Faulty Product</option>\r\n                                    <option");

WriteLiteral(" value=\"Incorrect Item Received\"");

WriteLiteral(">Incorrect Item Received</option>\r\n                                    <option");

WriteLiteral(" value=\"Try It First Return\"");

WriteLiteral(">Try It First Return</option>\r\n                                </select>\r\n       " +
"                     </div>\r\n                        </div>\r\n                   " +
"     <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 210 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                           Write(LT("MyAccount.Text.RequiredAction", "Required Action"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                <select");

WriteLiteral(" ng-model=\"am.model.requiredActionId\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                                    <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">Select</option>\r\n                                    <option");

WriteLiteral(" value=\"Refund\"");

WriteLiteral(">");

            
            #line 215 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                      Write(LT("Return.Action.Refund", "Refund"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                    <option");

WriteLiteral(" value=\"Replacement\"");

WriteLiteral(">");

            
            #line 216 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                           Write(LT("Return.Action.Replacement", "Replacement"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                </select>\r\n                           " +
" </div>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 222 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                           Write(LT("MyAccount.Text.Comment", "Comment"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                <textarea");

WriteLiteral(" ng-model=\"am.model.comment\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></textarea>\r\n                            </div>\r\n                        </div>\r" +
"\n                        <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                                <button");

WriteLiteral(" class=\"animate btn-primary\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 230 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                             Write(LT("MyAccount.Button.CreateReturn", "Create Return"));

            
            #line default
            #line hidden
WriteLiteral("  </button>\r\n                            </div>\r\n                            <div" +
"");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"animate btn-default\"");

WriteAttribute("href", Tuple.Create(" href=\"", 14533), Tuple.Create("\"", 14578)
            
            #line 233 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
, Tuple.Create(Tuple.Create("", 14540), Tuple.Create<System.Object, System.Int32>(Url.Action("orderhistory", "account")
            
            #line default
            #line hidden
, 14540), false)
);

WriteLiteral(">");

            
            #line 233 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                                                                                        Write(LT("MyAccount.Button.Cancel", "Cancel"));

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n                            </div>\r\n                        </div>\r\n      " +
"              </form>\r\n                </div>\r\n            </div>\r\n        </div" +
">\r\n    </div>\r\n</section>\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var createReturnUrl = \'");

            
            #line 244 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                           Write(Html.BuildUrlFromExpression<AccountController>(c => c.CreateReturn(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        window.app.constant(\'accountConfig\', {\r\n            createReturnUrl: " +
"createReturnUrl\r\n        });\r\n        window.app.constant(\'model\', ");

            
            #line 248 "..\..\Views\Account\Layout1\ReturnRequest.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591