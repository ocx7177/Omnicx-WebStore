﻿namespace Omnicx.API.SDK.Models.Common
{
    public class ChangePasswordModel
    {
        public string UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}