﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace test.Controllers
{
    public class WitajController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }
    }
}
