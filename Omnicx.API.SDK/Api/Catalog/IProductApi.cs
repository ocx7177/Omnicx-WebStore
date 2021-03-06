﻿using System.Collections.Generic;
using Omnicx.API.SDK.Models.Catalog;
using Omnicx.API.SDK.Models.Helpers;
using Omnicx.API.SDK.Models;
namespace Omnicx.API.SDK.Api.Catalog
{
    public interface IProductApi
    {
        ResponseModel<PaginatedResult<ProductModel>>  GetProducts(SearchRequestModel criteria);

        ResponseModel<TypeAheadSearchModel > SearchFreeText(string freeText);

        ResponseModel<ProductDetailModel>  GetProductDetail(string id);
        ResponseModel<ProductDetailModel>  GetProductDetailBySlug(string slug);
        ResponseModel< List<ProductModel>> GetRelatedProducts(string id);
        //ResponseModel<List<SortByModel>>  GetSortBy();
        ResponseModel<bool>  AddProductReview(string id,ProductReviewAddModel productReview);
        ResponseModel< List<KeywordRedirectModel>>  GetKeywordRedirect();
    }
}
