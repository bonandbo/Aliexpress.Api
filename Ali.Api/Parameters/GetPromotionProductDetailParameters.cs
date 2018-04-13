﻿namespace Ali.Api.Parameters
{
    public struct GetPromotionProductDetailParameters
    {
        public const string DefaultFields = "productId,productTitle,productUrl,salePrice,originalPrice,imageUrl,evaluateScore";

        public string Fields { get; set; }
        public string ProductId { get; set; }
        public string LocalCurrency { get; set; }
        public string Language { get; set; }

        public GetPromotionProductDetailParameters(string fields = DefaultFields) : this()
        {
            Fields = fields;
        }
    }
}
