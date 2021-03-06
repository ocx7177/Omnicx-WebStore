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
    
    #line 1 "..\..\Views\Search\Layout1\DynamicList.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Search\Layout1\DynamicList.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Search\Layout1\DynamicList.cshtml"
    using Omnicx.API.SDK.Models.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Layout1/DynamicList.cshtml")]
    public partial class _Views_Search_Layout1_DynamicList_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Catalog.Collections>
    {
        public _Views_Search_Layout1_DynamicList_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Search\Layout1\DynamicList.cshtml"
  
    ViewBag.Title = "CollectionList";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Search\Layout1\DynamicList.cshtml"
  


    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";
    //Html.AddTitleParts(Model.Name);
    //Html.AddMetaDescriptionParts(Model.MetaDescription);
    //Html.AddMetaKeywordsParts(Model.MetaKeywords);
    //Html.AddCanonicalUrl(Model.CanonicalTags);
    Html.AddDataLayer(DataLayerObjectType.ProductDetail, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"row margin-top-md no-padding animated zoomIn\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral(">\r\n        <h3");

WriteLiteral(" class=\"brand-naming-h3\"");

WriteLiteral(">Product List</h3>\r\n    </div>\r\n");

            
            #line 23 "..\..\Views\Search\Layout1\DynamicList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Search\Layout1\DynamicList.cshtml"
     if (@Model.CollectionList != null && @Model.CollectionList.Count > 0)
    {


        foreach (var name in @Model.CollectionList)
        {
            if (@name.DataSource == ListDatasetSource.Product.GetHashCode())
            {


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-12 col-md-4 col-sm-4 no-padding-left col-lg-4 text-center brands-l" +
"ist animated zoomIn\"");

WriteLiteral(" style=\"position:relative; top:0px;\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1197), Tuple.Create("\"", 1215)
, Tuple.Create(Tuple.Create("", 1204), Tuple.Create("/", 1204), true)
            
            #line 33 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 1205), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 1205), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"over\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1299), Tuple.Create("\"", 1317)
, Tuple.Create(Tuple.Create("", 1306), Tuple.Create("/", 1306), true)
            
            #line 35 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 1307), false)
);

WriteLiteral(" class=\"Centerer\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Search\Layout1\DynamicList.cshtml"
                                                              Write(name.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n                    </a>\r\n                <" +
"/div>\r\n");

            
            #line 39 "..\..\Views\Search\Layout1\DynamicList.cshtml"

            }
        }




            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"brand-naming-h3\"");

WriteLiteral(">Category List</h3>\r\n        </div>\r\n");

            
            #line 48 "..\..\Views\Search\Layout1\DynamicList.cshtml"
        foreach (var name in @Model.CollectionList)
        {

            if (@name.DataSource == ListDatasetSource.Category.GetHashCode())
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-12 col-md-4 col-sm-4 no-padding-left col-lg-4 text-center brands-l" +
"ist animated zoomIn\"");

WriteLiteral(" style=\"position:relative; top:0px;\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1930), Tuple.Create("\"", 1948)
, Tuple.Create(Tuple.Create("", 1937), Tuple.Create("/", 1937), true)
            
            #line 54 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 1938), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 1938), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"over\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2032), Tuple.Create("\"", 2050)
, Tuple.Create(Tuple.Create("", 2039), Tuple.Create("/", 2039), true)
            
            #line 56 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 2040), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 2040), false)
);

WriteLiteral(" class=\"Centerer\"");

WriteLiteral(">");

            
            #line 56 "..\..\Views\Search\Layout1\DynamicList.cshtml"
                                                              Write(name.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n                    </a>\r\n                <" +
"/div>\r\n");

            
            #line 60 "..\..\Views\Search\Layout1\DynamicList.cshtml"
            }
        }




            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"brand-naming-h3\"");

WriteLiteral(">Brand List</h3>\r\n        </div>\r\n");

            
            #line 68 "..\..\Views\Search\Layout1\DynamicList.cshtml"
        foreach (var name in @Model.CollectionList)
        {
            if (@name.DataSource == ListDatasetSource.Brand.GetHashCode())
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-12 col-md-4 col-sm-4 no-padding-left col-lg-4 text-center brands-l" +
"ist animated zoomIn\"");

WriteLiteral(" style=\"position:relative; top:0px;\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2653), Tuple.Create("\"", 2671)
, Tuple.Create(Tuple.Create("", 2660), Tuple.Create("/", 2660), true)
            
            #line 73 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 2661), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 2661), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"over\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2755), Tuple.Create("\"", 2773)
, Tuple.Create(Tuple.Create("", 2762), Tuple.Create("/", 2762), true)
            
            #line 75 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 2763), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 2763), false)
);

WriteLiteral(" class=\"Centerer\"");

WriteLiteral(">");

            
            #line 75 "..\..\Views\Search\Layout1\DynamicList.cshtml"
                                                              Write(name.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n                    </a>\r\n                <" +
"/div>\r\n");

            
            #line 79 "..\..\Views\Search\Layout1\DynamicList.cshtml"

            }
        }



            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"brand-naming-h3\"");

WriteLiteral(">Image List</h3>\r\n        </div>\r\n");

            
            #line 87 "..\..\Views\Search\Layout1\DynamicList.cshtml"
        foreach (var name in @Model.CollectionList)
        {
            if (@name.DataSource == ListDatasetSource.Image.GetHashCode())
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-12 col-md-4 col-sm-4 no-padding-left col-lg-4 text-center brands-l" +
"ist animated zoomIn\"");

WriteLiteral(" style=\"position:relative; top:0px;\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3376), Tuple.Create("\"", 3394)
, Tuple.Create(Tuple.Create("", 3383), Tuple.Create("/", 3383), true)
            
            #line 92 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 3384), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 3384), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"over\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3478), Tuple.Create("\"", 3496)
, Tuple.Create(Tuple.Create("", 3485), Tuple.Create("/", 3485), true)
            
            #line 94 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 3486), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 3486), false)
);

WriteLiteral(" class=\"Centerer\"");

WriteLiteral(">");

            
            #line 94 "..\..\Views\Search\Layout1\DynamicList.cshtml"
                                                              Write(name.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n                    </a>\r\n                <" +
"/div>\r\n");

            
            #line 98 "..\..\Views\Search\Layout1\DynamicList.cshtml"

            }
        }



            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-xs-12 no-padding\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"brand-naming-h3\"");

WriteLiteral(">Blog List</h3>\r\n        </div>\r\n");

            
            #line 106 "..\..\Views\Search\Layout1\DynamicList.cshtml"
        foreach (var name in @Model.CollectionList)
        {
            if (@name.DataSource == ListDatasetSource.Blog.GetHashCode())
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-xs-12 col-md-4 col-sm-4 no-padding-left col-lg-4 text-center brands-l" +
"ist animated zoomIn\"");

WriteLiteral(" style=\"position:relative; top:0px;\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4097), Tuple.Create("\"", 4115)
, Tuple.Create(Tuple.Create("", 4104), Tuple.Create("/", 4104), true)
            
            #line 111 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 4105), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 4105), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"over\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4199), Tuple.Create("\"", 4217)
, Tuple.Create(Tuple.Create("", 4206), Tuple.Create("/", 4206), true)
            
            #line 113 "..\..\Views\Search\Layout1\DynamicList.cshtml"
, Tuple.Create(Tuple.Create("", 4207), Tuple.Create<System.Object, System.Int32>(name.Slug
            
            #line default
            #line hidden
, 4207), false)
);

WriteLiteral(" class=\"Centerer\"");

WriteLiteral(">");

            
            #line 113 "..\..\Views\Search\Layout1\DynamicList.cshtml"
                                                              Write(name.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n                    </a>\r\n                <" +
"/div>\r\n");

            
            #line 117 "..\..\Views\Search\Layout1\DynamicList.cshtml"

            }
        }

    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div><h3>No items in the dynamic lists.</h3></div>\r\n");

            
            #line 125 "..\..\Views\Search\Layout1\DynamicList.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
