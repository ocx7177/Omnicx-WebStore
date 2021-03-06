﻿namespace Omnicx.API.SDK.Entities
{
    public static class CacheKeys
    {
        /// <summary>
        /// a cache key prefix is created to avoid mixing it with API / Business Hub Cache Keys
        /// </summary>
        private static string CacheKeyPrefix = "STORE." + ConfigKeys.OmnicxDomainId;
        /// <summary>
        /// Represents the PRODUCT DETAIL MODEL RETURNED BY THE API.
        /// This is done, so that the same object can be directly referred from the minimal store
        /// without making separate API call for the same product every time.
        /// CompanyId is added to provide a Customer specific version of the product in case 
        /// the logged in User is a B2B user and has specific pricing applied. 
        /// This is ONLY done at the Model level because the customer specific pricing is applied
        /// dynamically at the run time as of now. 
        /// {0}:ProductId, {1}:LangCulture, {2}: CompanyId
        /// </summary>
        public static string PRODUCT_MODEL_BY_ID = CacheKeyPrefix + ".PRODUCT.{0}.{1}.{2}.ById";

        /// <summary>
        /// 
        /// {0}:Slug, {1}:LangCulture, {2}: CompanyId
        /// </summary>
        public static string PRODUCT_MODEL_BY_SLUG = CacheKeyPrefix + ".PRODUCT.{0}.{1}.{2}.BySlug";

        /// <summary>
        /// Complete Site Nav Tree Model (through all sub-levels)- including the Header & footer
        /// USED_BY: FrontEnd to reduce the API calls.      
        /// </summary>
        public static string SITE_NAV_TREE_MODEL = CacheKeyPrefix + ".SITENAVTREE.MODEL";

        /// <summary>
        /// Represents a DynamicList (List Definition + Data) by SLUG
        /// {0}:SLUG
        /// </summary>
        public static string DYNAMIC_LIST_BY_SLUG = CacheKeyPrefix + ".DYNAMICLIST.{0}.{1}.{2}.BySLUG";

        /// <summary>
        /// Represents a DynamicList (List Definition + Data) by SLUG
        /// {0}:SLUG
        /// </summary>
        public static string CATEGORY_BY_SLUG = CacheKeyPrefix + ".CATEGORY.{0}.BySLUG";

        public static string WishList = CacheKeyPrefix + "WishList.{0}";
        /// <summary>
        /// Represents a SiteView Model returned by the API 
        /// {0}:Slug, {2}: Lang
        /// </summary>
        public static string SITEVIEW_MODEL_BY_SLUG = CacheKeyPrefix + ".SITEVIEW.MODEL.BySlug.{0}.{1}";

        /// <summary>
        /// {0}: Config Key
        /// </summary>
        //public static string DEFAULT_SETTING_BY_KEY = CacheKeyPrefix + "DEFAULT.CONFIG.{0}";
        //public const string DefaultSetting = "minimal.sefaultsetting-{0}";

        public static string SITE_CONFIG = CacheKeyPrefix + ".SITECONFIG";

        public static string BillingCountries = CacheKeyPrefix + "BillingCountries";
        public static string ReturnRedirect = CacheKeyPrefix + "Omni.redirectsettings-{0}";
        public static string FaqCategories = CacheKeyPrefix + "minimal.faqcategories";
        public static string FaqSubCategories = CacheKeyPrefix + "Omni.site.faq-Cat-{0}-{1}";
        public static string SiteViewAllSlug = CacheKeyPrefix + "Omni.SiteViewSlug-all-{0}";

    }
}
