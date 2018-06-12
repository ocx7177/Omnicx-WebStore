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
    
    #line 1 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
    using Omnicx.API.SDK.Models.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Layout1/DynamicListItems.cshtml")]
    public partial class _Views_Search_Layout1_DynamicListItems_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Catalog.DynamicListModel>
    {
        public _Views_Search_Layout1_DynamicListItems_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
  
    ViewBag.Title = Model != null ? Model.Name : "";
    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";

    Html.AddTitleParts(Model.Name);
    Html.AddMetaTitle(Model.MetaTitle);
    Html.AddMetaDescriptionParts(Model.MetaDescription);
    Html.AddMetaKeywordsParts(Model.MetaKeywords);
    Html.AddCanonicalUrl(Model.CanonicalTags);
    Html.AddDataLayer(DataLayerObjectType.CollectionDetail, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n            <li><a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                       Write(LT("ProductListing.Breadcrumb.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 24 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
     if (Model != null)
    {
        if ((Model.ListType == ListDatasetSource.Product && Model.Products == null) || (Model.ListType == ListDatasetSource.Category && Model.Categories == null) || (Model.ListType == ListDatasetSource.Image && Model.Images == null) || (Model.ListType == ListDatasetSource.Brand && Model.Brands == null) || (Model.ListType == ListDatasetSource.SubBrand && Model.SubBrands == null) || (Model.ListType == ListDatasetSource.Blog && Model.Blogs == null))
        {
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
       Write(Html.Partial("~/Views/Search/Layout1/_NoResults.cshtml"));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                                                                     
        }

        if (Model.ListType == ListDatasetSource.Product && Model.Products != null)
        {
            foreach (var prod in Model.Products.Results)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1820), Tuple.Create("\"", 1838)
, Tuple.Create(Tuple.Create("", 1827), Tuple.Create("/", 1827), true)
            
            #line 38 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 1828), Tuple.Create<System.Object, System.Int32>(prod.Slug
            
            #line default
            #line hidden
, 1828), false)
);

WriteLiteral("> <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1845), Tuple.Create("\"", 1862)
            
            #line 38 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 1851), Tuple.Create<System.Object, System.Int32>(prod.Image
            
            #line default
            #line hidden
, 1851), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral("></a>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2090), Tuple.Create("\"", 2108)
, Tuple.Create(Tuple.Create("", 2097), Tuple.Create("/", 2097), true)
            
            #line 41 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 2098), Tuple.Create<System.Object, System.Int32>(prod.Slug
            
            #line default
            #line hidden
, 2098), false)
);

WriteLiteral("><h4>");

            
            #line 41 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                                                 Write(prod.Name);

            
            #line default
            #line hidden
WriteLiteral("</h4></a>\r\n                            <p>");

            
            #line 42 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                          Write(prod.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <h5>");

            
            #line 43 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                           Write(prod.Brand);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                            <p");

WriteLiteral(" class=\"price\"");

WriteLiteral(">\r\n");

            
            #line 45 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                                 if (@prod.Price != null)
                                { 
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                             Write(prod.Price.Formatted.WithTax);

            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                                                                }

            
            #line default
            #line hidden
WriteLiteral("                            </p>\r\n                        </div>\r\n               " +
"         <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <button");

WriteAttribute("ng-click", Tuple.Create(" ng-click=\"", 2567), Tuple.Create("\"", 2614)
, Tuple.Create(Tuple.Create("", 2578), Tuple.Create("gm.addToBasket(\'", 2578), true)
            
            #line 50 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 2594), Tuple.Create<System.Object, System.Int32>(prod.RecordId
            
            #line default
            #line hidden
, 2594), false)
, Tuple.Create(Tuple.Create("", 2608), Tuple.Create("\',1,0)", 2608), true)
);

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral(">Buy Now</button>\r\n                        </div>\r\n                    </div>\r\n  " +
"              </div>\r\n");

            
            #line 54 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
            }
        }


        if (Model.ListType == ListDatasetSource.Image && Model.Images != null)
        {
            foreach (var img in Model.Images)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3132), Tuple.Create("\"", 3148)
            
            #line 65 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 3139), Tuple.Create<System.Object, System.Int32>(img.Link
            
            #line default
            #line hidden
, 3139), false)
);

WriteLiteral(">\r\n                                <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 3188), Tuple.Create("\"", 3205)
            
            #line 66 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 3197), Tuple.Create<System.Object, System.Int32>(img.Url
            
            #line default
            #line hidden
, 3197), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n            " +
"        </div>\r\n                </div>\r\n");

            
            #line 71 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
            }
        }

        if (Model.ListType == ListDatasetSource.Brand && Model.Brands != null)
        {
            foreach (var brand in Model.Brands)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3823), Tuple.Create("\"", 3849)
            
            #line 81 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 3829), Tuple.Create<System.Object, System.Int32>(brand.LogoImageName
            
            #line default
            #line hidden
, 3829), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 84 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                           Write(brand.ManufacturerName);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p>");

            
            #line 85 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                          Write(brand.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4276), Tuple.Create("\"", 4295)
, Tuple.Create(Tuple.Create("", 4283), Tuple.Create("/", 4283), true)
            
            #line 88 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 4284), Tuple.Create<System.Object, System.Int32>(brand.Link
            
            #line default
            #line hidden
, 4284), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View</a>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n");

            
            #line 92 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
            }
        }
        if (Model.ListType == ListDatasetSource.SubBrand && Model.SubBrands != null)
        {
            foreach (var brand in Model.SubBrands)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4807), Tuple.Create("\"", 4833)
            
            #line 101 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 4813), Tuple.Create<System.Object, System.Int32>(brand.LogoImageName
            
            #line default
            #line hidden
, 4813), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 104 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                           Write(brand.ManufacturerName);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p>");

            
            #line 105 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                          Write(brand.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5260), Tuple.Create("\"", 5279)
, Tuple.Create(Tuple.Create("", 5267), Tuple.Create("/", 5267), true)
            
            #line 108 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 5268), Tuple.Create<System.Object, System.Int32>(brand.Link
            
            #line default
            #line hidden
, 5268), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View</a>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n");

            
            #line 112 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
            }
        }
        if (Model.ListType == ListDatasetSource.Category && Model.Categories != null)
        {
            foreach (var cat in Model.Categories)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"category-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 5792), Tuple.Create("\"", 5811)
            
            #line 121 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 5801), Tuple.Create<System.Object, System.Int32>(cat.Image
            
            #line default
            #line hidden
, 5801), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 124 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                           Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            ");

WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6226), Tuple.Create("\"", 6243)
, Tuple.Create(Tuple.Create("", 6233), Tuple.Create("/", 6233), true)
            
            #line 128 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 6234), Tuple.Create<System.Object, System.Int32>(cat.Link
            
            #line default
            #line hidden
, 6234), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View</a>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n");

            
            #line 132 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
            }
        }

        if (Model.ListType == ListDatasetSource.Blog && Model.Blogs != null)
        {
            foreach (var blog in Model.Blogs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"product-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"product-image-384\"");

WriteLiteral(">\r\n                            <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 6744), Tuple.Create("\"", 6768)
            
            #line 142 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 6753), Tuple.Create<System.Object, System.Int32>(blog.BlogImage
            
            #line default
            #line hidden
, 6753), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(" class=\"img-responsive img-full\"");

WriteLiteral(">\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-detail\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 145 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                           Write(blog.Title);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p>");

            
            #line 146 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                          Write(blog.Category);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <p>");

            
            #line 147 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
                          Write(blog.Author);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"product-button\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 7228), Tuple.Create("\"", 7251)
, Tuple.Create(Tuple.Create("", 7235), Tuple.Create("/blogs/", 7235), true)
            
            #line 150 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
, Tuple.Create(Tuple.Create("", 7242), Tuple.Create<System.Object, System.Int32>(blog.URL
            
            #line default
            #line hidden
, 7242), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral(">View Blogs</a>\r\n                        </div>\r\n                    </div>\r\n    " +
"            </div>\r\n");

            
            #line 154 "..\..\Views\Search\Layout1\DynamicListItems.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
