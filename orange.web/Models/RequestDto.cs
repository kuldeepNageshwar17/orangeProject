﻿using System;
using System.Security.AccessControl;
using static orange.web.Uitility.SD;

namespace orange.web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }

    }
}

