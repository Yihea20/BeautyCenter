﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BeautyCenter.Models
{
    public class TokenRequest
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string rand { get; set; }
    }
}
