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
    
    #line 20 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 25 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 24 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.API.SDK.Models.Catalog;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 22 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 23 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Layout1/_SearchResultProducts.cshtml")]
    public partial class _Views_Search_Layout1__SearchResultProducts_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Helpers.PaginatedResult<Omnicx.API.SDK.Models.Catalog.ProductModel>>
    {
        public _Views_Search_Layout1__SearchResultProducts_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
  
/*
    Name: Search Result
    Purpose: Show Product list after search Result
    Structure: /Views/Search/Layout1/_SearchResultProducts.cshtml
    Contains (Partial Views Used):
        a-/Views/Search/Layout1/_SearchFacetsMobile.cshtml
        b-/Views/Search/Layout1/_SearchFacets.cshtml
        c-/Views/Search/Layout1/_SearchTopBar.cshtml
        d-/Views/Search/Layout1/_NoResults.cshtml
        e-/Views/Search/Layout1/_ProductWidget.cshtml
        f-/Views/Search/Layout1/_ProductListWidget.cshtml
        g-/Views/Search/Layout1/_SearchBottomBar.cshtml
        h-/Views/Product/Layout1/_QuickViewModal.cshtml

    Contained In (Where we Use this View):
        a-/Views/Search/Layout1/Search.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n<section");

WriteLiteral(" ng-controller=\"productCtrl as pm\"");

WriteAttribute("ng-init", Tuple.Create(" ng-init=\'", 1169), Tuple.Create("\'", 1272)
, Tuple.Create(Tuple.Create("", 1179), Tuple.Create("pm.initProducts(", 1179), true)
            
            #line 30 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 1195), Tuple.Create<System.Object, System.Int32>(Html.Json(Model)
            
            #line default
            #line hidden
, 1195), false)
, Tuple.Create(Tuple.Create("", 1212), Tuple.Create(");getView=true;pm.getToWishlist(pm.productResponse.results);", 1212), true)
);

WriteLiteral(">\r\n    \r\n");

            
            #line 32 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /* Start WishList Validations */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-success wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlistsaved\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 34 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AddToWishlist", "Product added to wishlist"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlistexistserror\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 37 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AlreadyAddedToWishlist", "Product already added in wishlist"));

            
            #line default
            #line hidden
WriteLiteral("!</strong>\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlisterror\"");

WriteLiteral(">\r\n        User <strong>");

            
            #line 40 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                Write(LT("ProductDetail.Message.LoginRequired", "Login Required"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n");

            
            #line 42 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /*  End WishList Validations */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 44 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /* Start products container */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 visible-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       Write(Html.Partial("~/Views/Search/Layout1/_SearchFacetsMobile.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-3 hidden-xs\"");

WriteLiteral(">\r\n");

            
            #line 50 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
              
                /* Start left filter grid */
                var listClass = "col-sm-12 col-xs-12";
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 54 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
             if (Model.Results != null && Model.Results.Count != 0 && Model.SearchCriteria.AllowFacet)
            {
                listClass = "col-sm-9 col-xs-12";

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 58 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               Write(Html.Partial("~/Views/Search/Layout1/_SearchFacets.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 60 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 61 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /* End left filter grid */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2788), Tuple.Create("\"", 2806)
            
            #line 63 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 2796), Tuple.Create<System.Object, System.Int32>(listClass
            
            #line default
            #line hidden
, 2796), false)
);

WriteLiteral(">\r\n            ");

WriteLiteral("\r\n");

            
            #line 69 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
              
                if (Model.Images != null && Model.Images.Any())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 clearfix margin-bottom-lg no-padding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"carousel-example-generic\"");

WriteLiteral(" class=\"carousel slide omnicomponent component-slider\"");

WriteLiteral(" list-id=\"\"");

WriteLiteral(" list-type=\"\"");

WriteLiteral(" data-ride=\"carousel\"");

WriteLiteral(">\r\n                            <ol");

WriteLiteral(" class=\"carousel-indicators\"");

WriteLiteral(">\r\n\r\n");

            
            #line 76 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                 foreach (var img in Model.Images.Select((index) => new { index }))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li");

WriteLiteral(" data-target=\"#carousel-example-generic\"");

WriteLiteral(" data-slide-to=\"");

            
            #line 78 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                                                          Write(img.index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 3767), Tuple.Create("\"", 3802)
, Tuple.Create(Tuple.Create("", 3778), Tuple.Create("{active", 3778), true)
, Tuple.Create(Tuple.Create(" ", 3785), Tuple.Create(":", 3786), true)
            
            #line 78 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                              , Tuple.Create(Tuple.Create(" ", 3787), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 3788), false)
, Tuple.Create(Tuple.Create("", 3798), Tuple.Create("==0}", 3798), true)
);

WriteLiteral("></li>\r\n");

            
            #line 79 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ol>\r\n                            <div");

WriteLiteral(" class=\"carousel-inner\"");

WriteLiteral(">\r\n");

            
            #line 82 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                 foreach (var img in Model.Images.Select((obj, index) => new { index, obj }))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <div");

WriteLiteral(" class=\"item\"");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4138), Tuple.Create("\"", 4173)
, Tuple.Create(Tuple.Create("", 4149), Tuple.Create("{active", 4149), true)
, Tuple.Create(Tuple.Create(" ", 4156), Tuple.Create(":", 4157), true)
            
            #line 84 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create(" ", 4158), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 4159), false)
, Tuple.Create(Tuple.Create("", 4169), Tuple.Create("==0}", 4169), true)
);

WriteLiteral(">\r\n");

            
            #line 85 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                         if (img.obj.LinkType == LinkType.Href.GetHashCode().ToString())
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4372), Tuple.Create("\"", 4392)
            
            #line 87 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 4379), Tuple.Create<System.Object, System.Int32>(img.obj.Link
            
            #line default
            #line hidden
, 4379), false)
);

WriteLiteral(">\r\n                                                <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 4448), Tuple.Create("\"", 4469)
            
            #line 88 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 4457), Tuple.Create<System.Object, System.Int32>(img.obj.Url
            
            #line default
            #line hidden
, 4457), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 4470), Tuple.Create("\"", 4504)
, Tuple.Create(Tuple.Create("", 4476), Tuple.Create("Slide", 4476), true)
            
            #line 88 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
     , Tuple.Create(Tuple.Create(" ", 4481), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 4482), false)
, Tuple.Create(Tuple.Create(" ", 4492), Tuple.Create("of", 4493), true)
, Tuple.Create(Tuple.Create(" ", 4495), Tuple.Create("Carousel", 4496), true)
);

WriteLiteral(" class=\"img-responsive image1\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(">\r\n                                                <div");

WriteLiteral(" class=\"component-static-html img-topData hidden-xs\"");

WriteLiteral(">\r\n                                                    <h2>");

            
            #line 90 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                   Write(img.obj.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                                    <h3>");

            
            #line 91 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                   Write(img.obj.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                                    <p>");

            
            #line 92 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                  Write(img.obj.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                                </div>\r\n                   " +
"                         </a>\r\n");

            
            #line 95 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 5234), Tuple.Create("\"", 5255)
            
            #line 98 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 5243), Tuple.Create<System.Object, System.Int32>(img.obj.Url
            
            #line default
            #line hidden
, 5243), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 5256), Tuple.Create("\"", 5290)
, Tuple.Create(Tuple.Create("", 5262), Tuple.Create("Slide", 5262), true)
            
            #line 98 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
 , Tuple.Create(Tuple.Create(" ", 5267), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 5268), false)
, Tuple.Create(Tuple.Create(" ", 5278), Tuple.Create("of", 5279), true)
, Tuple.Create(Tuple.Create(" ", 5281), Tuple.Create("Carousel", 5282), true)
);

WriteLiteral(" class=\"img-responsive image1\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(">\r\n");

WriteLiteral("                                            <div");

WriteLiteral(" class=\"component-static-html img-topData hidden-xs\"");

WriteLiteral(">\r\n                                                <h2>");

            
            #line 100 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                               Write(img.obj.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                                <h3>");

            
            #line 101 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                               Write(img.obj.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                                <p>");

            
            #line 102 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                              Write(img.obj.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                                <p>\r\n");

            
            #line 104 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                    
            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                     if (img.obj.LinkType == LinkType.Button.GetHashCode().ToString())
                                                    {

            
            #line default
            #line hidden
WriteLiteral("                                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6004), Tuple.Create("\"", 6024)
            
            #line 106 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 6011), Tuple.Create<System.Object, System.Int32>(img.obj.Link
            
            #line default
            #line hidden
, 6011), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral("> ");

            
            #line 106 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                                                             Write(img.obj.ButtonText);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n");

            
            #line 107 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                    }

            
            #line default
            #line hidden
WriteLiteral("                                                </p>\r\n                           " +
"                 </div>\r\n");

            
            #line 110 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </div>\r\n");

            
            #line 113 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </div><a");

WriteLiteral(" class=\"left carousel-control\"");

WriteLiteral(" href=\"#carousel-example-generic\"");

WriteLiteral(" data-slide=\"prev\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"fa fa-chevron-left\"");

WriteLiteral("></span>\r\n                            </a>\r\n                            <a");

WriteLiteral(" class=\"right carousel-control\"");

WriteLiteral(" href=\"#carousel-example-generic\"");

WriteLiteral(" data-slide=\"next\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"fa fa-chevron-right\"");

WriteLiteral("></span>\r\n                            </a>\r\n                        </div>\r\n     " +
"               </div>\r\n");

            
            #line 122 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 124 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /* Start Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 125 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       Write(Html.Partial("~/Views/Search/Layout1/_SearchTopBar.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 126 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 126 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /* End Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 text-right\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"javascript:;\"");

WriteLiteral(" class=\"text-sm\"");

WriteLiteral(" ng-click=\"getView=true\"");

WriteLiteral(" ng-class=\"{\'text-green\':getView==true ?true :false}\"");

WriteLiteral(" title=\"Grid View\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-th\"");

WriteLiteral("></i></a>\r\n                    <a");

WriteLiteral(" href=\"javascript:;\"");

WriteLiteral(" class=\"text-sm\"");

WriteLiteral(" ng-click=\"getView=false\"");

WriteLiteral(" ng-class=\"{\'text-green\':getView==false ?true :false}\"");

WriteLiteral(" title=\"List View\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-list\"");

WriteLiteral("></i></a>\r\n                </div>\r\n            </div>\r\n\r\n");

            
            #line 134 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 134 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /*Start product Grid View*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"row products resultRow\"");

WriteLiteral(" ng-show=\"getView==true\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 136 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
           Write(Html.Partial("~/Views/Search/Layout1/_NoResults.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" ng-if=\"(pm.productResponse.productGroupModel.groups != null || pm.productRespons" +
"e.productGroupModel.groups>0)\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" ng-repeat=\"grp in pm.productResponse.productGroupModel.groups\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(" ng-show=\"pm.productResponse.productGroupModel.displayTitle\"");

WriteLiteral(">\r\n                            <h4");

WriteLiteral(" class=\"heading-h4\"");

WriteLiteral(" ng-bind=\"grp\"");

WriteLiteral("></h4>\r\n                        </div>\r\n");

            
            #line 142 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 142 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                         if (Model.ProductGroupModel != null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 groupSeparator\"");

WriteLiteral(">");

            
            #line 144 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                                       Write(Html.Raw(Model.ProductGroupModel.GroupSeparator));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 145 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"col-md-4 col-sm-6 col-xs-6 resultContainerRelated\"");

WriteLiteral(" ng-if=\"product.groupName.includes(grp)\"");

WriteLiteral(" ng-repeat=\"product in pm.productResponse.results track by $index\"");

WriteLiteral(" ng-cloak>\r\n");

WriteLiteral("                            ");

            
            #line 147 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                       Write(Html.Partial("~/Views/Search/Layout1/_ProductWidget.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n                <div");

WriteLiteral(" ng-if=\"(pm.productResponse.productGroupModel.groups == null || pm.productRespons" +
"e.productGroupModel.groups==0)\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-4 col-sm-6 col-xs-6 resultContainerRelated\"");

WriteLiteral(" ng-repeat=\"product in pm.productResponse.results track by $index\"");

WriteLiteral(" ng-cloak>\r\n");

WriteLiteral("                        ");

            
            #line 153 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   Write(Html.Partial("~/Views/Search/Layout1/_ProductWidget.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");

            
            #line 158 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 158 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /*Start product List View*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"row products resultRow\"");

WriteLiteral(" ng-show=\"getView==false\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 160 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
           Write(Html.Partial("~/Views/Search/Layout1/_NoResults.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" ng-if=\"(pm.productResponse.productGroupModel.groups !=null || pm.productResponse" +
".productGroupModel.groups.length>0)\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" ng-repeat=\"grp in pm.productResponse.productGroupModel.groups\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(" ng-show=\"pm.productResponse.productGroupModel.displayTitle\"");

WriteLiteral(">\r\n                            <h4");

WriteLiteral(" class=\"heading-h4\"");

WriteLiteral(" ng-bind=\"grp\"");

WriteLiteral("></h4>\r\n                        </div>\r\n");

            
            #line 166 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 166 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                         if (Model.ProductGroupModel != null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 groupSeparator\"");

WriteLiteral(" ng-hide=\"grp==\'\'\"");

WriteLiteral(">");

            
            #line 168 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                                                                                         Write(Html.Raw(Model.ProductGroupModel.GroupSeparator));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 169 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"col-md-12 col-sm-12 col-xs-12\"");

WriteLiteral(" ng-if=\"product.groupName.includes(grp)\"");

WriteLiteral(" ng-repeat=\"product in pm.productResponse.results track by $index\"");

WriteLiteral(" ng-cloak>\r\n");

WriteLiteral("                            ");

            
            #line 171 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                       Write(Html.Partial("~/Views/Search/Layout1/_ProductListWidget.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n                <div");

WriteLiteral(" ng-if=\"(pm.productResponse.productGroupModel.groups==null || pm.productResponse." +
"productGroupModel.groups.length==0)\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-12 col-sm-12 col-xs-12\"");

WriteLiteral(" ng-repeat=\"product in pm.productResponse.results track by $index\"");

WriteLiteral(" ng-cloak>\r\n");

WriteLiteral("                        ");

            
            #line 177 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
                   Write(Html.Partial("~/Views/Search/Layout1/_ProductListWidget.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 181 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 181 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /*End product listing row*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 183 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 183 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /* Start Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 184 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 184 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
             if (Model.Results != null && Model.Results.Count != 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"margin-top-lg\"");

WriteLiteral(" ng-hide=\"pm.productResponse == null || pm.productResponse.results==null||pm.prod" +
"uctResponse.total==0\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 187 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               Write(Html.Partial("~/Views/Search/Layout1/_SearchBottomBar.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 189 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 190 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
               /* End Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");

            
            #line 194 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 194 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /* End products container */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 196 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 196 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /*Start Product quick view detail popup*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 197 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
Write(Html.Partial("~/Views/Product/Layout1/_QuickViewModal.cshtml", new ProductDetailModel { }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 198 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 198 "..\..\Views\Search\Layout1\_SearchResultProducts.cshtml"
       /*End detail popup*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591
