﻿using System.Collections.Generic;
using Omnicx.API.SDK.Models.Catalog;
using RestSharp;
using Omnicx.API.SDK.Models;
using Omnicx.API.SDK.Entities;
using Omnicx.API.SDK.Api.Infra;
using System.Web.Mvc;

namespace Omnicx.API.SDK.Api.Catalog
{
    public class CollectionApi :ApiBase, ICollectionApi
    {
        public ResponseModel<DynamicListModel> GetCollectionBySlug(string slug)
        {
            var sessionContext = DependencyResolver.Current.GetService<ISessionContext>();
           var key = string.Format(CacheKeys.DYNAMIC_LIST_BY_SLUG, slug, sessionContext.CurrentSiteConfig?.RegionalSettings?.DefaultLanguageCulture, sessionContext.CurrentUser?.CompanyId);

            return FetchFromCacheOrApi<DynamicListModel>(key, ApiUrls.CollectionBySlug, slug, Method.POST, "slug", ParameterType.QueryString, "text/plain");
        }

        public ResponseModel<List<DynamicListCollection>> GetCollectionList()
        {
            return CallApi<List<DynamicListCollection>>(ApiUrls.CollectionList, "", Method.GET);
        }

    }
}
