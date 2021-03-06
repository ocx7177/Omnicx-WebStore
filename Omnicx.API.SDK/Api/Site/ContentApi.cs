﻿using System.Collections.Generic;
using Omnicx.API.SDK.Entities;
using Omnicx.API.SDK.Models.Site;
using RestSharp;
using Omnicx.API.SDK.Models;
namespace Omnicx.API.SDK.Api.Site
{
    public class ContentApi : ApiBase, IContentApi
    {
        public ResponseModel<NavigationModel> GetMenuDetails()
        {
            return FetchFromCacheOrApi<NavigationModel> (string.Format(CacheKeys.SITE_NAV_TREE_MODEL), ApiUrls.MenuDetails);
        }
        public ResponseModel<List<FaqsCategoryModel>> GetFaqsCategories()
        {
            return FetchFromCacheOrApi<List<FaqsCategoryModel>>(string.Format(CacheKeys.FaqCategories), ApiUrls.FaqsCategories, "", Method.POST);
        }
        public ResponseModel<List<FaqsSubCategoryModel>> GetFaqsSubCategories(int faqType)
        {
            return FetchFromCacheOrApi<List<FaqsSubCategoryModel>>(string.Format(CacheKeys.FaqSubCategories, ConfigKeys.OmnicxDomainId.ToLower(), faqType), string.Format(ApiUrls.FaqsSubCategories, faqType), "", Method.POST);
        }

       
    }
}