﻿namespace Omnicx.API.SDK.Models.Commerce
{
    public class BasketAddressModel
    {
        public AddressModel BillingAddress { get; set; }
        public AddressModel ShippingAddress { get; set; }
    }
}
