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
    
    #line 18 "..\..\Views\Account\Layout1\Wishlist.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Account\Layout1\Wishlist.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 22 "..\..\Views\Account\Layout1\Wishlist.cshtml"
    using Omnicx.API.SDK.Models.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 20 "..\..\Views\Account\Layout1\Wishlist.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Account\Layout1\Wishlist.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Layout1/Wishlist.cshtml")]
    public partial class _Views_Account_Layout1_Wishlist_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<List<Omnicx.API.SDK.Models.Catalog.ProductModel>>
    {
        public _Views_Account_Layout1_Wishlist_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\Layout1\Wishlist.cshtml"
  
/*
    Name: Wishlist
    Purpose: Show wishlist Items list of Logged In User 
    Structure: /Views/Account/Layout1/Wishlist.cshtml
    Contains (Partial Views Used): 
        a-/Views/Shared/Layout1/_Layout.cshtml.cshtml   (For base Structure)
        b-/Views/Account/Layout1/_MobileSideNav.cshtml  (Navigatiopn For Mobile)
        c-/Views/Account/Layout1/_SideNav.cshtml        (Navigation For Desktop and Big Screen)
        d-/Views/Search/Layout1/_ProductWidget.cshtml   (Item List Structure Widget)
        e-/Views/Product/Layout1/_QuickViewModal.cshtml (Product Quick view Modal)

    Contained In (Where we Use this View):
     a-/Views/Account/Layout1/_MobileSideNav.cshtml  (Navigatiopn Link Mobile)
     b-/Views/Account/Layout1/_SideNav.cshtml        (Navigation Link Desktop and Big Screen)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 25 "..\..\Views\Account\Layout1\Wishlist.cshtml"
  
    ViewBag.Title = "Wishlist";
    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";
    var userRole = SessionContext.CurrentUserRole;


            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n            <li>\r\n                <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                       Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li>");

            
            #line 37 "..\..\Views\Account\Layout1\Wishlist.cshtml"
           Write(LT("MyAccount.Title.Wishlist", "My Wishlist"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <h3");

WriteLiteral(" class=\"panel-h2 hidden-xs\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                                  Write(LT("MyAccount.Text.Name", "My Wishlist"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-controller=\"productCtrl as pm\"");

WriteLiteral(" ng-init=\"fromWishList=true\"");

WriteLiteral(">    \r\n    <div");

WriteLiteral(" class=\"col-xs-12 margin-bottom-lg visible-xs\"");

WriteLiteral(" id=\"exTab1\"");

WriteLiteral(">\r\n       \r\n");

WriteLiteral("        ");

            
            #line 49 "..\..\Views\Account\Layout1\Wishlist.cshtml"
   Write(Html.Partial("~/Views/Account/Layout1/_MobileSideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-3 col-sm-4 col-xs-12 hidden-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 52 "..\..\Views\Account\Layout1\Wishlist.cshtml"
   Write(Html.Partial("~/Views/Account/Layout1/_SideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"products col-md-9 col-sm-8 col-xs-12\"");

WriteLiteral(" ng-init=\"pm.productModel=pm.model;pm.forDelete=true;pm.isWhislist=true;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 pull-right no-padding\"");

WriteLiteral(" ng-show=\"pm.productModel!=null && pm.productModel.length>0\"");

WriteLiteral(" ng-cloak>\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control control--checkbox ng-binding\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"isChecked\"");

WriteLiteral(" name=\"basketToWishList\"");

WriteLiteral(" class=\"ng-valid ng-dirty ng-valid-parse ng-touched ng-empty\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#myModal\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"basketToWishList\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                                             Write(LT("MyAccount.Label.MoveInBasket", "Move all in Basket"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                </label>\r\n            </div>\r\n        </div>\r\n        <d" +
"iv");

WriteLiteral(" class=\"col-md-4 col-sm-6 col-xs-6 resultContainerRelated\"");

WriteLiteral(" ng-repeat=\"product in pm.productModel track by $index\"");

WriteLiteral(" ng-cloak>\r\n");

WriteLiteral("            ");

            
            #line 66 "..\..\Views\Account\Layout1\Wishlist.cshtml"
       Write(Html.Partial("~/Views/Search/Layout1/_ProductWidget.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 69 "..\..\Views\Account\Layout1\Wishlist.cshtml"
   Write(Html.Partial("~/Views/Product/Layout1/_QuickViewModal.cshtml", new Omnicx.API.SDK.Models.Catalog.ProductDetailModel { }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 71 "..\..\Views\Account\Layout1\Wishlist.cshtml"
        
            
            #line default
            #line hidden
            
            #line 71 "..\..\Views\Account\Layout1\Wishlist.cshtml"
         if (Model.Count <= 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-12 nodata-customer\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral("></i>\r\n                    <h1>");

            
            #line 76 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                   Write(LT("MyAccount.Basket.NoWishlist", "No Wishlist Available"));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n");

            
            #line 79 "..\..\Views\Account\Layout1\Wishlist.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    \r\n");

            
            #line 83 "..\..\Views\Account\Layout1\Wishlist.cshtml"
   
            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\Account\Layout1\Wishlist.cshtml"
     /*Alert modal for moving product to basket*/
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"myModal\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-dialog modal-sm\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" ng-class=\"isChecked=false;\"");

WriteLiteral(">&times;</button>\r\n                    <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                                       Write(LT("MyAccount.Basket.MovingToBasket", "Moving all products in basket"));

            
            #line default
            #line hidden
WriteLiteral("</h4>                    \r\n                </div>\r\n                <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"text-black\"");

WriteLiteral(">");

            
            #line 94 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                                             Write(LT("MyAccount.Basket.ConfirmationMoveToBasket", "Are you sure want to move all the products in Basket?"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n               " +
" </div>\r\n                <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success pull-right\"");

WriteLiteral(" ng-click=\"pm.addMultipleToBasket(pm.productModel)\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Ok</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </d" +
"iv>\r\n");

            
            #line 104 "..\..\Views\Account\Layout1\Wishlist.cshtml"
    
            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Account\Layout1\Wishlist.cshtml"
      /*End of moving product modal to basket*/
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<!-- *** RIGHT COLUMN END *** -->\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var searchDetailProductUrl = \'");

            
            #line 109 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                                  Write(Html.BuildUrlFromExpression<ProductController>(c => c.ProductDetails("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var productUrl = \'");

            
            #line 110 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                      Write(Html.BuildUrlFromExpression<ProductController>(c => c.ProductDetails("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addToWishlistUrl = \'");

            
            #line 111 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                            Write(Html.BuildUrlFromExpression<AccountController>(c => c.AddProductToWishlist(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var wishlistToBasket = \'");

            
            #line 112 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                            Write(Html.BuildUrlFromExpression<BasketController>(c => c.WishlistToBasket(null)));

            
            #line default
            #line hidden
WriteLiteral(@"';
        window.app.constant('productConfig',{
            searchDetailProductUrl : searchDetailProductUrl,
            productUrl : productUrl,
            addToWishlistUrl : addToWishlistUrl,
            wishlistToBasket : wishlistToBasket
        });
        window.app.constant('model', ");

            
            #line 119 "..\..\Views\Account\Layout1\Wishlist.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
